using Prism.Mvvm;
using SimplePrismShell.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrismShell.ViewModels
{
    public class ShellWindowViewModel : BindableBase
    {
        private IApplicationCommands? _applicationCommands;
        public IApplicationCommands ApplicationCommands
        {
            get { return _applicationCommands!; }
            set { SetProperty(ref _applicationCommands, value); }
        }

        public ShellWindowViewModel(IApplicationCommands applicationCommands)
        {
            ApplicationCommands = applicationCommands;
        }
    }
}
