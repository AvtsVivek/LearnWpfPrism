# Basic Prism App with Modules
- This builds on earlier example.
- View model locator with a differnet naming conventions.
- Create a contols folder in the ModuleA project, then add a ControlA UserControl.
- So here there is Controls folder instead of Views folder. This is againest the conventions.
- So auto wiring does not work.
- So we need to setup the convetions explicitly. 
- 
- In the App.xaml.cs file of the SimplePrismShell project, override the method, ConfigureViewModelLocator.

```cs
protected override void ConfigureViewModelLocator()
{
    base.ConfigureViewModelLocator();

    ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver((viewType) =>
    {
        var viewName = viewType.FullName;
        var assemblyName = viewType.Assembly.FullName;
        var vmName = $"{viewName.Replace("Controls", "ViewModels")}ViewModel, {assemblyName}";
        return Type.GetType(vmName);
    });
}
```

- Also change the ModuleAModule class OnInitialized method
```cs
public void OnInitialized(IContainerProvider containerProvider)
{
    // The OnInitialized method will guarantee that the shell has been loaded and that the region has been created at this point
    _regionManager.RegisterViewWithRegion("ContentRegion", typeof(ControlA));
}
```
- Change the ViewModel class name to ControlAViewModel