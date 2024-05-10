namespace _005_Decision_Constructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 15;

            int max = a;

            if (b > max)
            {
                max = b;
            }

            if (c > max)
            {
                max = c;
            }

            Console.WriteLine("The maximum value is: " + max);
        }
    }
}
