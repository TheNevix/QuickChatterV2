using QuickChatterV2.Models;

namespace QuickChatterV2.Server.Handlers
{
    public interface ICommandHandler
    {
        string Handle(ConnectedClient client, string[] commandParts);
    }
}
