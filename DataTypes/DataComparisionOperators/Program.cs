namespace DataComparisionOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Less than operator <
            Console.WriteLine(7.0 < 5.1);   // output: False
            Console.WriteLine(5.1 < 5.1);   // output: False
            Console.WriteLine(0.0 < 5.1);   // output: True

            //Less than or equal operator <=
            Console.WriteLine(7.0 <= 5.1);   // output: False
            Console.WriteLine(5.1 <= 5.1);   // output: True
            Console.WriteLine(0.0 <= 5.1);   // output: True


            // Greater than operator >
            Console.WriteLine(7.0 > 5.1);   // output: True
            Console.WriteLine(5.1 > 5.1);   // output: False
            Console.WriteLine(0.0 > 5.1);   // output: False

            //Greater than or equal operator >=
            Console.WriteLine(7.0 >= 5.1);   // output: True
            Console.WriteLine(5.1 >= 5.1);   // output: True
            Console.WriteLine(0.0 >= 5.1);   // output: False

        }
    }
}
