namespace _005_Bitwise_And_Shift_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The bitwise OR operator (|) performs a bitwise OR operation on each corresponding bit of the two operands.
            //It returns a value where each bit is set to 1 if at least one of the corresponding bits in the operands is 1.
            //Otherwise, the bit is set to 0.
            //In this example, the binary representation of a is 1010, and the binary representation of b is 0101.
            //When we perform the bitwise OR operation, we get 1111, which is the binary representation of 15.
            int a = 10;
            int b = 5;
            int result = a | b;
            Console.WriteLine($"Binary logical Or of {a} and {b} is {result}");
        }
    }
}
