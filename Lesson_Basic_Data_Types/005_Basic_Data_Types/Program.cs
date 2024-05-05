namespace _005_Basic_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Floating-point types are used to represent numbers with a fractional part.
            // They are suitable for representing values that can have a wide range of magnitudes and precision.

            // Example 1: float
            float floatValue = 3.14f;
            Console.WriteLine(floatValue);
            // Example 2: double
            double doubleValue = 3.14159;
            Console.WriteLine(doubleValue);

            // Example 3: decimal
            decimal decimalValue = 3.141592653589793238m;
            Console.WriteLine(decimalValue);
            Console.ReadKey();
        }
    }
}
