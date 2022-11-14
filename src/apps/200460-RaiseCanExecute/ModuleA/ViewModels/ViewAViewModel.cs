using Prism.Commands;
using Prism.Mvvm;
using System.Diagnostics;
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

        private bool _canExecute;
        public bool CanExecute
        {
            get { return _canExecute; }
            set { 
                SetProperty(ref _canExecute, value); 
                // Run and rerun the app after commenting and uncommenting the following line.
                Debugger.Break();
                ClickCommand.RaiseCanExecuteChanged();
            }
        }

        public DelegateCommand ClickCommand { get; set; }

        public ViewAViewModel()
        {
            ClickCommand = new DelegateCommand(ButtonClick, CanButtonClick);
        }

        private bool CanButtonClick()
        {
            Debugger.Break();
            return CanExecute;
        }

        private void ButtonClick()
        {
            WelcomeMessage = "You Clicked me!";
        }

    }
}
