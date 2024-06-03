namespace _005_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next();
            }

        }
    }
}
