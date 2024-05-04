using System.Globalization;

namespace MoreOnNumberStyles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberString = "123";
            int number = int.Parse(numberString, NumberStyles.AllowThousands);
            Console.WriteLine(number);

            //string numberString = "1,234.56";
            //decimal number = decimal.Parse(numberString, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint);
            //Console.WriteLine(number);

            //string numberString = "1,234,567";
            //int number = int.Parse(numberString, NumberStyles.AllowThousands);
            //Console.WriteLine(number);
        }
    }
}
