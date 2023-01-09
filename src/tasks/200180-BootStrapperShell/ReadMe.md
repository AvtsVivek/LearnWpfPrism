# Basic Prism App with a bootstrapper.
- A bootstrapper is a class that is responsible for initializing the application. 
  - What to initialize are the core services. 
  - Core services are the non-application specific services that the Prism library provides for you. 
  - These services include the 
    - **Module manager** which is responsible for retrieving and initializing the application's modules. 
    - **Module catalog** which is used to register the modules that the application is going to load. 
    - **Module initializer** which initializes the modules. 
    - **Region manager** which are the visual containers for UI. 
    - **Event aggregator** which allows you to create events that are loosely coupled between the publisher and the subscriber. 
    - **Logger facade** which is simply a wrapper for a logging mechanism. 
    - **Service locator** which is useful to give the application access to the container. 
  - The bootstrapper's also where you're going to initialize application-specific services. These are services that are specific to your particular application that is common amongst all application modules. For example, if you were building an RSS type application you may have a RSS feed service that will be registered in the bootstrapper that all modules will use to read in their feeds.

- Now run, the app 