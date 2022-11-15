# Shows how to impliment go fwd navigation.

- What we are going to impliment.
- In the last example, A view with a list of Persons. And a person details page. Once the user clicks on a person, he is taken to that person details page. And from there, the user can click Go Back button to come back to the user list page.
- Imn this example, we will impliment Go Fwd button.
 
- In the PersonListViewModel, add a field for IRegionNavigationJournal. Then impliment INavigationAware.

- In OnNavigatedTo set the journel.

```cs
private IRegionNavigationJournal _regionNavigationJournal = default!;
```

- We get the instance of IRegionNavigationJournal as follows.

```cs
public void OnNavigatedTo(NavigationContext navigationContext)
{
    _regionNavigationJournal = navigationContext.NavigationService.Journal;
    GoForwardCommand.RaiseCanExecuteChanged();
}
```

- Impliment CanGoForward and Go Fwd.
```cs
private void GoForward()
{
    _regionNavigationJournal.GoForward();
}
private bool CanGoForward()
{
    return _regionNavigationJournal != null && _regionNavigationJournal.CanGoForward;
}
```

- Now run the app