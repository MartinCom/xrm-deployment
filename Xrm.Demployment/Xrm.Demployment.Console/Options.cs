using CommandLine;
using Xrm.Deployment.Core.Enums;

namespace Xrm.Demployment.Console
{
    public class Options
    {
        [Option('p', "path",
           // Required = true,
        HelpText = "path for dll, C:/example/my.dll or my.dll")]
        public string DllPath { get; set; }

        [Option('e', "switchconfig",
      // Required = true,
      HelpText = "path for dll, C:/example/my.dll or my.dll")]
        public string ConfigurationElement { get; set; }

        [Option('c', "connectionstring",
            //Required = true,
        HelpText = "Connection string for Crm AuthType=IFD/OAuth/AD;Url=; Domain=; Username=; Password=;")]
        public string ConnectionString { get; set; }

        [Option('f', "fore",
            Default = false,
          //  Required = false,
            HelpText = "fore update dll (remove missing plugintypes (plugin class).")]
        public bool ForceUpdate { get; set; }

        [Option('i', "isolationmode",
          //  Required = true,
            HelpText = @"Isolation Mode:
                    None = 1,
                    Sandbox = 2,
        ")]
        public IsolationMode IsolationMode { get; set; }

        [Option('s', "sourcetype", Default = SourceType.Database,
            HelpText = @"Source Types:
                    Database = 0,
                    Disk = 1,
                    Normal = 2")]
        public SourceType SourceType { get; set; }
    }
}