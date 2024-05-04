namespace Parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Parsing a string to an integer
            string numberString = "123";
            int number = int.Parse(numberString);
            Console.WriteLine("Parsed number: " + number);

            // Example 2: Parsing a string to a double
            string doubleString = "3.14";
            double doubleNumber = double.Parse(doubleString);
            Console.WriteLine("Parsed double: " + doubleNumber);

            // Example 3: Parsing a string to a boolean
            string boolString = "true";
            bool boolValue = bool.Parse(boolString);
            Console.WriteLine("Parsed boolean: " + boolValue);

            // Example 4: Parsing a string to a DateTime
            string dateString = "2022-01-01";
            DateTime date = DateTime.Parse(dateString);
            Console.WriteLine("Parsed date: " + date);
        }
    }
}
