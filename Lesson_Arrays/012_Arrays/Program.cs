namespace _012_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,]
            {
                        {5, 2, 7},
                        {1, 9, 4},
                        {3, 6, 8}
            };

            Print2DArray(array);

            int[,,] array3D = new int[,,]
            {
                    {
                        {1, 2, 3},
                        {4, 5, 6},
                        {7, 8, 9}
                    },
                    {
                        {10, 11, 12},
                        {13, 14, 15},
                        {16, 17, 18}
                    }
            };

            Console.WriteLine("3D Array:");
            Print3DArray(array3D);
        }

        static void Print2DArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Print3DArray(int[,,] array)
        {
            int dim1 = array.GetLength(0);
            int dim2 = array.GetLength(1);
            int dim3 = array.GetLength(2);

            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < dim2; j++)
                {
                    for (int k = 0; k < dim3; k++)
                    {
                        Console.Write(array[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
