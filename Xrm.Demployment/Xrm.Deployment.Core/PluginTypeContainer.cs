using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrm.Deployment.Core
{
   public class PluginTypeContainer
    {
        public PluginTypeContainer(Guid id)
        {
            Id = id;
        }
        public Guid Id { get;  }
        public bool IsInAssembly { get; set; }
    }
}

