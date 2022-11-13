# Basic Prism App with Modules

- Introduces Prism Views using View Injection

- Change the OnInitialized method in the module to the following.

```cs
public void OnInitialized(IContainerProvider containerProvider)
{
    // The OnInitialized method will guarantee that the shell has been loaded and that the region has been created at this point
    IRegion region = _regionManager.Regions["ContentRegion"];
    var view1 = containerProvider.Resolve<ViewA>();
    var view2 = containerProvider.Resolve<ViewA>();
    view2.Content = new TextBlock()
    {
        Text = "Hello from View 2",
        HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
        VerticalAlignment = System.Windows.VerticalAlignment.Center
    };

    region.Add(view1);

    region.Add(view2);
    
    region.Activate(view2);
    
    region.Activate(view1);
    
    region.Deactivate(view1);
    
    region.Activate(view2);
    
    region.Remove(view2);
    
    region.Activate(view1);
}
```

- For running the exercise, do the following, 
  - Commentout the following. Then run the app.
    ```cs
      // region.Add(view1);
      // region.Add(view2);    
      // region.Activate(view2);    
      // region.Activate(view1);    
      // region.Deactivate(view1);
      // region.Activate(view2);
      // region.Remove(view2);
      // region.Activate(view1);
    ```
  - Now un comment one line and then run the app. 
  - Then uncomment the next line as well, and then run the app again.
  - Step 1
    ```cs
     region.Add(view1);
      // region.Add(view2);    
      // region.Activate(view2);    
      // region.Activate(view1);    
      // region.Deactivate(view1);
      // region.Activate(view2);
      // region.Remove(view2);
      // region.Activate(view1);
    ```
    Here only one region is added. So thats what will be shown. You will see **hello from View A**
  - Step 2
    ```cs
     region.Add(view1);
     region.Add(view2);    
      // region.Activate(view2);    
      // region.Activate(view1);    
      // region.Deactivate(view1);
      // region.Activate(view2);
      // region.Remove(view2);
      // region.Activate(view1);
    ```
    Here another view is added to the region. But still You will see **hello from View A**. The reason is because, the first one is still the active one. The second one is not yet activated.
  - Step 3.  
  ```cs
     region.Add(view1);
     region.Add(view2);    
     region.Activate(view2);    
      // region.Activate(view1);    
      // region.Deactivate(view1);
      // region.Activate(view2);
      // region.Remove(view2);
      // region.Activate(view1);
    ```
    Now it will be **Hello from View 2**

  - Step 4.
  ```cs
     region.Add(view1);
     region.Add(view2);    
     region.Activate(view2);    
     region.Activate(view1);    
      //region.Deactivate(view1);
      // region.Activate(view2);
      // region.Remove(view2);
      // region.Activate(view1);
    ```
    Now it will be back to View 1. **hello from View A**

  - Step 5.
  ```cs
     region.Add(view1);
     region.Add(view2);    
     region.Activate(view2);    
     region.Activate(view1);    
     region.Deactivate(view1);
      // region.Activate(view2);
      // region.Remove(view2);
      // region.Activate(view1);
    ```
    Now it will blank. Now view will be shown. The reason being, no view is activated. The one that is active is now Deactivated. This does not mean, the other view is activated automatically.  

  - Step 6.
  ```cs
     region.Add(view1);
     region.Add(view2);    
     region.Activate(view2);    
     region.Activate(view1);    
     region.Deactivate(view1);
     region.Activate(view2);
      // region.Remove(view2);
      // region.Activate(view1);
    ```
    Now it will be **Hello from View 2**

  - Step 7.
  ```cs
     region.Add(view1);
     region.Add(view2);    
     region.Activate(view2);    
     region.Activate(view1);    
     region.Deactivate(view1);
     region.Activate(view2);
     region.Remove(view2);
      // region.Activate(view1);
    ```
    Now it will be blank.

  - Step 8.
  ```cs
     region.Add(view1);
     region.Add(view2);    
     region.Activate(view2);    
     region.Activate(view1);    
     region.Deactivate(view1);
     region.Activate(view2);
     region.Remove(view2);
     region.Activate(view1);
    ```
    Finally it will be view 1 again. **hello from View A**
