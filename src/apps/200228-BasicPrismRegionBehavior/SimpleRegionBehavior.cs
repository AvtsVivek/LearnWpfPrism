using Prism.Regions;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;

namespace BasicPrismRegion
{
    public class SimpleRegionBehavior : RegionBehavior
    {
        public const string BehaviorKey = "SimpleRegionBehavior";
        protected override void OnAttach()
        {
            Debugger.Break();
            
            Debug.WriteLine($"This behavior is attached to a region. And the name of that Region is {Region.Name}");
            Debug.WriteLine($"The number of views in this region are {Region.Views.ToList().Count}");
            Debug.WriteLine($"The number of active views in this region are {Region.ActiveViews.ToList().Count}");

            Region.ActiveViews.CollectionChanged += ActiveViews_CollectionChanged!;
        }
        private void ActiveViews_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                //foreach (var item in e.NewItems!)
                //{
                //    var regionManager = Region.RegionManager;

                //    var element = item as FrameworkElement;
                //    if (element != null)
                //    {
                //        var scopedRegionManager =
                //            element.GetValue(RegionManager.RegionManagerProperty) as IRegionManager;
                //        if (scopedRegionManager != null)
                //            regionManager = scopedRegionManager;
                //    }

                //    InvokeOnRegionManagerAwareElement(item, x => x.RegionManager = regionManager);
                //}
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                //foreach (var item in e.OldItems!)
                //{
                //    InvokeOnRegionManagerAwareElement(item, x => x.RegionManager = null!);
                //}
            }
        }
    }
}
