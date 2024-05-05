namespace _005_Arithmetic_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = b = c = 34;//<-

            int a1, b1, c1;
            a1 = b1 = c1 = 34 * 2 / 4; // 17 '=' has low priority

            int x = 2 + 2 * 2 / 2;
            Console.WriteLine(x);

            int x1 = (2 + 2) * (2 / 2);
            Console.WriteLine(x1);
        }
    }
}
