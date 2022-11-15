# Passing params to INavigationAware 
- The previous example shows how to pass params to views when navigating.
- when I select a person from our list in the top, we're going to populate a tab at the bottom with the details of that person. However, you click a person in the list, the same tab instance is reused and just updating the data.
- What we want to happen is when we click on a new person, we want a new tab to be created. However, if we click on a person which already has a tab, we want to activate that tab, instead of creating a new one. 
- 
```cs 
public bool IsNavigationTarget(NavigationContext navigationContext)
{
    var person = navigationContext.Parameters.GetValue<Person>("person");
    if (SelectedPerson.LastName == person.LastName)
        return true;
    else
        return false;
}
```

- Now run the app