namespace BitwiseOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            string binary = Convert.ToString(number, 2);
            Console.WriteLine(binary); // Output: 101

            //Bitwise Operators:
            //Bitwise AND(&): Sets each bit to 1 if both corresponding bits are 1.
            //Bitwise OR(|): Sets each bit to 1 if either of the corresponding bits is 1.
            //Bitwise XOR(^): Sets each bit to 1 if only one of the corresponding bits is 1.
            //Bitwise NOT(~): Flips all the bits of its operand.
            //Left Shift(<<): Shifts the bits of the left operand to the left by the number of positions specified by the right operand.

            // Example 1: Bitwise AND
            int a = 5; // binary: 101
            int b = 3; // binary: 011
            int result1 = a & b; // binary: 0001 (int: 1)

            // Example 2: Bitwise OR
            int c = 5; // binary: 101
            int d = 3; // binary: 011
            int result2 = c | d; // binary: 0111 (int: 7)

            // Example 3: Bitwise XOR
            int e = 5; // binary: 101
            int f = 3; // binary: 011
            int result3 = e ^ f; // binary: 0110 (int: 6)

            // Example 4: Bitwise NOT
            int g = 5; // binary: 101
            int result4 = ~g; // binary: 1010 (int: -6)

            // Example 5: Left Shift
            int h = 5; // binary: 101
            int result5 = h << 2; // binary: 010100 (int: 20)

            // Example 6: Right Shift
            int i = 5; // binary: 101
            int result6 = i >> 2; // binary: 0001 (int: 1)
            //Right Shift(>>): Shifts the bits of the left operand to the right by the number of positions specified by the right operand.
        }
    }
}
