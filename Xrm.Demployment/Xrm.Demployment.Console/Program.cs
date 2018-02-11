using CommandLine;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.IO;
using Xrm.Deployment.Core;

namespace Xrm.Demployment.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var parser = new Parser(with => {
            //    with.EnableDashDash = true;

            //});
            var result = Parser.Default.ParseArguments<Options>(args)
                 .WithParsed(opts => RunOptionsAndReturnExitCode(opts))
                 .WithNotParsed((errs) => HandleParseError(errs));
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

        private static object HandleParseError(IEnumerable<Error> errs)
        {
            //foreach (Error item in errs)
            //{
            //    System.Console.WriteLine($"{item.ToString()}");
            //}
            return null;
        }
    }
}