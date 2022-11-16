using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;

namespace SimplePrismShell.Dialogs
{
    public class MessageDialogViewModel : BindableBase, IDialogAware
    {
        public string Title => "My Message Dialog";

        private string _message = default!;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public DelegateCommand CloseDialogCommand { get; }

        public event Action<IDialogResult> RequestClose = default!;

        public MessageDialogViewModel()
        {
            CloseDialogCommand = new DelegateCommand(CloseDialog);
        }

        private void CloseDialog()
        {
            var buttonResult = ButtonResult.OK;

            var parameters = new DialogParameters();
            parameters.Add("myParam", "The Dialog was closed by the user.");

            RequestClose?.Invoke(new DialogResult(buttonResult, parameters));
        }

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
            
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            Message = parameters.GetValue<string>("message");
        }
    }
}
