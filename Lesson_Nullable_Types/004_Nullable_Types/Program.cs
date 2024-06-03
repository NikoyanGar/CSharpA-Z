namespace _004_Nullable_Types
{
    internal class Program
    {
        private static int? index;

        static void Main(string[] args)
        {
            if (index == null)
            {
                Console.WriteLine("null");
            }
            else if (index == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("other...");
            }

            Console.ReadLine();
        }

    }
}
