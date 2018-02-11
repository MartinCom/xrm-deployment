using System;

namespace Xrm.Deployment.Core
{
    public class PluginTypeContainer
    {
        public PluginTypeContainer(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
        public bool IsInAssembly { get; set; }
    }
}