namespace _004_Bitwise_And_Shift_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example of binary logical AND operator
            //The binary logical AND operator (&) compares the corresponding bits of two integers and returns
            //a new integer with bits set to 1 only if both corresponding bits in the operands are 1.
            //In this case, since the binary representation of 10 is 1010 and the binary representation of 5 is 0101,
            //the result of the binary logical AND operation is 0000, which is 0 in decimal.
            int a = 10;
            int b = 5;
            int result = a & b;
            Console.WriteLine($"Binary logical AND of {a} and {b} is {result}");
        }
    }
}
