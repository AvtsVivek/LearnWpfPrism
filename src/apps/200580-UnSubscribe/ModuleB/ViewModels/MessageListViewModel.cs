using Prism.Events;
using Prism.Mvvm;
using SimplePrismShell.Core.Events;
using System.Collections.ObjectModel;

namespace ModuleB.ViewModels
{
    public class MessageListViewModel : BindableBase
    {
        private ObservableCollection<string> _messages = new ObservableCollection<string>();
        public ObservableCollection<string> Messages
        {
            get { return _messages; }
            set { SetProperty(ref _messages, value); }
        }

        public MessageListViewModel(IEventAggregator eventAggregator)
        {
            eventAggregator.GetEvent<MessageSentEvent>().Subscribe(OnMessageReceived);
            // If you want to add filters to the incomming message, you can do the following.
            // eventAggregator.GetEvent<MessageSentEvent>().Subscribe(OnMessageReceived, ThreadOption.PublisherThread, false, message => message.Contains("Vivek"));
        }

        private void OnMessageReceived(string message)
        {
            Messages.Add(message);
        }
    }
}
