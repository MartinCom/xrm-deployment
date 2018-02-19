using Xrm.Deployment.Core.Enums;

namespace Xrm.Deployment.Core.Confg
{
    public interface IConfigItem
    {
        string ConnectionString { get; }
        bool Force { get;  }
        IsolationMode IsolationMode { get;  }
        string Path { get; }
        SourceType SourceType { get; }
    }
}