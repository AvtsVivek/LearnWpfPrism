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
            var dialogParams = new DialogParameters();
            // In the following the "message" parameter key comes from OnDialogOpened method of the viewmodel of dialog user control
            dialogParams.Add("message", "Hello from ViewAViewModel");

            _dialogService.ShowDialog("MessageDialog", dialogParams, r =>
            {
                if (r.Result == ButtonResult.OK)
                {
                    // Also in the following "myParam" comes from CloseDialog in the view model of dialog user control
                    MessageReceived = r.Parameters.GetValue<string>("myParam");
                }
                else
                {
                    MessageReceived = "Not closed by user";
                }
            });
        }
    }
    
}
