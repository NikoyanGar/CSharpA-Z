namespace _002_Loops_And_Iterations
{
    // while loop to compute sum 
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1, sum = 0;

            while (i <= 100)
            {
                sum += i;
                i++;
            }

            Console.WriteLine("Sum = {0}", sum);
        }
    }
}
