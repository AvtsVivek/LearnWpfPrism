
# Introduces Basic Navigation with Regions. 
- This is just a startring point for the next example.

```cs
public void RegisterTypes(IContainerRegistry containerRegistry)
{
    containerRegistry.RegisterForNavigation<ViewA>();
    containerRegistry.RegisterForNavigation<ViewB>();
}
```   

- Add the following to the ShellWindowViewModel. THe default ctor in that class can be removed.

```cs
public DelegateCommand<string> NavigateCommand { get; private set; }

public ShellWindowViewModel(IRegionManager regionManager)
{
    NavigateCommand = new DelegateCommand<string>(Navigate);
}

private void Navigate(string viewName)
{

}

```

- Now bind buttons to the NavigateCommand.
```xml
<Button Command="{Binding NavigateCommand}" CommandParameter="ViewA" Margin="5">Navigate to View A</Button>
<Button Command="{Binding NavigateCommand}" CommandParameter="ViewB" Margin="5">Navigate to View B</Button>
```
- Now to navigate, we need a region manager in the ShellViewModel

```cs
private readonly IRegionManager _regionManager;

public DelegateCommand<string> NavigateCommand { get; private set; }

public ShellWindowViewModel(IRegionManager regionManager)
{
    NavigateCommand = new DelegateCommand<string>(Navigate);
    _regionManager = regionManager;
}

private void Navigate(string viewName)
{
    _regionManager.RequestNavigate("ContentRegion", viewName);
}

```
- Now run the app. Click the first button and the second button. See that ViewA and ViewB are displayed.

