using System.Runtime.Serialization;
using Xrm.Deployment.Core.Enums;

namespace Xrm.Deployment.Core.Confg
{
    [DataContract]
    internal class ConfigItem : IConfigItem
    {
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


    }
}