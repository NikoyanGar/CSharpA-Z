namespace _009_Decision_Constructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int sum = 0;
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                int number = random.Next(1, 100);
                sum += number;

                if (number % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Count of even numbers: " + count);
            Console.WriteLine("sum of  numbers: " + sum);
        }
    }
}
