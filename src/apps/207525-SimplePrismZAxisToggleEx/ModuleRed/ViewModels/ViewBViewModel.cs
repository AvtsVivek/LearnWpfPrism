using Prism.Mvvm;

namespace ModuleRed.ViewModels
{
    public class ViewRedViewModel : BindableBase
    {
        private string _welcomeMessage = "Red View";
        public string WelcomeMessage
        {
            get { return _welcomeMessage; }
            set { SetProperty(ref _welcomeMessage, value); }
        }
    }
}
