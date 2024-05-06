namespace _008_Data_Type_Conversions
{
    internal class Program
    {
        //https://learn.microsoft.com/en-us/dotnet/standard/base-types/formatting-types
        static void Main(string[] args)
        {
            int number = 255;
            string numberString = number.ToString();
            Console.WriteLine(numberString); // Output: "42"

            string hex = number.ToString("X");
            Console.WriteLine("Hexadecimal: " + hex);

            double pi = 3.14159;
            string piString = pi.ToString();
            string piString1 = pi.ToString("F2"); // Format the double value with 2 decimal places
            string piString2 = pi.ToString("F4");
            string piString3 = pi.ToString("F6");
            Console.WriteLine("without formating" + piString);
            Console.WriteLine("Two decimal places: " + piString1);
            Console.WriteLine("Four decimal places: " + piString2);
            Console.WriteLine("Six decimal places: " + piString3);


            DateTime now = DateTime.Now;
            string dateString = now.ToString();
            Console.WriteLine(dateString); // Output: "6/30/2022 10:15:30 AM" (example output)

            string dateString1 = now.ToString("MM/dd/yyyy hh:mm:ss tt"); // Format the DateTime value as "MM/dd/yyyy hh:mm:ss tt"
            Console.WriteLine(dateString1);
        }
    }
}
