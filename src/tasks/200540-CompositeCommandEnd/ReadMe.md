


# Introduces composite command. 
- First add a Wpf user control library
- Delete the default files AssemblyInfo.cs and UserControl1.xaml 
- Add Prism.Wpf package.
- Add Commands folder and into it, add a new class, and interface.
```cs

public interface IApplicationCommands
{
    CompositeCommand SaveAllCommand { get; }
}
public class ApplicationCommands : IApplicationCommands
{
    public CompositeCommand SaveAllCommand { get; } = new CompositeCommand();
}

``` 

- Add this project reference to both the older projets.
- Do the service registration in App file. Singleton registration

```cs
protected override void RegisterTypes(IContainerRegistry containerRegistry)
{
    containerRegistry.RegisterSingleton<IApplicationCommands, ApplicationCommands>();
}
```
- Add a view model for our main window class, that is ShellWindow, ShellWindowViewModel, and ensure the view is autowired to its View model.
- Arrange for ctor injection of IApplicationCommands object in the ShellWindowViewModel.
- Change the tab view model to the followng
- 
```cs
public TabViewModel(IApplicationCommands applicationCommands)
{
    UpdateCommand = new DelegateCommand(Update).ObservesCanExecute(() => CanUpdate);
    applicationCommands.SaveAllCommand.RegisterCommand(UpdateCommand);
}
``` 

- So we are registering the delegate command from the tab view model to the composite command. 
- Here we are regeisring. But for any reason, if we are removing a tab, then we must also remember to un register as well.
- So now run the app. We can hit Tab A, Tab B, Tab C. Save them individually if we like. But, look what if we click the Save All command now. We can see that all are Updated to same date and time, Tab B, same, Tab C, same. We have successfully used the CompositeCommand to save all three of these tabs at the same time. Also, note if just one of these RegisterCommands CanExecute returns false, then the CompositeCommand CanExecute returns false, and you can no longer invoke the CompositeCommand. However, we could still save the individual tabs individually. But if all of the CanExecutes of all the RegisterCommands return true, then the CompositeCommand CanExecute returns true, and we can then again use the CompositeCommand
