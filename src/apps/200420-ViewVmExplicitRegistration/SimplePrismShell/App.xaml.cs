using ModuleA;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using SimplePrismShell.Views;
using System;
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
            moduleCatalog.AddModule<ModuleAModule>();
        }

        //protected override void ConfigureViewModelLocator()
        //{
        //    base.ConfigureViewModelLocator();

        //    ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver((viewType) =>
        //    {
        //        var viewName = viewType.FullName;
        //        var assemblyName = viewType.Assembly.FullName;
        //        var vmName = $"{viewName.Replace("Controls", "ViewModels")}ViewModel, {assemblyName}";
        //        return Type.GetType(vmName);
        //    });
        //}

    }
}
