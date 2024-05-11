namespace _003_Bitwise_And_Shift_Operators
{
    // Example of binary right shift operator
    internal class Program
    {
        static void Main(string[] args)
        {
            // The binary right shift operator is useful when you need to divide an integer by a power of 2.
            // Each right shift by n positions is equivalent to dividing the number by 2 ^ n.
            // The binary right shift operator (>>) is used to shift the bits of a number to the right by a specified
            // number of positions.In this example, the number 20 is being shifted to the right by 2 positions.
            // Here's a step-by-step breakdown of what happens in the code:
            //1.The variable num is assigned the value 20.
            //2.The binary right shift operator (>>) is used to shift the bits of num two positions to the right.
            //3.The result of the shift operation is stored in the variable shiftedNum.
            //4.The Console.WriteLine statement is used to display the result of the shift operation.
            //It uses string interpolation to include the original number(num) and the shifted number(shiftedNum) in the output.
            //In this case, the binary right shift of 20 by 2 positions results in 5.So, the output of the code will be:
            int num = 20;
            int shiftedNum = num >> 2;//00010100->00000101
            Console.WriteLine($"Binary right shift of {num} by 3 is {shiftedNum}");
        }
    }
}
