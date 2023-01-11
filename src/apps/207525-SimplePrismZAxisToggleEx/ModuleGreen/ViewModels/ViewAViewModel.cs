using Prism.Mvvm;

namespace ModuleGreen.ViewModels
{
    public class ViewGreenViewModel : BindableBase
    {
        private string _welcomeMessage = "GreenView";
        public string WelcomeMessage
        {
            get { return _welcomeMessage; }
            set { SetProperty(ref _welcomeMessage, value); }
        }
    }
}
