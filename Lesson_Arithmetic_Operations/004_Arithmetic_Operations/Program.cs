namespace _004_Arithmetic_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 2;
            int result1 = num1 / num2;
            Console.WriteLine("The result of the division is: " + result1);
            Console.WriteLine("Hello, World!");

            long num3 = 100;
            long num4 = 3;
            long result2 = num3 / num4;
            Console.WriteLine("The result of the division is: " + result2);

            byte num5 = 20;
            byte num6 = 5;
            byte result3 = (byte)(num5 / num6);
            Console.WriteLine("The result of the division is: " + result3);

            short num7 = 50;
            short num8 = 7;
            short result4 = (short)(num7 / num8);
            Console.WriteLine("The result of the division is: " + result4);
        }
    }
}
