namespace _007_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assuming you want to resize an array in C#

            // Declare and initialize the original array
            int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Resize the array to a new length
            Array.Resize(ref originalArray, 10000000);

            // Print the resized array using a for loop
            for (int i = 0; i < originalArray.Length; i++)
            {
                int num = originalArray[i];
                Console.WriteLine(num);
            }
        }
    }
}
