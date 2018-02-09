using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xrm.Deployment.Core.Enums;

namespace Xrm.Deployment.Core
{
    public class AssemblyLoaderCrm
    {
        private readonly byte[] _assemblySource;
        private Assembly _assembly;
        private readonly SourceType _sourceType;
        private readonly IsolationMode _isolationMode;
        private readonly XrmServiceContext _ctx;
        private readonly IOrganizationService _organizationService;
        public AssemblyLoaderCrm(string dllPath, IOrganizationService organizationService, IsolationMode isolationMode, SourceType sourceType = SourceType.Database)
        {
            _assemblySource = File.ReadAllBytes(dllPath);
            _isolationMode = isolationMode;
            _sourceType = sourceType;
            _organizationService = organizationService;
            _ctx = new XrmServiceContext(_organizationService);
            // XrmServiceContext ctx = new XrmServiceContext(null);
        }
        public AssemblyLoaderCrm(byte[] assemblySource, IOrganizationService organizationService, IsolationMode isolationMode, SourceType sourceType = SourceType.Database)
        {
            _assemblySource = assemblySource;
            _isolationMode = isolationMode;
            _sourceType = sourceType;
            _organizationService = organizationService;
            _ctx = new XrmServiceContext(_organizationService);
        }


        public IEnumerable<Entity> ReadCrmEntities()
        {
            LoadAssembly();
            Entity pluginAssembly = AssemblyToPluginAssembly();
            Guid id = GetAssemblyId();
            if (id != Guid.Empty)
            {
                pluginAssembly.Id = id;
                pluginAssembly.EntityState = EntityState.Changed;
            }
             yield return pluginAssembly;
            IDictionary<string, PluginTypeContainer> pluginTypesInAssembly = RetrivePluginTypesInAssembly(pluginAssembly.Id);
            foreach (Type type in GetPluginsClassFromAssembly())
            {
                yield return ConvertToPluginType(type, pluginAssembly.ToEntityReference(), pluginTypesInAssembly);
            }
            foreach (KeyValuePair<string,PluginTypeContainer> item in pluginTypesInAssembly.Where(p=> !p.Value.IsInAssembly))
            {
                yield return new Entity("plugintype", item.Value.Id) { EntityState = EntityState.Unchanged };
            }
        }

        private IDictionary<string, PluginTypeContainer> RetrivePluginTypesInAssembly(Guid id)
        {
            return _ctx.PluginTypeSet
                .Where(p => p.PluginAssemblyId.Id == id)
                .Select(p => new { Id = p.Id, Name = p.Name })
                .ToDictionary(k => k.Name, v =>new PluginTypeContainer( v.Id));
        }

        private Entity ConvertToPluginType(Type pluginClassType, EntityReference pluginAssemblyReference, IDictionary<string, PluginTypeContainer> pluginTypesInAssemblyDictionary)
        {

            string className = $"{pluginClassType.Namespace}.{pluginClassType.Name}";


            Entity pluginType = new Entity("plugintype")
            {
                Id = Guid.NewGuid(),
                ["pluginassemblyid"] = pluginAssemblyReference,
                ["typename"] = className,//"Xrm.ExamplePlugin.ExamplePlugin" ,
                ["friendlyname"] = className,
                ["name"] = className,
                ["description"] = "reg from xrm.deployment"
            };
            if (pluginTypesInAssemblyDictionary.ContainsKey(className))
            {
                pluginType.Id = pluginTypesInAssemblyDictionary[className].Id;
                pluginType.EntityState = EntityState.Changed;
                pluginTypesInAssemblyDictionary[className].IsInAssembly = true;
            }

            return pluginType;
        }

        private IEnumerable<Type> GetPluginsClassFromAssembly()
        {
            Type pluginInterfaceType = typeof(IPlugin);
            return _assembly
                .GetTypes()
                .Where(p => pluginInterfaceType.IsAssignableFrom(p) && !p.IsInterface && p.IsClass && !p.IsAbstract);
        }

        private Guid GetAssemblyId()
        {
            return _ctx.PluginAssemblySet
                .Where(p => p.Name == AssemblyName)
                .Select(p => p.Id)
                .SingleOrDefault();

        }
        private string AssemblyName;
        private string AssemblyCulture;
        private string AssemblyPublicToken;
        private Entity AssemblyToPluginAssembly()
        {
            string[] props = _assembly.GetName().FullName.Split(",= ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            AssemblyName = props[0];
            AssemblyCulture = props[4];
            AssemblyPublicToken = props[6];

            //Xrm.ExamplePlugin	09.02.2018 20:40:19	26c45b77-9095-4940-9810-ea73816fa24a	Xrm.ExamplePlugin.ExamplePlugin	Xrm.ExamplePlugin.ExamplePlugin			Yes	75a9c58d-e376-4fc6-ad1e-b5ce4493f080

            return new Entity("pluginassembly")
            {
                Id = Guid.NewGuid(),
                ["name"] = AssemblyName,
                ["culture"] = AssemblyCulture,
                ["publickeytoken"] = AssemblyPublicToken,
                ["sourcetype"] = new OptionSetValue((int)_sourceType),
                ["isolationmode"] = new OptionSetValue((int)_isolationMode),
                ["content"] = Convert.ToBase64String(_assemblySource)
            };

        }

        private void LoadAssembly()
        {
            _assembly = Assembly.Load(_assemblySource);
        }
    }
}
