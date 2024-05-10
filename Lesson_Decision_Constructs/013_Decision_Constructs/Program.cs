namespace _013_Decision_Constructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 11; i++)
            {
                switch (i)
                {
                    case 5:
                    case 10:
                        Console.WriteLine($"{i} is divisible by 5");
                        break;
                    default:
                        Console.WriteLine($"{i} is not divisible by 5. Quotient = {i / 5} ");
                        break;
                }
            }
        }
    }
}
