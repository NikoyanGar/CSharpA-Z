namespace _001_Operator_Precedence
{
    //Operator precedence is a set of rules which defines how an expression is evaluated.
    //In C#, each C# operator has an assigned priority and based on these priorities, the expression is evaluated.
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 4 + 3 * 5;//The precedence of multiplication (*) operator is higher than the precedence of addition (+) operator
            Console.WriteLine(x);
        }
    }
}
