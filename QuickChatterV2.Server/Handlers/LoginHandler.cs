using QuickChatterV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickChatterV2.Server.Handlers
{
    public class LoginHandler : ICommandHandler
    {
        public string Handle(ConnectedClient client, string[] commandParts)
        {
            if (commandParts.Length < 3)
                return $"{(int)ResponseCode.NotOk}|Login requires username and password";

            var username = commandParts[1];
            var password = commandParts[2];

            // Dummy check: wachtwoord is altijd "1234" voor demo
            if (password == "1234")
            {
                client.Username = username;
                Console.WriteLine($"{username} logged in successfully.");
                return $"{commandParts[1]}{(int)ResponseCode.Ok}|Welcome {username}";
            }
            else
            {
                Console.WriteLine($"Failed login attempt for {username}.");
                return $"{(int)ResponseCode.NotOk}|Invalid credentials";
            }
        }
    }
}
