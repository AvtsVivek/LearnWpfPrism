using ModuleA;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using SimplePrismShell.Views;
using System.Diagnostics;
using System.Windows;

namespace SimplePrismShell
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

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            Debugger.Break();
            moduleCatalog.AddModule<ModuleAModule>();
            Debugger.Break();
        }

    }
}
