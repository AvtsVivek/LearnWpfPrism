# Basic Prism App with Modules
- This builds on earlier example 200380-ViewModelLocator
- Introduces the delegate command, a simple implimentation of ICommand.

```xml

<StackPanel>
    <Button Content="Click Me" Command="{Binding ClickCommand}"/>
    <TextBlock Text="{Binding WelcomeMessage}" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="50" />
</StackPanel>


```

- Also in the View Model add a Delegate Command as follows

```cs
public DelegateCommand ClickCommand { get; set; }
public ViewAViewModel()
{
    ClickCommand = new DelegateCommand(ButtonClick, CanButtonClick);
}
private bool CanButtonClick()
{
    return true;
}
private void ButtonClick()
{
    WelcomeMessage = "You Clicked me!";
}
```

- Now run the app and click the button to see the command in action.
- Also change the return of the CanClick method to false as follows.
```cs
private bool CanButtonClick()
{
    return false;
}
```