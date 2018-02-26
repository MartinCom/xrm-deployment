using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private readonly ConfigReader _configReader;
        private readonly ObservableCollection<ConfigItemViewModel> _configs;
        private readonly string _projectBasePath;
        private ConfigItemViewModel _selectedConfig;

        public DeploymentDialogViewModel(ConfigReader configReader, string path)
        {
            _configReader = configReader;
            IDictionary<string, IConfigItem> items = _configReader.TryRead();
            if (items == null)
            {
                _configs = new ObservableCollection<ConfigItemViewModel>();
                _configs.Add(new ConfigItemViewModel(0));
            }
            else
            {
                _configs = new ObservableCollection<ConfigItemViewModel>(
                    _configReader.Read().Select(p => new ConfigItemViewModel(p)));
            }
            SelectedConfig = _configs.FirstOrDefault(p => p.IsDefault);

            _projectBasePath = path;
        }

        public event Action<bool> CloseRequest;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<ConfigItemViewModel> Configs
        {
            get
            {
                return _configs;
            }
        }

        public ConfigItemViewModel SelectedConfig
        {
            get { return _selectedConfig; }
            set
            {
                _selectedConfig = value;

                SetDefaultSelection(_selectedConfig != null ? _selectedConfig.Name : string.Empty);
                RaisePropertyChanged("SelectedConfig");
            }
        }

        private void SetDefaultSelection(string name)
        {
            foreach (ConfigItemViewModel item in _configs)
            {
                item.IsDefault = false;
                if (item.Name == name)
                {
                    item.IsDefault = true;
                }
            }
        }

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //    public ConfigItemViewModel SelectedConfig { get; set; }

        private static CrmServiceClient GetConnection(IConfigItem confgiItem)
        {
            CrmServiceClient client = new CrmServiceClient(confgiItem.ConnectionString);
            if (!string.IsNullOrWhiteSpace(client.LastCrmError))
            {
                throw new ApplicationException($"CrmServieClient initalization failed with error {client.LastCrmError}");
            }
            return client;
        }

        private void Deployment(object obj)
        {
            try
            {
                OutputWindowHelper.Log("Deployment Start..");
                CrmServiceClient client = GetConnection(SelectedConfig);
                AssemblyLoaderCrm loader = new AssemblyLoaderCrm(new OutputLog(), GetPath(SelectedConfig.Path), client, SelectedConfig.IsolationMode, SelectedConfig.SourceType);
                loader.Run();
                _configReader.Save(Configs.ToDictionary(k => k.Name, v => (IConfigItem)v));
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

        private string GetPath(string dllPath)
        {
            string path = dllPath;
            if (!dllPath.Contains(":"))
                path = $"{_projectBasePath}\\{dllPath}";
            return path;
        }

        private void RaisePropertChange([CallerMemberName]string propertyName = null)
        {
            if (propertyName == null)
                return;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void SaveAndClose(object obj)
        {
            _configReader.Save(Configs.ToDictionary(k => k.Name, v => (IConfigItem)v));
            CloseRequest?.Invoke(false);
        }

        #region Command

        public ICommand _cancelCommand;

        public ICommand _deployCommand;
        public ICommand _saveAndCloseCommand;
        public ICommand _addConfigCommand;
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

        public ICommand SaveAndCloseCommand
        {
            get
            {
                if (_saveAndCloseCommand == null)
                {
                    _saveAndCloseCommand = new RelayCommand(SaveAndClose);
                }
                return _saveAndCloseCommand;
            }
        }

        public ICommand AddConfigCommand
        {
            get
            {
                if (_addConfigCommand == null)
                {
                    _addConfigCommand = new RelayCommand(AddConfigElement);
                }
                return _addConfigCommand;
            }
        }

        private void AddConfigElement(object obj)
        {
            _configs.Add(new ConfigItemViewModel(_configs.Count));
            SelectedConfig = _configs.Last();

        }

        #endregion Command
    }
}