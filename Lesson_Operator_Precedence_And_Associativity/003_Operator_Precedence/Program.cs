namespace _003_Operator_Precedence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result1;
            int a = 5, b = 6, c = 4;
            result1 = --a * b - ++c;
            Console.WriteLine(result1);

            bool result2;
            result2 = b >= c + a;
            Console.WriteLine(result2);
        }
    }
}
