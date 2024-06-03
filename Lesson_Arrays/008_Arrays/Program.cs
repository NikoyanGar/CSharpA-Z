namespace _008_Arrays
{
    //Multi-Dimensional Arrays
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize a 2D array
            int[,] matrix = new int[3, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            // Accessing elements in a 2D array
            int element = matrix[1, 2]; // Accessing the element at row 1, column 2

            // Print the element
            Console.WriteLine(element);
        }
    }
}
