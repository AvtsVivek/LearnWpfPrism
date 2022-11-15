# Shows how to impliment go back navigation.

- What we are going to impliment.
- A view with a list of Persons. And a person details page. Once the user clicks on a person, he is taken to that person details page. And from there, the user can click Go Back button to come back to the user list page.
 
- In the PersonDetailViewModel, add a field for IRegionNavigationJournal

```cs
private IRegionNavigationJournal _regionNavigationJournal = default!;
```

- We get the instance of IRegionNavigationJournal as follows.

```cs
public void OnNavigatedTo(NavigationContext navigationContext)
{
    _regionNavigationJournal = navigationContext.NavigationService.Journal;
    if (navigationContext.Parameters.ContainsKey("person"))
        SelectedPerson = navigationContext.Parameters.GetValue<Person>("person");
}
```

- And finally the go back method as follows.
```cs
private void GoBack()
{
    _regionNavigationJournal.GoBack();
}
```

- Now run the app