# Basic Prism App with Modules

- Introduces Prism Views

- **View** 
  - is a portion of your user interface that is displayed to your user.
  - In Wpf a view is a UserControl
  - single view can have other views defined within it
  - it can also contain regions that will eventually host other views.
  - **composite view** is View made up of multiple views.

- **View composition** is the process of constructing a view, 
  - creating an instance of that view, 
  - displaying it 
  - injecting it into your region.

- View Composition happens in two ways, 
  - View Discovery and 
  - View Injection

- The example is built from 200270-SimplePrismModule