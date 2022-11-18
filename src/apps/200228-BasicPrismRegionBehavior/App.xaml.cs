using BasicPrismRegion.Views;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Regions;
using System.Windows;

namespace BasicPrismRegion
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<ShellWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureDefaultRegionBehaviors(IRegionBehaviorFactory regionBehaviors)
        {
            base.ConfigureDefaultRegionBehaviors(regionBehaviors);
            regionBehaviors.AddIfMissing(SimpleRegionBehavior.BehaviorKey, typeof(SimpleRegionBehavior));
        }
    }
}
