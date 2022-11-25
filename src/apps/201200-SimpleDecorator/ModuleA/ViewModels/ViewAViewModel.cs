using Prism.Mvvm;
using SimpleContract;
using SimpleServices;
using System;

namespace ModuleA.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string _text = "ViewA";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        public ViewAViewModel(IWelcomeService welcomService)
        {
            //handler.Handle();

            var message = welcomService.GetWelcomeMessage("Vivek");
            _text = $"{message} {Environment.NewLine} Here is {_text}";
        }
    }
}
