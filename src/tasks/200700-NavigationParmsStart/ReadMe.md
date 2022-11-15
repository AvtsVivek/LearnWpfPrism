
# Introdces INavigationAware interface
- Builds from previous example. 
- Adds page views count to the views. Currently this will show 0. This is the starting point for the next example.
- Impliment INavigationAware on ViewBViewModel

```cs
public void OnNavigatedTo(NavigationContext navigationContext)
{
    PageViews++;
}
public bool IsNavigationTarget(NavigationContext navigationContext)
{
    return true;
}
public void OnNavigatedFrom(NavigationContext navigationContext)
{
    
}
```

- Now run the app, ViewB should show the the count.

- For View A, open the code behind, not the view model, and impliment the same interface. We just want to do this in a different way than B
```cs
public bool IsNavigationTarget(NavigationContext navigationContext)
{
    return true;
}
public void OnNavigatedFrom(NavigationContext navigationContext)
{
    
}
int count = 0;
public void OnNavigatedTo(NavigationContext navigationContext)
{
    _txtPageViews.Text = $"{++count}";
}
```

- Now run the app, ViewA should also show the the count.

- 