using System.Globalization;

namespace _010_Data_Type_Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Default: Encoding.Default → typically code page 437(OEM US) or Windows-1252.
            //It does not support all Unicode characters, like €, ✓, etc.
            // On Linux/macOS Terminals
            //Default: Usually UTF-8(System.Text.UTF8Encoding)

            //Unicode output just works in most modern terminals.

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DateTime now = DateTime.Now;
            string usDate = now.ToString(new CultureInfo("en-US"));
            string ukDate = now.ToString(new CultureInfo("en-GB"));
            string frDate = now.ToString(new CultureInfo("fr-FR"));

            Console.WriteLine("US format: " + usDate);
            Console.WriteLine("UK format: " + ukDate);
            Console.WriteLine("FR format: " + frDate);

            DateTime dt = new DateTime(2025, 5, 1);
            double price = 1234.56;

            Console.WriteLine(dt.ToString("d", new CultureInfo("en-US"))); // 5/1/2025
            Console.WriteLine(dt.ToString("d", new CultureInfo("fr-FR"))); // 01/05/2025

            Console.WriteLine(price.ToString("C", new CultureInfo("en-US"))); // $1,234.56
            Console.WriteLine(price.ToString("C", new CultureInfo("de-DE"))); // 1.234,56 €
        }
    }
}
