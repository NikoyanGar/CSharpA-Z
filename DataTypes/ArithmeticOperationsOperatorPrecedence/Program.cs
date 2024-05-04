namespace ArithmeticOperationsOperatorPrecedence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); int a, b, c;
            a = 7;
            b = a;
            c = b++;
            b = a + b * c;
            c = a >= 100 ? b : c / 10;
            a = (int)Math.Sqrt(b * b + c * c);//About Math Class

            Console.WriteLine(2 + 2 * 2);
            Console.WriteLine((2 + 2) * 2);
            Console.WriteLine(13 / 5 / 2);
        }
    }
    //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/#operator-precedence
}
