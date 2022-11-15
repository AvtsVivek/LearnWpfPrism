using Prism.Events;
using Prism.Mvvm;
using SimplePrismShell.Core.Events;
using System.Collections.ObjectModel;

namespace ModuleB.ViewModels
{
    public class MessageListViewModel : BindableBase
    {
        private ObservableCollection<string> _messages = new ObservableCollection<string>();
        private MessageSentEvent _event;
        public ObservableCollection<string> Messages
        {
            get { return _messages; }
            set { SetProperty(ref _messages, value); }
        }

        private bool _isSubscribed = true;
        public bool IsSubscribed
        {
            get { return _isSubscribed; }
            set
            {
                SetProperty(ref _isSubscribed, value);

                HandleSubscribe(_isSubscribed);
            }
        }

        public MessageListViewModel(IEventAggregator eventAggregator)
        {
            _event = eventAggregator.GetEvent<MessageSentEvent>();

            HandleSubscribe(true);
        }

        void HandleSubscribe(bool isSubscribed)
        {
            if (isSubscribed)
                _event.Subscribe(OnMessageReceived);
            else
                _event.Unsubscribe(OnMessageReceived);
        }

        private void OnMessageReceived(string message)
        {
            Messages.Add(message);
        }
    }
}
