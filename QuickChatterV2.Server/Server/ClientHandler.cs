using QuickChatterV2.Models;
using QuickChatterV2.Server.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickChatterV2.Server.Server
{
    public class ClientHandler
    {
        private readonly ConnectedClient _client;
        private readonly Dictionary<string, ICommandHandler> _handlers;

        public ClientHandler(ConnectedClient client, Dictionary<string, ICommandHandler> handlers)
        {
            _client = client;
            _handlers = handlers;
        }

        public void Process()
        {
            using var stream = _client.TcpClient.GetStream();
            var buffer = new byte[1024];

            while (true)
            {
                int bytesRead;
                try
                {
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break; // Verbinding gesloten
                }
                catch
                {
                    Console.WriteLine("Client disconnected abruptly.");
                    break;
                }

                var message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine($"Ontvangen: {message}");

                var parts = message.Split('|');
                var command = parts[0];

                if (_handlers.TryGetValue(command, out var handler))
                {
                    var response = handler.Handle(_client, parts);
                    Send(response);
                }
                else
                {
                    Send("404|Unknown command");
                }
            }

            Console.WriteLine("Client disconnected.");
            _client.TcpClient.Close();
        }

        private void Send(string response)
        {
            var stream = _client.TcpClient.GetStream();
            var data = Encoding.UTF8.GetBytes(response);
            stream.Write(data, 0, data.Length);
        }
    }
}
