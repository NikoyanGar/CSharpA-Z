namespace _002_Bitwise_And_Shift_Operators
{
    // Example of binary left shift operator
    internal class Program
    {
        //The binary left shift operator shifts the bits of a number to the left by a specified number of positions.
        //It effectively multiplies the number by 2 raised to the power of the specified shift amount.
        static void Main(string[] args)
        {
            int value = 5;
            int shiftedValue = value << 2;
            Console.WriteLine($"Binary left shift of {value} by 2 is {shiftedValue}");
            //We start by declaring a variable value and assigning it the value of 5.
            //Next, we use the binary left shift operator (<<) to shift the bits of value two positions to the left.
            //This means that the binary representation of value(which is 00000101) will be shifted to become 00010100.
            //The result of the left shift operation is then assigned to the variable shiftedValue.
            //Finally, we use Console.WriteLine() to display the result of the left shift operation.
            //The output will be: "Binary left shift of 5 by 2 is 20".
            //In this case, the binary left shift operator effectively multiplied the value of value by 2 raised to the power of 2,
            //resulting in the value of 20.
            //It's important to note that the binary left shift operator only operates on the binary representation of the number,
            //shifting the bits to the left. It does not change the actual value of the number itself.
        }
    }
}
