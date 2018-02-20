using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Xrm.Deployment.VSIX.DIalogs
{
    /// <summary>
    /// Interaction logic for DeploymentDialog.xaml
    /// </summary>
    public partial class DeploymentDialog 
    {
        public DeploymentDialog()
        {
            InitializeComponent();
            Loaded += OnLoaded;
        }
        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            DocumentationTextBox.Focus();
            RegisterToViewModelEvents();
        }

        private void RegisterToViewModelEvents()
        {
            var vm = (DataContext as DeploymentDialogViewModel);
            vm.CloseRequest += (res) =>
            {
                this.DialogResult = res;
                this.Close();
            };
        }
    }
}
