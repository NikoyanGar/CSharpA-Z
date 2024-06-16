namespace _014_Operator_Precedence_Combination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 3;
            int z = x++ * --y;

            // x is post-incremented and y is pre-decremented before multiplication.
            // Here's the order of operation due to precedence:
            // 1. y is decremented to 2 (because of pre-decrement --y).
            // 2. x (which is 5) is multiplied by the new value of y (which is 2), so z = 5 * 2.
            // 3. After the multiplication, x is incremented to 6 (because of post-increment x++).
        }
    }
}
