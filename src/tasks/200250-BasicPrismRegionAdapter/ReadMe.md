# Basic Prism App

- This example builds on the previous example 200225-BasicPrismRegion.
- This creats an region adapter for Stack Panel control. 
- We need to create this adapter because for other controls prism provides adapters such as ContentControlRegionAdapter, ItemsControlRegionAdapter and SelectorRegionAdapter. So SelectorRegionAdapter is for ComboBox, ListBox, Ribbon, TabControl 

- This example builds a custom adapter for a StackPanel control. 

- First chaange the contentControl Region to stack panel region

```
<ContentControl prism:RegionManager.RegionName="ContentRegion" />
```

to

```
<StackPanel prism:RegionManager.RegionName="StackPanelRegion" />
```

- Prism does not provide an adapter for STackPanel, so we need to create a custom adapter.
- Without that custom adapter which can handle a stack panel region, an exception will be thrown, the simply would not run.
- So create a class StackPanelRegionAdapter and override Adapt and CreateRegion methods.
- The Adapt method is where we add the view to the region, via the adapter. So the adpater is the intermediary. 
- In the App.xaml.cs override ConfigureRegionAdapterMappings method.

```cs
protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
{
    base.ConfigureRegionAdapterMappings(regionAdapterMappings);
    regionAdapterMappings.RegisterMapping(typeof(StackPanel), Container.Resolve<StackPanelRegionAdapter>());
}
```
- Basically with the above code, we are letting know of the prism about the stackpanel adapter that we created. In other words we are regitering the new adapter with the prism infrastructure. 
- Without these two additions, if you now run, there would be an excption. Comment out the above method ConfigureRegionAdapterMappings and run to see the exception. 
- 