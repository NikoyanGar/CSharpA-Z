namespace _006_Bitwise_And_Shift_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example of binary exclusive OR operator
            int p = 8;
            int q = 12;
            int xorResult = p ^ q;
            Console.WriteLine($"Binary exclusive OR of {p} and {q} is {xorResult}");

            //1.	Convert the numbers to binary representation:
            //•	8 in binary: 00001000
            //•	12 in binary: 00001100
            //2.Compare the bits of the two numbers:
            //•	Starting from the leftmost bit, compare each corresponding pair of bits:
            //•	0 XOR 0 = 0
            //•	0 XOR 0 = 0
            //•	0 XOR 0 = 0
            //•	0 XOR 0 = 0
            //•	1 XOR 1 = 0
            //•	0 XOR 1 = 1
            //•	0 XOR 1 = 1
            //•	0 XOR 0 = 0
            //3.Combine the results of the XOR operation to form the final result:
            //•	The XOR operation produces the binary number: 00000100
            //4.Convert the binary result back to decimal:
            //•	The binary number 00000100 is equal to 4 in decimal.
        }
    }
}
