# Shows how to impliment to show some dialogs.

- Picked this start project from 200380-ViewModelLocator.
- Removed unnecessary marker blank files.
- In ViewA, change the Grid panel to StackPanel, then add button and textblock as follows.

```xml
<StackPanel VerticalAlignment="Center" HorizontalAlignment="Center">
    <TextBlock Text="{Binding WelcomeMessage}" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="50"/>
    <Button Command="{Binding ShowDialogCommand}" Content="Show Dialog" Width="175" Height="85" />
    <TextBlock Text="{Binding MessageReceived}" Margin="10" FontSize="36"/>
</StackPanel>
```

- Add View Model properties corresponding to the bindings above.

```cs
private string _messageReceived = default!;
public string MessageReceived
{
    get { return _messageReceived; }
    set { SetProperty(ref _messageReceived, value); }
}

public DelegateCommand ShowDialogCommand { get; }

public ViewAViewModel()
{
    ShowDialogCommand = new DelegateCommand(ShowDialog);
}

private void ShowDialog()
{

}
```

- Impliment CanGoForward and Go Fwd.
```cs


```

- Now run the app