
# Introduces Event Aggrigator. 
- Builds from a prior example 200560-EventAggrigator.
- Demos unsubcription of events.
- Add the following to the MessageList View in ModuleB. Add a row to the Grid and then add a check box.
```xml
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="auto" />
        <RowDefinition Height="*"/>
    </Grid.RowDefinitions>
    <CheckBox IsChecked="{Binding IsSubscribed}" Content="Subscribed"/>
    <ListBox Grid.Row="1" ItemsSource="{Binding Messages}" />
</Grid>
```

And in the corresponding ViewModel, add a property as follows.

```cs
private bool _isSubscribed = true;
public bool IsSubscribed
{
    get { return _isSubscribed; }
    set 
    { 
        SetProperty(ref _isSubscribed, value);
        HandleSubscribe(_isSubscribed);
    }
}
```

- The event object needs to be stored, so add a field to the View Model.

```cs
        private MessageSentEvent _event;
```

- Then replace the ctor with this.

```cs

public MessageListViewModel(IEventAggregator eventAggregator)
{
    _event = eventAggregator.GetEvent<MessageSentEvent>();
    HandleSubscribe(true);
}
void HandleSubscribe(bool isSubscribed)
{
    if (isSubscribed)
        _event.Subscribe(OnMessageReceived);
    else
        _event.Unsubscribe(OnMessageReceived);
}

```

Now run the app. In the message list view, click the checkbox and try
