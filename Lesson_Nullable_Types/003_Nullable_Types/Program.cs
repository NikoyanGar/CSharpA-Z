namespace _003_Nullable_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            int b;

            b = a ?? 10; // b = 10
            int e = a ?? 10; // b = 10

            b = a != null ? (int)a : 10;

            if (a == null)
                b = 10;
            else
                b = (int)a;

            Console.WriteLine(b);

            a = 5;
            b = a ?? 10; // b = 5

            Console.ReadLine();

        }
    }
}
