# Shows how to impliment to show some dialogs.

- The ViewAViewModel has the responsibility to show the dialog. So it needs a dialog service.

```cs
private readonly IDialogService _dialogService = default!;
public ViewAViewModel(IDialogService dialogService)
{
    _dialogService = dialogService;
    ShowDialogCommand = new DelegateCommand(ShowDialog);
}
```

- Now impliment the show dialog method

```cs
private void ShowDialog()
{
    var dialogParam = new DialogParameters();
    // In the following the "message" parameter key comes from OnDialogOpened method of the viewmodel of dialog user control
    dialogParam.Add("message", "Hello from ViewAViewModel");
    _dialogService.ShowDialog("MessageDialog", dialogParam, r =>
    {
        if (r.Result == ButtonResult.OK)
        {
            // Also in the following "myParam" comes from CloseDialog in the view model of dialog user control
            MessageReceived = r.Parameters.GetValue<string>("myParam");
        }
        else
        {
            MessageReceived = "Not closed by user";
        }
    });
}
```

- So far we have added a user control which will act as a dialog, and a corresponding view model, and then registered it in App.xaml.cs file.
- And now to show the dialog

- Now run the app
- 