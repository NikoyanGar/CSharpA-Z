namespace _011_Arithmetic_Operations
{
    //Arithmetic operations with the float and double types never throw an exception. The result of arithmetic operations with
    //those types can be one of special values that represent infinity and not-a-number:

    //For the operands of the decimal type, arithmetic overflow always throws an OverflowException.
    //Division by zero always throws a DivideByZeroException.
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 1.0 / 0.0;
            Console.WriteLine(a);                    // output: Infinity
            Console.WriteLine(double.IsInfinity(a)); // output: True

            Console.WriteLine(double.MaxValue + double.MaxValue); // output: Infinity

            double b = 0.0 / 0.0;
            Console.WriteLine(b);                // output: NaN
            Console.WriteLine(double.IsNaN(b));  // output: True
        }
    }
}
