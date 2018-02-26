using System.Runtime.Serialization;
using Xrm.Deployment.Core.Enums;

namespace Xrm.Deployment.Core.Confg
{
    
    public class ConfigItem : IConfigItem
    {
        public ConfigItem()
        {

        }
        public ConfigItem(IConfigItem configItem)
        {
            ConnectionString = configItem.ConnectionString;
            Force = configItem.Force;
            IsolationMode = configItem.IsolationMode;
            Path = configItem.Path;
            SourceType = configItem.SourceType;

        }
        [DataMember(Name = "connectionString")]
        public string ConnectionString { get; set; }

        [DataMember(Name = "force")]
        public bool Force { get; set; }

        [DataMember(Name = "isolationmode")]
        public IsolationMode IsolationMode { get; set; }

        [DataMember(Name = "path")]
        public string Path { get; set; }

        [DataMember(Name = "sourcetype")]
        public SourceType SourceType { get; set; }
        public bool IsDefault { get; set; }


    }
}