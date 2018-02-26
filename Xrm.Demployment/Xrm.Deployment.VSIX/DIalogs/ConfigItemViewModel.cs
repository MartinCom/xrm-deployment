using System.Collections.Generic;
using System.Runtime.Serialization;
using Xrm.Deployment.Core.Confg;

namespace Xrm.Deployment.VSIX.DIalogs
{
    public class ConfigItemViewModel : ConfigItem, IConfigItem
    {
        public ConfigItemViewModel(int index)
        {
            Name = $"new config {index}";
        }
        public ConfigItemViewModel(KeyValuePair<string, IConfigItem> element)
        {
            ConnectionString = element.Value.ConnectionString;
            Force = element.Value.Force;
            IsolationMode = element.Value.IsolationMode;
            Path = element.Value.Path;
            SourceType = element.Value.SourceType;
            Name = element.Key;
            IsDefault = element.Value.IsDefault;
        }

        public string Name { get; set; }
    }
}