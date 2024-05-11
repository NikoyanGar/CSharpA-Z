namespace _001_Bitwise_And_Shift_Operators
{
    //The bitwise and shift operators include unary bitwise complement, binary left and right shift,
    //unsigned right shift, and the binary logical AND, OR, and exclusive OR operators.
    //These operands take operands of the integral numeric types or the char type.
    internal class Program
    {
        //Bitwise complement operator ~
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Example of bitwise complement operator
            int number = 10;
            int complement = ~number;
            Console.WriteLine($"Bitwise complement of {number} is {complement}");
            //The binary representation of 10 is 00000000 00000000 00000000 00001010.
            //When we apply the bitwise complement operator to this binary representation,
            //it becomes 11111111 11111111 11111111 11110101.
            //In two's complement representation, the most significant bit (leftmost bit) is used to represent the sign
            //of the number. If the most significant bit is 1, it indicates a negative number.
            //So, the binary representation 11111111 11111111 11111111 11110101 represents the negative number -11.

        }
    }
}
