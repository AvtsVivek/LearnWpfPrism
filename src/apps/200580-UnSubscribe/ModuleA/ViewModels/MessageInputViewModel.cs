using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using SimplePrismShell.Core.Events;

namespace ModuleA.ViewModels
{
    public class MessageInputViewModel : BindableBase
    {
        private string _message = "Message to Send";
        private readonly IEventAggregator _eventAggregator;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public DelegateCommand SendMessageCommand { get; private set; }

        public MessageInputViewModel(IEventAggregator eventAggregator)
        {
            SendMessageCommand = new DelegateCommand(SendMessage);
            _eventAggregator = eventAggregator;
        }

        private void SendMessage()
        {
            _eventAggregator.GetEvent<MessageSentEvent>().Publish(Message);
        }
    }
}
