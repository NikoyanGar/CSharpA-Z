namespace _003_Operator_Associativity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 5;
            int result = a > b ? a < b ? 50 : 100 : 150;
            // Conditional (?:) is right-associative.
            // result is 100, not 50 or 150,
            // because it's calculated as a > b ? (a < b ? 50 : 100) : 150

        }
    }
}
