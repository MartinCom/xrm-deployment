using System.Runtime.Serialization;
using Xrm.Deployment.Core.Enums;

namespace Xrm.Deployment.Core.Confg
{
   
    public interface IConfigItem
    {
        [DataMember(Name = "connectionString")]
        string ConnectionString { get; }
        [DataMember(Name = "force")]
        bool Force { get;  }

        [DataMember(Name = "isolationmode")]
        IsolationMode IsolationMode { get;  }
        [DataMember(Name = "path")]
        string Path { get; }
        [DataMember(Name = "sourcetype")]
        SourceType SourceType { get; }
        [DataMember(Name = "isDefault")]
        bool IsDefault { get; }
        
    }
}