using Prism.Commands;

namespace SimplePrismShell.Core.Commands
{
    public interface IApplicationCommands
    {
        CompositeCommand SaveAllCommand { get; }
    }
}
