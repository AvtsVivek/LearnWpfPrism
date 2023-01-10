# Basic Prism App with Modules

- Introduces Prism's ViewModel Locator
- This buids from [200320-ViewIntro](https://github.com/AvtsVivek/LearnWpfPrism/tree/main/src/tasks/200320-ViewIntro) example.
- An instance of View Model has to be assigned to the view's data context. This is what ViewModel Locator helps achieve.
- First add a new View Model class in the ViewModels folder of the ModuleA project.
```cs
using Prism.Mvvm;

namespace ModuleA.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string _welcomeMessage = "Hello from ViewAViewModel";
        public string WelcomeMessage
        {
            get { return _welcomeMessage; }
            set { SetProperty(ref _welcomeMessage, value); }
        }
    }
}

```
- Note that it is derived from BindableBase. This provides INotifyPropertyChanged notifications. 
- Also the note the naming conventions. The name space ModuleA.ViewModels. The namespace of the view as well which is ModuelA.Views. All these are according to convention.
- Change the textblock in the view to the following. This takes care of the databata binding. 

```xml
<TextBlock Text="{Binding WecomeMessage}" HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="50"/>
```

- Add the followng to the same view xaml

```xml
xmlns:prism="http://prismlibrary.com/"
prism:ViewModelLocator.AutoWireViewModel="True"
```

- Now ruin the app. You should see **Hello from ViewAViewModel** 
- Try making AutoWireViewModel property above to false and then run again. This time it will be blank.
- So the view model locator is true means, prism created an intance of ViewModel, then assigned to the datacontext of view.

