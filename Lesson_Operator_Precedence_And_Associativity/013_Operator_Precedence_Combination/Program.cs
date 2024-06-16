namespace _013_Operator_Precedence_Combination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int x1 = 5;
            int y = ++x + 2;
            int y1 = 2 + ++x1;
            Console.WriteLine(y == y1);
            // The pre-increment operator (++x) has higher precedence
            // than addition (+), so x is incremented before being added to 2.
            // y is 8 because it's calculated as (6) + 2

        }
    }
}
