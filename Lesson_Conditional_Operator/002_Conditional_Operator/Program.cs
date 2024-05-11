namespace _002_Conditional_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = new Random().Next(-5, 5);

            string classify;
            if (input >= 0)
            {
                classify = "nonnegative";
            }
            else
            {
                classify = "negative";
            }
            //Alternative and short syntax
            classify = input >= 0 ? "nonnegative" : "negative";
            Console.WriteLine(classify);
        }
    }
}
