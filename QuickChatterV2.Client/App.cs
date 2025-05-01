using QuickChatterV2.Client.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickChatterV2.Client
{
    public class App
    {
        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Title = "QuickChatterV2";
            var welcomeController = new WelcomeScreenController();
            welcomeController.Run();
        }
    }
}
