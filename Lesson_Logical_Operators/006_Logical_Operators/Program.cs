namespace _006_Logical_Operators
{
    //Logical negation operator !
    //Logical AND operator &
    //Logical exclusive OR operator ^
    //Logical OR operator |
    //Conditional logical AND operator &&
    //Conditional logical OR operator ||
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(true | true & false);   // output: True
            Console.WriteLine((true | true) & false); // output: False
        }
    }
}
