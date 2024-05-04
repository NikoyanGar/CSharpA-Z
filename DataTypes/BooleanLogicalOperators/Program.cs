namespace BooleanLogicalOperators
{
    // AND, OR, NOT, XOR
    internal class Program
    {
        static void Main(string[] args)
        {
            //Logical negation operator !
            bool passed = false;
            Console.WriteLine(!passed);  // output: True
            Console.WriteLine(!true);    // output: False

            //Logical AND operator &
            Console.WriteLine(true & false);
            Console.WriteLine(true & true);
            Console.WriteLine(false & false);


            //Logical OR operator |
            Console.WriteLine(true | false);
            Console.WriteLine(true | true);
            Console.WriteLine(false | false);

            //Logical exclusive OR operator ^ (XOR)
            Console.WriteLine(true ^ true);    // output: False
            Console.WriteLine(true ^ false);   // output: True
            Console.WriteLine(false ^ true);   // output: True
            Console.WriteLine(false ^ false);  // output: False

        }
    }
    //That is, for the bool operands, the ^ operator computes the same result as the inequality operator !=.
}
