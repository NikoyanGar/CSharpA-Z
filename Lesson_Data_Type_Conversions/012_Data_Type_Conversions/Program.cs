using System.Globalization;

namespace _012_Data_Type_Conversions
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            var riArmenian = new RegionInfo("hy-AM");
            var riRussian = new RegionInfo("ru-RU");

            // Get info about Armenian and Russian regions
            RegionInfo regionInfoArmenian = riArmenian;
            RegionInfo regionInfoRussian = riRussian;

            Console.WriteLine("Armenian EnglishName:\t{0}.", regionInfoArmenian.EnglishName);
            Console.WriteLine("Armenian NativeName:\t{0}.", regionInfoArmenian.NativeName);
            Console.WriteLine("Russian EnglishName:\t{0}.", regionInfoRussian.EnglishName);
            Console.WriteLine("Russian NativeName:\t{0}.", regionInfoRussian.NativeName);

            Console.WriteLine(new string('-', 35));

            // Get information about the date format in Armenian and Russian: names of days.
            string[] daysArmenian = CultureInfo.GetCultureInfo("hy-AM").DateTimeFormat.DayNames;
            string[] daysRussian = CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.DayNames;

            Console.WriteLine("Days of the week in Armenian:");
            foreach (string day in daysArmenian)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine(new string('-', 35));

            Console.WriteLine("Days of the week in Russian:");
            foreach (string day in daysRussian)
            {
                Console.WriteLine(day);
            }

            //for (int i = 0; i < daysArmenian.Length; i++)
            //{
            //    Console.WriteLine("{0} - {1}", daysArmenian[i], daysRussian[i]);
            //}
            // Delay.
            Console.ReadKey();
        }
    }

}
