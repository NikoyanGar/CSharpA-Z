namespace _001_Loops_And_Iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 10;
            while (x > 0)
            {
                Console.WriteLine("C# while Loop: x == {0}", x);
                x--;
            }

            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("C# while Loop: Iteration {0}", i);
                i++;
            }
        }
    }
}
