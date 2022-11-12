# Basic Prism App
- Introduces Regions in Prism App
- Placeholder for dynamic content. 
- A wpf app has multiple regions into which wpf controls are injected at run time.
- Region Manager. 
  - It manages regions. 
  - It hold all of the regions in the application.
  - Provides access to the region
  - Used for view composition
  - Used for Region Navigation.
  - Define and create Regions in the prism app.

- This example builds on the previous example 200200-BasicPrism

- The following code creates a region in the shell.
```xml
<ContentControl prism:RegionManager.RegionName="ContentRegion" />
```

And add the required namespace.

```xml
xmlns:prism="http://prismlibrary.com/"
```

- So by this, the ContentControl becomes a prism region.
- Note that a View is not Yet injected into the region. 