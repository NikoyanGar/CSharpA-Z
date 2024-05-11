namespace _003_Null_coalescing_And_Null_Conditional_Operators
{
    //The null-coalescing operators are right-associative. That is, expressions of the form
    internal class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            int? b = 5;
            int c = 10;

            int result = a ?? b ?? c;//a ?? (b ?? c)
            Console.WriteLine(result);

            int? d = null;
            int? e = null;
            int f = 20;

            d ??= e ??= f;  //d ??= (e ??= f)
            Console.WriteLine(d);
            Console.WriteLine(e);
        }
    }
}
