using System.Globalization;

namespace _010_Data_Type_Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            string usDate = now.ToString(new CultureInfo("en-US"));
            string ukDate = now.ToString(new CultureInfo("en-GB"));
            string frDate = now.ToString(new CultureInfo("fr-FR"));

            Console.WriteLine("US format: " + usDate);
            Console.WriteLine("UK format: " + ukDate);
            Console.WriteLine("FR format: " + frDate);
        }
    }
}
