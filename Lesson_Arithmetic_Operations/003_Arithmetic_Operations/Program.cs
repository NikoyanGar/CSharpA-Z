namespace _003_Arithmetic_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Examples of multiplication
            int num1 = 5;
            int num2 = 10;
            int result = num1 * num2;
            Console.WriteLine("Multiplication: " + result);

            double decimalNum1 = 2.5;
            double decimalNum2 = 1.5;
            double decimalResult = decimalNum1 * decimalNum2;
            Console.WriteLine("Decimal Multiplication: " + decimalResult);

            float floatNum1 = 3.14f;
            float floatNum2 = 2.5f;
            float floatResult = floatNum1 * floatNum2;
            Console.WriteLine("Float Multiplication: " + floatResult);

            decimal bigNum1 = 10000000000000000000m;
            decimal bigNum2 = 20000000000000000000m;
            decimal bigResult = bigNum1 * bigNum2;
            Console.WriteLine("Big Decimal Multiplication: " + bigResult);
        }
    }
}
