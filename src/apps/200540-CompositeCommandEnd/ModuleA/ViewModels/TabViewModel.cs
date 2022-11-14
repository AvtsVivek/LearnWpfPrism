using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using SimplePrismShell.Core.Commands;

namespace ModuleA.ViewModels
{

    public class TabViewModel : BindableBase
    {
        private string _title = default!;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private bool _canUpdate = true;
        public bool CanUpdate
        {
            get { return _canUpdate; }
            set { SetProperty(ref _canUpdate, value); }
        }

        private string _updatedText = default!;
        public string UpdateText
        {
            get { return _updatedText; }
            set { SetProperty(ref _updatedText, value); }
        }

        public DelegateCommand UpdateCommand { get; private set; }

        public TabViewModel(IApplicationCommands applicationCommands)
        {
            UpdateCommand = new DelegateCommand(Update).ObservesCanExecute(() => CanUpdate);

            applicationCommands.SaveAllCommand.RegisterCommand(UpdateCommand);
            // HJere we are regeisring. But for any reason, if we are removing a tab, then we must also remember to un register as well.
        }

        private void Update()
        {
            UpdateText = $"Updated: {DateTime.Now}";
        }
    }

}
