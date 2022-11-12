using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleA
{
    public class ModuleAModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            // throw new NotImplementedException();
            Debugger.Break();
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            Debugger.Break();
            // throw new NotImplementedException();
        }
    }
}
