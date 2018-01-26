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

namespace Xrm.Demployment.Console
{
    class Program
    {
        static void Main(string[] args)
        {
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

           Guid id= _organizationService.Create(plugin);

        }
    }
}
