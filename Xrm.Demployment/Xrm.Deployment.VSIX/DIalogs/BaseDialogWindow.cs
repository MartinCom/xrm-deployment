using Microsoft.VisualStudio.PlatformUI;

namespace Xrm.Deployment.VSIX.DIalogs
{
    public class BaseDialogWindow : DialogWindow
    {
        public BaseDialogWindow()
        {
            this.HasMaximizeButton = true;
            this.HasMinimizeButton = true;
        }
    }
}