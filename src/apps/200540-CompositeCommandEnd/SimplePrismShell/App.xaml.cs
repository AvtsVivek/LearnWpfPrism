using ModuleA;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using SimplePrismShell.Core.Commands;
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
            containerRegistry.RegisterSingleton<IApplicationCommands, ApplicationCommands>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleAModule>();
        }

    }
}
