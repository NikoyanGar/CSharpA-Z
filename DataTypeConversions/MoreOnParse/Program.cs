using System.Globalization;

namespace MoreOnParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberString = "123";
            int number = int.Parse(numberString, NumberStyles.AllowThousands);
            Console.WriteLine(number);


            string floatString = "3.14";
            float floatValue = float.Parse(floatString, NumberStyles.Float, CultureInfo.InvariantCulture);
            Console.WriteLine(floatValue);

            string dateString = "2022-01-01";
            DateTime dateValue = DateTime.Parse(dateString, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal);
            Console.WriteLine(dateValue);

            string dateTimeUtcow = DateTime.UtcNow.ToString();
            Console.WriteLine(dateTimeUtcow);

            string dateTimeNow = DateTime.Now.ToString();
            Console.WriteLine(dateTimeNow);
        }
    }
}
