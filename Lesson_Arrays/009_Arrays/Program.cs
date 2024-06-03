namespace _009_Arrays
{
    //Multi-Dimensional Arrays
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize a 2D array
            int[,] matrix = new int[3, 4]
            {
                { 1, 2, 3, 0 },
                { 4, 5, 6, 0 },
                { 7, 8, 9, 0 }
            };

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));

            // Print the elements using a for loop
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
