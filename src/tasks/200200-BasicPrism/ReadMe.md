# Basic Prism App
- Creates a basic Wpf app and then adds Prism to it.

- Create a wpf app.

- Add nuget packages Prism.DryIoc

- Remove from App.xaml file the following line. 
```xml
StartupUri="MainWindow.xaml"
```

- Add Prism namespace
```xml
xmlns:prism="http://prismlibrary.com/"
```

- Change the Applicattion class to Prism Application class.

```xml
prism:PrismApplication
```

- In the app.cs class, change the base derived class from Application to PrismApplication.

```cs
public partial class App : PrismApplication
{

}
```

- Impliment the abstract class.

```cs
protected override Window CreateShell()
{
    throw new System.NotImplementedException();
}

protected override void RegisterTypes(IContainerRegistry containerRegistry)
{
    throw new System.NotImplementedException();
}
```
- Finally since we are no longer using MainWindow.xaml, simply remove the xaml and cs file.
- Also remove Views and ViewModels folders to the app.

- Use Visual Studio 2022 to create a new ShellWindow. Just a regular Wpf window and name it ShellWindow. Add some content to show some stuff in there.


```cs
protected override Window CreateShell()
{
    return Container.Resolve<ShellWindow>();
}
protected override void RegisterTypes(IContainerRegistry containerRegistry)
{

}
```

- Now run, the app 