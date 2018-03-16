using System.Windows;

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
            //DocumentationTextBox.Focus();
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