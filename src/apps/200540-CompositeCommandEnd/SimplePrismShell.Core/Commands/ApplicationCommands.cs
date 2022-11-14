using Prism.Commands;

namespace SimplePrismShell.Core.Commands
{
    public class ApplicationCommands : IApplicationCommands
    {
        public CompositeCommand SaveAllCommand { get; } = new CompositeCommand();
    }
}
