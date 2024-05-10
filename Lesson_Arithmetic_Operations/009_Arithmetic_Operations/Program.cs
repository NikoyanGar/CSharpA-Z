namespace _009_Arithmetic_Operations
{
    //Arithmetic overflow and division by zero
    //When the result of an arithmetic operation is outside the range of possible finite values of the involved numeric type,
    //the behavior of an arithmetic operator depends on the type of its operands.
    //Integer division by zero always throws a DivideByZeroException.
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 0;
            Console.WriteLine(x / y);
            Console.ReadKey();
        }
    }
}
