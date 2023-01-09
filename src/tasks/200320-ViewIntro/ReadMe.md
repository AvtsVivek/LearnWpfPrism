# Basic Prism App with Modules

- Introduces Prism Views

- **View** 
  - is a portion of your user interface that is displayed to your user.
  - In Wpf a view is a UserControl
  - single view can have other views defined within it
  - it can also contain regions that will eventually host other views.
  - **composite view** is View made up of multiple views.

- **View Composition** is the process of constructing a view, 
  - creating an instance of that view, 
  - displaying it 
  - injecting it into your region.

- View Composition happens in two ways, 
  - **View Discovery** and 
  - **View Injection**

- The example is built from 200270-SimplePrismModule. The module registration happens using code, [see this doc](https://github.com/AvtsVivek/LearnWpfPrism/tree/main/src/tasks/200270-SimplePrismModule#basic-prism-app-with-modules). 
- To the ModuleA views folder add a Wpf UserControl and name it ViewA. And inside of the view add a TextBlock with some text it.
- To the ModuleAModule class, add a ctor so the prism framework can inject RegionManager to it.

- Ensure the main shell has a region as follows.
```xml
<ContentControl prism:RegionManager.RegionName="ContentRegion" />
```

```cs
private readonly IRegionManager _regionManager;

public ModuleAModule(IRegionManager regionManager)
{
    _regionManager = regionManager;
}
```
- Now run the app. You should see the View displayed.
- So in summary the following shows how they all fit together.
  - In App.cs, we have CreateShell method which Creates the shell windows object.
  - It also has ModuleAModule Registered.
  - Then in ShellWindow.xaml, you can see the region defined.
  - Now go to the module, you will see region manager registers the ContentRegion with te View ViewA.
  -  