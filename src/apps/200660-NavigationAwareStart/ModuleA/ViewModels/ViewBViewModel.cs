using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ModuleA.ViewModels
{
    public class ViewBViewModel : BindableBase
    {
        private string _text = "ViewB";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        private int _pageViews;
        public int PageViews
        {
            get { return _pageViews; }
            set { SetProperty(ref _pageViews, value); }
        }

        public ViewBViewModel()
        {

        }
    }
}
