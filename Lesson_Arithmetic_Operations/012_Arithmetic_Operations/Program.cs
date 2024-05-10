namespace _012_Arithmetic_Operations
{
    //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0.1;
            double b = 3 * a;
            Console.WriteLine(b == 0.3);   // output: False
            Console.WriteLine(b - 0.3);    // output: 5.55111512312578E-17

            decimal c = 1 / 3.0m;
            decimal d = 3 * c;
            Console.WriteLine(d == 1.0m);  // output: False
            Console.WriteLine(d);          // output: 0.9999999999999999999999999999
        }
    }
}
