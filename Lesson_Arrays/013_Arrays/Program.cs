namespace _013_Arrays
{
    //In this example, we declare a 3D array called _3DArray with dimensions 2x3x4.
    //This means it has 2 layers, each layer has 3 rows, and each row has 4 columns.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] _3DArray = new int[2, 3, 4];

            //Console.WriteLine(_3DArray.Length);
            //Console.WriteLine(_3DArray.Rank);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        _3DArray[i, j, k] = i + j + k;
                    }
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        Console.WriteLine($"_3DArray[{i}, {j}, {k}] = {_3DArray[i, j, k]}");
                    }

                }
            }
        }
    }
}
