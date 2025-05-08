namespace _007_Bitwise_And_Shift_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 6;   // 0110 in binary
            int b = 3;   // 0011 in binary

            int andResult = a & b;  // 0010 => 2
            int orResult = a | b;   // 0111 => 7
            // does not work in C# because || is the logical OR operator, not the bitwise OR operator.
            //int orResult1 = a || b; 
            int xorResult = a ^ b;  // 0101 => 5
            int notResult = ~a;     // 1111...1001 => -7 (two's complement)
            int leftShift = a << 1; // 1100 => 12
            int rightShift = a >> 1; // 0011 => 3

            Console.WriteLine($"AND: {andResult}");
            Console.WriteLine($"OR: {orResult}");
            Console.WriteLine($"XOR: {xorResult}");
            Console.WriteLine($"NOT: {notResult}");
            Console.WriteLine($"Left Shift: {leftShift}");
            Console.WriteLine($"Right Shift: {rightShift}");
        }
    }
}
