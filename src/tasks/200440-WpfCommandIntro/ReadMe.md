# Basic Prism App with Modules
- This builds on earlier example.
- View model locator with a differnet naming conventions.
- Create a contols folder in the ModuleA project, then add a ControlA UserControl.
- So here there is Controls folder instead of Views folder. This is againest the conventions.
- So auto wiring does not work.
- So we need to setup the convetions explicitly. 
- In the last example we added a method which overrides ConfigureViewModelLocator in the App.xaml.cs file of the SimplePrismShell project.
- This method setsup a convention to connect view models with views.
- In this example, we will explicityly register a view model with a view. 
- So first remove the method added in the last exmaple. 

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

- Next in the ModuleAModule file, explicitly register as follows.
```cs
public void RegisterTypes(IContainerRegistry containerRegistry)
{
    // You can use either of the two ways to register. In the first we specify the type, do the vmlocator will create an instance and then assign to the datacontext on the view.
    // In the next one, we as a developer will create an instance of hte view model, so the vm locator will simply use that.
    // ViewModelLocationProvider.Register<ControlA, ControlAViewModel>();
    ViewModelLocationProvider.Register<ControlA>(() => new ControlAViewModel() { WelcomeMessage = "Hello from Factory" });
}
```

- Also note that this way of registration does not use reflection, where as the earlier method uses reflection.