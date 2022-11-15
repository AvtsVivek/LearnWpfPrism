
# Introduces Event Aggrigator. 
- Builds from a prior example. 
- Adds another module ModuleB. This has a listbox view. 
- The view models in both the modules have event aggrigator as dependency. And this takes care of pub and sub.
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

