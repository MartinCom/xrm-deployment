using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xrm.Deployment.Core.Confg;
using Xrm.Deployment.Core.Enums;

namespace Xrm.Deployment.VSIX.DIalogs
{
    public class ConfigItemViewModel : IConfigItem
    {
        public ConfigItemViewModel(KeyValuePair<string,IConfigItem> element)
        {
            ConnectionString = element.Value.ConnectionString;
            Force = element.Value.Force;
            IsolationMode = element.Value.IsolationMode;
            Path = element.Value.Path;
            SourceType = element.Value.SourceType;
            Name = element.Key;
        }
        public string ConnectionString { get; }

        public bool Force { get; }

        public IsolationMode IsolationMode { get; }

        public string Path { get; }

        public SourceType SourceType { get; }
        public string Name { get; }
    }
}
