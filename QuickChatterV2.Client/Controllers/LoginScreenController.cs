using QuickChatterV2.Client.Services;
using QuickChatterV2.Client.Services.Network;
using QuickChatterV2.Client.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickChatterV2.Client.Controllers
{
    public class LoginScreenController
    {
        private readonly LoginView _loginView = new LoginView();
        public void Run()
        {
            _loginView.Show();
            //Ask username
            _loginView.AskUsername();
            string username = Console.ReadLine();

            _loginView.AskPassword();
            string password = Console.ReadLine();

            //Login on server
            var connection = new TcpConnectionService("127.0.0.1", 5000);
            var loginService = new LoginService(connection);

            loginService.Login(username, password);

        }
    }
}
