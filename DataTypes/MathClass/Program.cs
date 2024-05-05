namespace MathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Example usages of Math class
            double number = 3.14;
            double roundedNumber = Math.Round(number);
            Console.WriteLine("Rounded number: " + roundedNumber);

            int x = 5;
            int y = 3;
            int max = Math.Max(x, y);
            Console.WriteLine("Max value: " + max);

            int min = Math.Min(x, y);
            Console.WriteLine("Min value: " + min);

            double power = Math.Pow(x, y);
            Console.WriteLine("Power: " + power);

            double squareRoot = Math.Sqrt(x);
            Console.WriteLine("Square root: " + squareRoot);

            double log = Math.Log(x);
            Console.WriteLine("Log: " + log);

            double ceiling = Math.Ceiling(number);
            Console.WriteLine("Ceiling: " + ceiling);

            double pi = Math.PI;
            Console.WriteLine("Pi: " + pi);
        }
    }
}
