using QuickChatterV2.Client.Services.Network;
using QuickChatterV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickChatterV2.Client.Services
{
    public class LoginService
    {
        private readonly TcpConnectionService _connection;

        public LoginService(TcpConnectionService connection)
        {
            _connection = connection;
        }

        public void Login(string username, string password)
        {
            string loginRequest = $"{RequestCode.Login}|{username}|{password}";

            var response = _connection.SendAndReceive(loginRequest);

            var e = 5;
        }
    }
}
