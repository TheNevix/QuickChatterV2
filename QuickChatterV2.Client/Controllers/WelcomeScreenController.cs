using QuickChatterV2.Client.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickChatterV2.Client.Controllers
{
    public class WelcomeScreenController
    {
        private readonly WelcomeView _welcomeView = new WelcomeView();

        public void Run()
        {
            bool validChoice = false;

            while (!validChoice)
            {
                _welcomeView.Show();

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1": //Inloggen
                        Console.WriteLine("Je hebt gekozen voor in te loggen.");
                        Thread.Sleep(1000);
                        var loginController = new LoginScreenController();
                        loginController.Run();
                        validChoice = true;
                        break;

                    case "2": //Registreren
                        Console.WriteLine("Je hebt gekozen voor te registreren.");
                        Console.ReadLine(); // Pauze voordat je terugkeert
                        // Hier zou je bv. een SettingsController kunnen starten
                        validChoice = true;
                        break;

                    case "3": //Afsluiten
                        Console.WriteLine("Je hebt gekozen om af te sluiten.");
                        validChoice = true;
                        Environment.Exit(0); // App afsluiten
                        break;

                    default:
                        Console.WriteLine("Ongeldige keuze, probeer opnieuw.");
                        Thread.Sleep(1000);
                        break;
                }
            }
        }
    }
}
