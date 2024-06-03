namespace _005_Nullable_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> a = 10; // struct

            if (a.HasValue)
            {
                Console.WriteLine("a is {0}.", a.Value);
            }

            int? b = 10;
            if (b.HasValue)
            {
                Console.WriteLine("a is {0}.", a.Value);
            }

            Console.ReadLine();

        }
    }
}
