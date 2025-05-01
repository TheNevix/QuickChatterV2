using QuickChatterV2.Models;
using QuickChatterV2.Server.Server;

namespace QuickChatterV2.Server.Handlers
{
    public interface ICommandHandler
    {
        string Handle(ConnectedClient client, string[] commandParts, TcpServer server);
    }
}
