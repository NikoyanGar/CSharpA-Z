namespace _004_Equality_And_Comparison_Operators
{
    //The < (less than), > (greater than), <= (less than or equal), and >= (greater than or equal) comparison, also known as relational,
    //operators compare their operands. Those operators are supported by all integral and floating-point numeric types.
    //The char type also supports comparison operators.In the case of char operands, the corresponding character codes are compared.
    internal class Program
    {
        //Less than operator <
        static void Main(string[] args)
        {
            Console.WriteLine(7.0 < 5.1);   // output: False
            Console.WriteLine(5.1 < 5.1);   // output: False
            Console.WriteLine(0.0 < 5.1);   // output: True

            Console.WriteLine(7.0 > 5.1);   // output: True
            Console.WriteLine(5.1 > 5.1);   // output: False
            Console.WriteLine(0.0 > 5.1);   // output: False


            Console.WriteLine(double.NaN < 5.1);   // output: False
            Console.WriteLine(double.NaN > 5.1);   // output: False

        }
    }
}
