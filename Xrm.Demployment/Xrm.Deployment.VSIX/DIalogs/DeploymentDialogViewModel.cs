using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xrm.Deployment.Core.Confg;

namespace Xrm.Deployment.VSIX.DIalogs
{
    class DeploymentDialogViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertChange([CallerMemberName]string propertyName = null)
        {
            if (propertyName == null)
                return;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event Action<bool> CloseRequest;


        private readonly IEnumerable<ConfigItemViewModel> _configs;

        public DeploymentDialogViewModel(IDictionary<string, IConfigItem> configs)
        {
            _configs = configs.Select(p => new ConfigItemViewModel(p));
        }

        public ConfigItemViewModel SelectedConfig { get; set; }
        public IEnumerable<ConfigItemViewModel> Configs
        {
            get
            {

                return _configs;
            }
        }
    }
}
