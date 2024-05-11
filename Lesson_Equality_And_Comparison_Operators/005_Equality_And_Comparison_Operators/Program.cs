namespace _005_Equality_And_Comparison_Operators
{
    //Less than or equal operator <=
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(7.0 <= 5.1);   // output: False
            Console.WriteLine(5.1 <= 5.1);   // output: True
            Console.WriteLine(0.0 <= 5.1);   // output: True

            Console.WriteLine(7.0 >= 5.1);   // output: True
            Console.WriteLine(5.1 >= 5.1);   // output: True
            Console.WriteLine(0.0 >= 5.1);   // output: False


            Console.WriteLine(double.NaN > 5.1);   // output: False
            Console.WriteLine(double.NaN <= 5.1);  // output: False
            Console.WriteLine(double.NaN < 5.1);   // output: False
            Console.WriteLine(double.NaN >= 5.1);  // output: False
        }
    }
}
