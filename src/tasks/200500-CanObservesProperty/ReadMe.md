# Basic Prism App with Modules
- This builds on earlier example 200440-WpfCommandIntro
- This introduces the ObservesCanExecute method.
- This basically removes the need for the second parameter of the DelegateCommand, where we provide a delegate which when invoked will return if the execute method can be invoked, and the button can be enabled or disabled. 

- Also in the View Model add a Property CanExecute for the checkbox

```cs

```

- Note the **ClickCommand.RaiseCanExecuteChanged();** is removed from the earlier example.

- We want the button to be clickable only when the checkbox is checked.

- Call ObservesCanExecute method to the DelegateCommand object as follows.

```cs
// ClickCommand = new DelegateCommand(ButtonClick, CanButtonClick).ObservesProperty(() => CanExecute);
 ClickCommand = new DelegateCommand(ButtonClick).ObservesCanExecute(() => CanExecute);
```

- Note CanButtonClick param is removed. 

- Remove the following method.
```cs
private bool CanButtonClick()
{
    return CanExecute;
}
```

- Now run the app and note how the button is disabled from the biginning. Check the checkbox, to see if this changes. 
- 
