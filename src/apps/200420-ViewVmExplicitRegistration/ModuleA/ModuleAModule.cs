using ModuleA.Controls;
using ModuleA.ViewModels;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ModuleA
{
    public class ModuleAModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public ModuleAModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            // The OnInitialized method will guarantee that the shell has been loaded and that the region has been created at this point
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(ControlA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // ViewModelLocationProvider.Register<ControlA, ControlAViewModel>();

            ViewModelLocationProvider.Register<ControlA>(() => new ControlAViewModel() { WelcomeMessage = "Hello from Factory" });
        }
    }
}
