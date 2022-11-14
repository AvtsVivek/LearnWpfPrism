using Prism.Commands;
using Prism.Mvvm;
using static System.Net.Mime.MediaTypeNames;

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

        public DelegateCommand ClickCommand { get; set; }

        public ViewAViewModel()
        {
            ClickCommand = new DelegateCommand(ButtonClick, CanButtonClick);
        }

        private bool CanButtonClick()
        {
            return true;
        }

        private void ButtonClick()
        {
            WelcomeMessage = "You Clicked me!";
        }

    }
}
