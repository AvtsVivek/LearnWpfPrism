using DryIoc;
using ModuleA.Views;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using SimpleContract;
using SimpleDecorator;
using SimpleServices;

namespace ModuleA
{
    public class ModuleAModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>();

            var container = PrismIocExtensions.GetContainer(containerRegistry);

            container.Register<IWelcomeService, WelcomeService>();
            container.Register<ILogger, InMemoryLogger>();
            container.Register<IWelcomeService, LoggerWelcomeService>(setup: Setup.Decorator);
        }
    }
}
