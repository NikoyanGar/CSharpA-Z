using System.Globalization;

namespace _011_Data_Type_Conversions
{
    internal class Program
    {
        //https://learn.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo.currentculture?view=net-8.0
        static void Main(string[] args)
        {
            //Getting the Current Culture: You can get the current culture of the thread in C# using the CultureInfo.CurrentCulture property

            Console.WriteLine("Current culture: " + CultureInfo.CurrentCulture.Name);

            //Setting the Current Culture: You can set the current culture of the thread using the CultureInfo.CurrentCulture property.
            CultureInfo.CurrentCulture = new CultureInfo("hy-AM");

            Console.WriteLine("Current culture: " + CultureInfo.CurrentCulture.Name);

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("{0,-15}{0,-5}{0,-45}{0,-40}", "Culture", "ISO", "Display name", "English Name");
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                Console.Write("{0,-15}", ci.Name);
                Console.Write("{0,-5}", ci.TwoLetterISOLanguageName);
                Console.Write("{0,-45}", ci.DisplayName);
                Console.WriteLine("{0,-40}", ci.EnglishName);
            }

        }
    }
}
