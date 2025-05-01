using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using QuickChatterV2.Server.Handlers;
using QuickChatterV2.Models;

namespace QuickChatterV2.Server.Server
{
    public class TcpServer
    {
        private readonly TcpListener _listener;
        private readonly Dictionary<string, ICommandHandler> _handlers = new();

        public TcpServer(string ip, int port)
        {
            _listener = new TcpListener(IPAddress.Parse(ip), port);
            _handlers.Add("LOGIN", new LoginHandler());
            // Je kunt hier later bv. ChatHandler toevoegen: _handlers.Add("SENDMESSAGE", new ChatHandler());
        }

        public void Start()
        {
            _listener.Start();
            Console.WriteLine("Server started...");

            while (true)
            {
                var tcpClient = _listener.AcceptTcpClient();
                Console.WriteLine("Nieuwe client verbonden.");

                var client = new ConnectedClient(tcpClient);
                var handler = new ClientHandler(client, _handlers);

                // Run client in aparte thread/task
                var clientThread = new Thread(handler.Process);
                clientThread.Start();
            }
        }
    }
}
