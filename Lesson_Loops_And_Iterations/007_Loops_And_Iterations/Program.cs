namespace _007_Loops_And_Iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // While Loop Example
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("While loop iteration: " + i);
                i++;
            }

            // Do-While Loop Example
            int j = 0;
            do
            {
                Console.WriteLine("Do-While loop iteration: " + j);
                j++;
            } while (j < 5);
        }
    }
}
