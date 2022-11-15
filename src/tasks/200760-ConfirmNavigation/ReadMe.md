# Shows how to confirm before navigation.

- Impliment IConfirmNavigationRequest

```cs
public void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback)
{
    bool result = true;
    //demo code only. do not use MessageBox in a VM in production code
    if (MessageBox.Show("Do you want to navigate?", "Navigate?", MessageBoxButton.YesNo) == MessageBoxResult.No)
        result = false;
    continuationCallback(result);
}
```


- Now run the app