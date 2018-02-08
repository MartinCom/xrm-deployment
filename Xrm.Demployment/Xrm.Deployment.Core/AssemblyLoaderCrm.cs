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
        public AssemblyLoaderCrm(string dllPath, IsolationMode isolationMode, SourceType sourceType = SourceType.Database)
        {
            _assemblySource = File.ReadAllBytes(dllPath);
            _isolationMode = isolationMode;
            _sourceType = sourceType;

           // XrmServiceContext ctx = new XrmServiceContext(null);
        }
        public AssemblyLoaderCrm(byte[] assemblySource, IsolationMode isolationMode, SourceType sourceType = SourceType.Database)
        {
            _assemblySource = assemblySource;
            _isolationMode = isolationMode;
            _sourceType = sourceType;
        }


        public IEnumerable<Entity> ReadCrmEntities()
        {
            LoadAssembly();
            Entity pluginAssembly = AssemblyToPluginAssembly();
            //Guid id = GetAssemblyId();
            //if(id != Guid.Empty)
            //{
            //    pluginAssembly.Id = id;
            //}
            yield return pluginAssembly;
            foreach (Type type in GetPluginsClassFromAssembly())
            {
                yield return ConvertToPluginType(type,pluginAssembly.ToEntityReference());
            }
        }

        private Entity ConvertToPluginType(Type pluginClassType,EntityReference pluginAssemblyReference)
        {
            string className = $"{pluginClassType.Namespace}.{pluginClassType.Name}";
            return new Entity("plugintype")
            {
                Id = Guid.NewGuid(),
                ["pluginassemblyid"] = pluginAssemblyReference,
                ["typename"] = className,//"Xrm.ExamplePlugin.ExamplePlugin" ,
                ["friendlyname"] = "plugin reg",
                ["name"] = "plugin reg",
                ["description"] = "plugin reg"
            };
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
                .Single();

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
