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
            string connection = @"AuthType=IFD;Url=; Domain=; Username=; Password=;";
            CrmServiceClient client = new CrmServiceClient(connection);
            AssemblyLoaderCrm loader = new AssemblyLoaderCrm(Directory.GetCurrentDirectory() + "\\Xrm.ExamplePlugin.dll", client, Deployment.Core.Enums.IsolationMode.Sandbox);
            foreach (Entity item in loader.ReadCrmEntities().OrderBy(p=>p.EntityState))
            {
                switch (item.EntityState)
                {
                    case EntityState.Changed:
                        client.Update(item);
                        break;
                    case EntityState.Created:
                        Guid idEntity = client.Create(item);
                        break;
                    case EntityState.Unchanged:
                        client.Delete(item.LogicalName,item.Id);
                        break;
                  
                }
              
            }           
        }
    }
}
