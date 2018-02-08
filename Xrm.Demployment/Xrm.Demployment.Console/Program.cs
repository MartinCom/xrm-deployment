using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using Xrm.Deployment.Core;
using System.Reflection;

namespace Xrm.Demployment.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyLoaderCrm loader = new AssemblyLoaderCrm(Directory.GetCurrentDirectory() + "\\Xrm.ExamplePlugin.dll", Deployment.Core.Enums.IsolationMode.Sandbox);
            var items2 = loader.ReadCrmEntities().ToArray();
            Assembly assmembly = Assembly.LoadFile(Directory.GetCurrentDirectory()+"\\Xrm.ExamplePlugin.dll");
            string[] props = assmembly.GetName().FullName.Split(",= ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Entity assemblyEntity = new Entity("pluginassembly")
            {
                Id = Guid.NewGuid(),
                ["name"] = props[0],
                ["culture"] = props[4],
                ["publickeytoken"] = props[6],
                ["sourcetype"] = new OptionSetValue(0),
                ["isolationmode"] = new OptionSetValue(1),
                ["content"] = Convert.ToBase64String(File.ReadAllBytes("Xrm.ExamplePlugin.dll"))
            };


            var type = typeof(IPlugin);
            IEnumerable<Type> types = assmembly
                .GetTypes()
                .Where(p => type.IsAssignableFrom(p) && !p.IsInterface && p.IsClass && !p.IsAbstract);
            //Register Plugin
            foreach (Type typeItem in types)
            {
                Entity pluginType = new Entity("plugintype")
                {
                    Id = typeItem.GUID,
                    ["pluginassemblyid"] = new EntityReference("pluginassembly"),
                    ["typename"] = typeItem.Name,//"Xrm.ExamplePlugin.ExamplePlugin" ,
                    ["friendlyname"] = "plugin reg",
                    ["name"] = "plugin reg",
                    ["description"] = "plugin reg"
                };
            }
           

            //https://www.magnetismsolutions.com/blog/gayanperera/2016/03/03/register-crm-2016-plugins-and-steps-programmatically
            //https://community.dynamics.com/crm/f/117/t/170702
            string connectionString = ConfigurationManager.ConnectionStrings["Crm"].ConnectionString;
            CrmServiceClient _organizationService = new CrmServiceClient(connectionString);
            if (!string.IsNullOrWhiteSpace(_organizationService.LastCrmError))
            {
                throw new ApplicationException(_organizationService.LastCrmError);
            }
            XrmServiceContext ctx = new  XrmServiceContext(_organizationService);
            ;
            var items = ctx.PluginAssemblySet.ToList();
            PluginAssembly plugin = new PluginAssembly()
            {
                Content = Convert.ToBase64String(File.ReadAllBytes(@"C:\Releases\Sii.Crm.Plugins.merged.dll")),
                IsolationMode = new OptionSetValue((int) PluginAssembly.Enums.IsolationMode.Sandbox),
                
            };
            PluginType plug = new PluginType()
            {
                PluginAssemblyId = null
            };
           Guid id= _organizationService.Create(plugin);

        }
    }
}
