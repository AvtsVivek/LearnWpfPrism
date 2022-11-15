# Passing params to INavigationAware 
- Shows how to pass params to views when navigating.
- asdf
```cs 
private void PersonSelected(Person person)
{
    if (person == null)
        return;
    var p = new NavigationParameters();
    p.Add("person", person);
    _regionManger.RequestNavigate("PersonDetailsRegion", "PersonDetail", p);
}
```
- impliment INavigationAware interface on PersonDetailViewModel
```cs
public void OnNavigatedTo(NavigationContext navigationContext)
{
    if (navigationContext.Parameters.ContainsKey("person"))
        SelectedPerson = navigationContext.Parameters.GetValue<Person>("person");
}
public bool IsNavigationTarget(NavigationContext navigationContext)
{
    return true;
}
public void OnNavigatedFrom(NavigationContext navigationContext)
{
}
```

- now run the app