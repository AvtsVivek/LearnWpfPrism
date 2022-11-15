
# Introduces Event Aggrigator. 
- Builds from a prior example 200560-EventAggrigator.
- Demos unsubcription of events.
- In the MessageListViewModel of ModuleB, subscription happens as follows.
```cs

public MessageListViewModel(IEventAggregator eventAggregator)
{
    eventAggregator.GetEvent<MessageSentEvent>().Subscribe(OnMessageReceived);
}

```

- If you want to add filters, you can do the following. 
```cs
eventAggregator.GetEvent<MessageSentEvent>().Subscribe(OnMessageReceived, ThreadOption.PublisherThread, false, message => message.Contains("Vivek"));
```

