using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace ModuleA.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string _welcomeMessage = "Hello from ViewAViewModel";

        private readonly IDialogService _dialogService = default!;
        public string WelcomeMessage
        {
            get { return _welcomeMessage; }
            set { SetProperty(ref _welcomeMessage, value); }
        }

        private string _messageReceived = default!;
        public string MessageReceived
        {
            get { return _messageReceived; }
            set { SetProperty(ref _messageReceived, value); }
        }

        public DelegateCommand ShowDialogCommand { get; }

        public ViewAViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;

            ShowDialogCommand = new DelegateCommand(ShowDialog);
        }

        private void ShowDialog()
        {
            _dialogService.ShowMessageDialog("Hello from ViewAViewModel", iDialogResult =>
            {
                if (iDialogResult.Result == ButtonResult.OK)
                {
                    MessageReceived = iDialogResult.Parameters.GetValue<string>("myParam");
                }
                else
                {
                    MessageReceived = "Not closed by user";
                }
            });
        }
    }
}
