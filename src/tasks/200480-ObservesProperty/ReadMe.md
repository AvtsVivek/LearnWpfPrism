# Basic Prism App with Modules
- This builds on earlier example 200440-WpfCommandIntro
- The earlier example Introduces the delegate command, a simple implimentation of ICommand.
- So recap, in the example the module registration happens in code.
- Then View Model is connected to the view using auto wiring.
- Now add a check box to the UI stack pannel as follows, which binds to CanExecute property as follows.

```xml
<StackPanel>
    <CheckBox Content="Can Execute" IsChecked="{Binding CanExecute}" />
    <Button Content="Click Me" Command="{Binding ClickCommand}"/>
    <TextBlock Text="{Binding WelcomeMessage}" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="50" />
</StackPanel>
```

- Also in the View Model add a Property CanExecute for the checkbox

```cs
private bool _canExecute;
public bool CanExecute
{
    get { return _canExecute; }
    set { 
        SetProperty(ref _canExecute, value);
    }
}
```

- Note the **ClickCommand.RaiseCanExecuteChanged();** is removed from the earlier example.

- We want the button to be clickable only when the checkbox is checked.

```cs
private bool CanButtonClick()
{
    return CanExecute;
}
```

- Call observesPropery method to the DelegateCommand object as follows.

```cs
ClickCommand = new DelegateCommand(ButtonClick, CanButtonClick).ObservesProperty(() => CanExecute);
```

- Now run the app and note how the button is disabled from the biginning. Check the checkbox, to see if this changes. 
- 
