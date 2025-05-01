using QuickChatterV2.Client.Helpers;

namespace QuickChatterV2.Client.Views
{
    public class WelcomeView
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

            Console.WriteLine(); // lege regel

            // 2️⃣ Tekst onder de box
            string introText = "Welkom bij QuickChatter! Deze applicatie zorgt ervoor dat je op een leuke en interactieve manier met vrienden kunt chatten.";
            TextHelper.CenterText(introText);

            Console.WriteLine();
            Console.WriteLine();

            // 3️⃣ Menu-opties
            Console.WriteLine("Maak een keuze door het cijfer te typen:");
            Console.WriteLine("[1]  Inloggen");
            Console.WriteLine("[2]  Registreren");
            Console.WriteLine("[3]  Afsluiten");
            Console.WriteLine();
            Console.Write("Je keuze: ");
        }
    }
}
