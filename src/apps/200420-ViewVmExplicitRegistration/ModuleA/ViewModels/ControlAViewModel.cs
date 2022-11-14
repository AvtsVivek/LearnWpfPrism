using Prism.Mvvm;

namespace ModuleA.ViewModels
{
    public class ControlAViewModel : BindableBase
    {
        private string _welcomeMessage = "Hello from ViewAViewModel";
        public string WelcomeMessage
        {
            get { return _welcomeMessage; }
            set { SetProperty(ref _welcomeMessage, value); }
        }
    }
}
