namespace _010_Decision_Constructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 11; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} derives to 5");
                }
            }
            Console.ReadKey();
        }
    }
}
