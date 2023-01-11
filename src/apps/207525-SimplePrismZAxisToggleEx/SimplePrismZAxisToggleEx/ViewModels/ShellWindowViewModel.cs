using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Windows.Input;

namespace SimplePrismZAxisToggleEx.ViewModels
{
    public class ShellWindowViewModel : BindableBase
    {
        private string _title = "Simple Prism ZAxis Toggle Ex";
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