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

- You can also set the styling of the dialog as follows. 
- Open the MessageDialog.xaml in the dialog folder. Then you can add the following styles to the dialog.

```xml

<prism:Dialog.WindowStyle>
    <Style TargetType="Window">
        <Setter Property="Height" Value="200" />
        <Setter Property="Width" Value="400"/>
        <Setter Property="ResizeMode" Value="NoResize" />
        <Setter Property="prism:Dialog.WindowStartupLocation" Value="CenterScreen" />
    </Style>
</prism:Dialog.WindowStyle>

```

