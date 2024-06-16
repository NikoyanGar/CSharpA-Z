namespace _001_Operator_Associativity
{
    //Operator associativity determines the order in which operators of
    //the same precedence are processed. In C#, most binary operators are left-associative,
    //meaning they are evaluated from left to right. Here are some examples:
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 100 / 10 / 2;
            // Division (/) is left-associative.
            // result is 5, not 20, because it's calculated as (100 / 10) / 2
        }
    }
}
