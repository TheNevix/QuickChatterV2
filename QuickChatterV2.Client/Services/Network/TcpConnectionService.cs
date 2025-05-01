using System.Net.Sockets;
using System.Text;

namespace QuickChatterV2.Client.Services.Network
{
    public class TcpConnectionService
    {
        private readonly string _ip;
        private readonly int _port;

        public TcpConnectionService(string serverIp, int serverPort)
        {
            _ip = serverIp;
            _port = serverPort;
        }

        public string SendAndReceive(string message)
        {
            try
            {
                using (TcpClient client = new TcpClient(_ip, _port))
                using (NetworkStream stream = client.GetStream())
                {
                    //Send data
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    stream.Write(data, 0, data.Length);

                    //Recieve response
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    return response;
                }
            }
            catch (Exception ex)
            {
                return $"[FOUT] Kon geen verbinding maken: {ex.Message}";
            }
        }
    }
}
