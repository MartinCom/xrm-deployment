using Xrm.Deployment.Core.Utils;

namespace Xrm.Deployment.VSIX.Utils
{
    public class OutputLog : ILog
    {
        public void Log(string message)
        {
            OutputWindowHelper.Log(message);
        }
    }
}