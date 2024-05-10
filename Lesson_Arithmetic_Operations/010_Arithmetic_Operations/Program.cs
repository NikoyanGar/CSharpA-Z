namespace _010_Arithmetic_Operations
{
    //Integer arithmetic overflow
    internal class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int a = int.MaxValue; // Assigning the maximum value of int
                int b = 1;
                int result = a + b; // This will throw an OverflowException
            }

            unchecked
            {
                int a = int.MaxValue; // Assigning the maximum value of int
                int b = 1;
                int result = a + b; // The result will be -2147483648
                Console.WriteLine(result);
            }
        }
    }
}
