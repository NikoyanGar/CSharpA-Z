namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 23;//<-

            int a, b, c;
            a = b = c = 34;

            int a1, b1, c1;
            a1 = b1 = c1 = 34 * 2 / 4; // 17 '=' has low priority

            a += 1;
            a += b;
            a -= b;
            a *= 2 / 4;
            a %= b;
        }
    }
}
