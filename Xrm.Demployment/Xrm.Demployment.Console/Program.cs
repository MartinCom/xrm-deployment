using CommandLine;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.IO;
using Xrm.Deployment.Core;
using Xrm.Deployment.Core.Confg;
using System.Linq;

namespace Xrm.Demployment.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ConfigReader reader = new ConfigReader();
            IDictionary<string,IConfigItem> configs = reader.Read();
            if(configs != null  && configs.Count > 0 && args.Length <=0)
            {
                RunOnConfigDefault(configs.Values.First());
                return;
            }
       
            var result = Parser.Default.ParseArguments<Options>(args)
                 .WithParsed(opts => RunOptionsAndReturnExitCode(opts))
                 .WithNotParsed((errs) => HandleParseError(errs));
        }

        private static void RunOnConfigDefault(IConfigItem configItem)
        {
            CrmServiceClient client = GetConnection(configItem);
            AssemblyLoaderCrm loader = new AssemblyLoaderCrm(configItem.Path, client, configItem.IsolationMode, configItem.SourceType);
            loader.Run();
        }

        

        private static void RunOptionsAndReturnExitCode(Options opts)
        {
            CrmServiceClient client = GetConnection(opts);
            string path = opts.DllPath;
            if (!opts.DllPath.Contains("/") || !opts.DllPath.Contains(":"))
                path = $"{Directory.GetCurrentDirectory()}\\{opts.DllPath}";

            AssemblyLoaderCrm loader = new AssemblyLoaderCrm(path, client, opts.IsolationMode, opts.SourceType);
            loader.Run();
        }

        private static CrmServiceClient GetConnection(Options opts)
        {
            CrmServiceClient client = new CrmServiceClient(opts.ConnectionString);
            if (!string.IsNullOrWhiteSpace(client.LastCrmError))
            {
                throw new ApplicationException($"CrmServieClient initalization failed with error {client.LastCrmError}");
            }
            return client;
        }
        private static CrmServiceClient GetConnection(IConfigItem confgiItem)
        {
            CrmServiceClient client = new CrmServiceClient(confgiItem.ConnectionString);
            if (!string.IsNullOrWhiteSpace(client.LastCrmError))
            {
                throw new ApplicationException($"CrmServieClient initalization failed with error {client.LastCrmError}");
            }
            return client;
        }

        private static object HandleParseError(IEnumerable<Error> errs)
        {
            return null;
        }
    }
}