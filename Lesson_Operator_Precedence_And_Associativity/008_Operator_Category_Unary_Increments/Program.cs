namespace _008_Operator_Category_Unary_Increments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            Console.WriteLine(number++);
            Console.WriteLine(number);

            Console.WriteLine(++number);
            Console.WriteLine(number);

            //int number = 10;

            //Console.WriteLine(number--);
            //Console.WriteLine(number);

            //Console.WriteLine(--number);
            //Console.WriteLine(number);
        }
    }
}
