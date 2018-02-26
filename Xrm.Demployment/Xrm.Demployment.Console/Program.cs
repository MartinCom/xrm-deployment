using CommandLine;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xrm.Deployment.Core;
using Xrm.Deployment.Core.Confg;
using Xrm.Deployment.Core.Enums;
using Xrm.Deployment.Core.Utils;

namespace Xrm.Demployment.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {


            if (args.Length <= 0)
            {
                ConfigReader reader = new ConfigReader(new ConsoleLog());
                IDictionary<string, IConfigItem> configs = reader.Read();
                if (configs != null && configs.Count > 0)
                {
                    RunOnConfigDefault(configs.Values.First());
                    return;
                }
            }

            var result = Parser.Default.ParseArguments<Options>(args)
                 .WithParsed(opts => RunOptionsAndReturnExitCode(opts))
                 .WithNotParsed((errs) => HandleParseError(errs));
        }

        private static void RunOnConfigDefault(IConfigItem configItem)
        {
            CrmServiceClient client = GetConnection(configItem);
            AssemblyLoaderCrm loader = new AssemblyLoaderCrm(new ConsoleLog(),configItem.Path, client, configItem.IsolationMode, configItem.SourceType);
            loader.Run();
        }

        private static void RunOptionsAndReturnExitCode(Options opts)
        {
            CrmServiceClient client;
            string path;
            IsolationMode isolationMode;
            SourceType sourceType;
            if (!string.IsNullOrWhiteSpace(opts.ConfigurationElement))
            {
                ConfigReader reader = new ConfigReader(new ConsoleLog());
                IDictionary<string, IConfigItem> configs = reader.Read();
                if (configs == null || configs.Count <= 0)
                {
                    throw new ApplicationException("Missing COnfiguration when argument switchconfig present");
                }
                if (!configs.ContainsKey(opts.ConfigurationElement))
                    throw new ApplicationException($"Missing Configuration elment:{opts.ConfigurationElement} when argument switchconfig present");
                IConfigItem config = configs[opts.ConfigurationElement];
                client = GetConnection(config);
                path = GetPath(config.Path);
                isolationMode = config.IsolationMode;
                sourceType = config.SourceType;
            }
            else
            {
                client = GetConnection(opts);
                path = GetPath(opts.DllPath);
                isolationMode = opts.IsolationMode;
                sourceType = opts.SourceType;
            }

            AssemblyLoaderCrm loader = new AssemblyLoaderCrm(new ConsoleLog(),path, client, isolationMode, sourceType);
            loader.Run();
        }

        private static string GetPath(string dllPath)
        {
            string path = dllPath;
            if (!dllPath.Contains("/") || !dllPath.Contains(":"))
                path = $"{Directory.GetCurrentDirectory()}\\{dllPath}";
            return path;
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