using ModuleA.Views;
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
            IRegion region = _regionManager.Regions["ContentRegion"];

            var view1 = containerProvider.Resolve<ViewA>();

            var view2 = containerProvider.Resolve<ViewA>();
            view2.Content = new TextBlock()
            {
                Text = "Hello from View 2",
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = System.Windows.VerticalAlignment.Center
            };

            region.Add(view1);

            region.Add(view2);

            region.Activate(view2);

            region.Activate(view1);

            region.Deactivate(view1);

            region.Activate(view2);

            region.Remove(view2);

            region.Activate(view1);
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
