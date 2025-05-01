using QuickChatterV2.Client.Helpers;

namespace QuickChatterV2.Client.Views
{
    public class LoginView
    {
        public void Show()
        {
            Console.Clear();

            string[] boxLines = {
                "+-------------------------------------------+",
                "|      Q U I C K C H A T T E R  V 2         |",
                "+-------------------------------------------+"
            };

            foreach (var line in boxLines)
            {
                TextHelper.CenterText(line);
            }
        }

        public void AskUsername()
        {
            Console.WriteLine("Gebruikersnaam: ");
        }

        public void AskPassword()
        {
            Console.WriteLine("Wachtwoord: ");
        }
    }
}
