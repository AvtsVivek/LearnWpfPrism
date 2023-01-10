using Prism.Mvvm;
using System.Windows.Input;

namespace SimplePrismZAxisEx.ViewModels
{
    public class ShellWindowViewModel : BindableBase
    {
        private string _title = "Simple Prism ZAxis Ex";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public ShellWindowViewModel()
        {

        }
    }
}