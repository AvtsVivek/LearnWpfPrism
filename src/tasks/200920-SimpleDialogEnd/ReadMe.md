# Shows how to impliment to show some dialogs.

- Add Dialog folder to the startup project and then add a user control and view model. The View model impliments IDialogAware interface.

In App.xaml.cs file 

```cs

protected override void RegisterTypes(IContainerRegistry containerRegistry)
{
    containerRegistry.RegisterDialog<MessageDialog, MessageDialogViewModel>();
}

```

- So far we have added a user control which will act as a dialog, and a corresponding view model, and then registered it in App.xaml.cs file.
- And now to show the dialog 

- Add View Model properties corresponding to the bindings above.

```cs


```

- Impliment CanGoForward and Go Fwd.
```cs


```

- Now run the app
- 