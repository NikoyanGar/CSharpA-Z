namespace _012_Operator_Precedence_Combination
{
    //Combination of relational and conditional operators:

    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 5;
            bool isGreater = a > b ? true : false;
            // The relational operator (>) has higher precedence than
            // the conditional operator (? :).
            // isGreater is true because a is greater than b.
            Console.WriteLine(isGreater);
        }
    }
}
