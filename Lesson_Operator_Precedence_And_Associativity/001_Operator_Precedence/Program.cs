namespace _001_Operator_Precedence
{
    //Operator precedence is a set of rules which defines how an expression is evaluated.
    //In C#, each C# operator has an assigned priority and based on these priorities, the expression is evaluated.
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 4 + 3 * 5;//The precedence of multiplication (*) operator is higher than the precedence of addition (+) operator
            int result = (2 + 3) * 4; // Parentheses have the highest precedence and force the addition to be evaluated first.
            bool logicalResult = true || false && false; // Logical AND (&&) has higher precedence than logical OR (||), so it's evaluated first.
            Console.WriteLine(x);
            Console.WriteLine(result);
            Console.WriteLine(logicalResult);
        }
    }
}
