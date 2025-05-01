using System.Net.Sockets;

namespace QuickChatterV2.Models
{
    public class ConnectedClient
    {
        public string? Username { get; set; }
        public TcpClient TcpClient { get; set; }

        public ConnectedClient(TcpClient client)
        {
            TcpClient = client;
        }
    }
}
