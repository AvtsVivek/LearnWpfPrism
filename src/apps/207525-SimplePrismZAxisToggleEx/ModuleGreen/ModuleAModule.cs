using ModuleGreen.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ModuleGreen
{
    public class ModuleGreeenModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public ModuleGreeenModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            // The OnInitialized method will guarantee that the shell has been loaded and that the region has been created at this point
            _regionManager.RegisterViewWithRegion("GreenRegion", typeof(ViewGreen));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
