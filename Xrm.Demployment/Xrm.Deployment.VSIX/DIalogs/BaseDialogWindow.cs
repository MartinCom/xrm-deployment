using Microsoft.VisualStudio.PlatformUI;

namespace Xrm.Deployment.VSIX.DIalogs
{
    public class BaseDialogWindow : DialogWindow
    {
        protected BaseDialogWindow()
        {
            this.HasMaximizeButton = true;
            this.HasMinimizeButton = true;
        }
    }
}