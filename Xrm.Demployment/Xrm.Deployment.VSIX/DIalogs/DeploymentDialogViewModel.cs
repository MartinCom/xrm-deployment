using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xrm.Deployment.Core;
using Xrm.Deployment.Core.Confg;
using Xrm.Deployment.VSIX.Utils;
using Xrm.Deployment.VSIX.WPF;

namespace Xrm.Deployment.VSIX.DIalogs
{
    internal class DeploymentDialogViewModel : INotifyPropertyChanged
    {
        private readonly IEnumerable<ConfigItemViewModel> _configs;
        private readonly string _projectBasePath;
        public DeploymentDialogViewModel(IDictionary<string, IConfigItem> configs,string path)
        {
            _configs = configs.Select(p => new ConfigItemViewModel(p));
            SelectedConfig = _configs.First();

            _projectBasePath = path;
        }

        public event Action<bool> CloseRequest;

        public event PropertyChangedEventHandler PropertyChanged;

        public IEnumerable<ConfigItemViewModel> Configs
        {
            get
            {
                return _configs;
            }
        }

        public ConfigItemViewModel SelectedConfig { get; set; }

        private static CrmServiceClient GetConnection(IConfigItem confgiItem)
        {
            CrmServiceClient client = new CrmServiceClient(confgiItem.ConnectionString);
            if (!string.IsNullOrWhiteSpace(client.LastCrmError))
            {
                throw new ApplicationException($"CrmServieClient initalization failed with error {client.LastCrmError}");
            }
            return client;
        }
        private  string GetPath(string dllPath)
        {
            string path = dllPath;
            if (!dllPath.Contains(":"))
                path = $"{_projectBasePath}\\{dllPath}";
            return path;
        }

        private void Deployment(object obj)
        {
            try
            {
                OutputWindowHelper.Log("Deployment Start..");
                CrmServiceClient client = GetConnection(SelectedConfig);
                AssemblyLoaderCrm loader = new AssemblyLoaderCrm(new OutputLog(),GetPath(SelectedConfig.Path), client, SelectedConfig.IsolationMode, SelectedConfig.SourceType);
                loader.Run();
            }
            catch (Exception ex)
            {
                OutputWindowHelper.Log(ex.Message);
                OutputWindowHelper.Log(ex.ToString());
                throw;
            }
            finally
            {
                OutputWindowHelper.Log("Deployment Stop..");
                CloseRequest?.Invoke(false);
            }
        }

        private void RaisePropertChange([CallerMemberName]string propertyName = null)
        {
            if (propertyName == null)
                return;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #region Command

        public ICommand _cancelCommand;

        public ICommand _deployCommand;

        public ICommand CancelCommand
        {
            get
            {
                if (_cancelCommand == null)
                {
                    _cancelCommand = new RelayCommand(_ => CloseRequest?.Invoke(false));
                }
                return _cancelCommand;
            }
        }

        public ICommand DeployCommand
        {
            get
            {
                if (_deployCommand == null)
                {
                    _deployCommand = new RelayCommand(Deployment);
                }
                return _deployCommand;
            }
        }

        #endregion Command
    }
}