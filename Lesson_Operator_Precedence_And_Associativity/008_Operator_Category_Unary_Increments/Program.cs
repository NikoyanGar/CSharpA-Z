namespace _008_Operator_Category_Unary_Increments
{
    //Both ++x (pre-increment) and x++ (post-increment) are unary operators, meaning they operate on a single operand.
    //Pre-increment(++x) : Increments the value of x by 1, then returns the incremented value.
    //Post-increment(x++) : Returns the value of x, then increments x by 1.

    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            Console.WriteLine(number++);
            Console.WriteLine(number);

            Console.WriteLine(++number);
            Console.WriteLine(number);

            //int number = 10;

            //Console.WriteLine(number--);
            //Console.WriteLine(number);

            //Console.WriteLine(--number);
            //Console.WriteLine(number);
        }
    }
}
