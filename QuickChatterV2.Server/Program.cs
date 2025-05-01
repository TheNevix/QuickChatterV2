using QuickChatterV2.Server.Server;

namespace QuickChatterV2.Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var server = new TcpServer("127.0.0.1", 5000);
            server.Start();
        }
    }
}
