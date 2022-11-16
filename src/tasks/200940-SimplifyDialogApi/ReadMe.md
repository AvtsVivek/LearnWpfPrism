# Improving the dialog Api with extension methods.

- Add a new wpf control library project and name it SimplePrismShell.Core
- Remove unnecessary files and add a new dialog folder, and in that add a file for extension methods.
- Then use that extension method  in the ViewAViewModel

```cs
private void ShowDialog()
{
    _dialogService.ShowMessageDialog("Hello from ViewAViewModel", r =>
    {
        if (r.Result == ButtonResult.OK)
        {
            MessageReceived = r.Parameters.GetValue<string>("myParam");
        }
        else
        {
            MessageReceived = "Not closed by user";
        }
    });
}
```



