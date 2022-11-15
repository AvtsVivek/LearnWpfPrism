
# Introduces Event Aggrigator. 
- Builds from a prior example 200580-UnSubscribe.
- Demos unsubcription of events using token.
- Change the HandleSubscribe method to the followng.
- 
```cs
void HandleSubscribe(bool isSubscribed)
{
    if (isSubscribed)
        _token = _event.Subscribe(OnMessageReceived);
    else
        _event.Unsubscribe(_token);
}
```
- Also add _token filed as required
```cs
private SubscriptionToken _token = default!;
```

Now run the app. In the message list view, click the checkbox and try
