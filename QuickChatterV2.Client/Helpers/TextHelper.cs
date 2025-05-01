namespace QuickChatterV2.Client.Helpers
{
    public static class TextHelper
    {
        public static void CenterText(string text)
        {
            int screenWidth = Console.WindowWidth;
            int stringWidth = text.Length;
            int spaces = (screenWidth / 2) + (stringWidth / 2);
            Console.WriteLine(text.PadLeft(spaces));
        }
    }
}
