namespace ArithmeticOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int z = x + 12; // 22

            int a = 10;
            int c = a - 6; // 4

            int a1 = 10;
            int c1 = a1 * 5; // 50

            int a2 = 10;
            int c2 = a2 / 5; // 2, why?
            Console.WriteLine(c2);


            //double a2= 10;
            //double b2 = 3;
            //double c2= a2 / b2; // 3.33333333

            double d = 10 / 3; //3
            double d2 = 10.0 / 3.0;//3.33333
            Console.WriteLine(d2);
            Console.WriteLine(13 / 5.0);       // output: 2.6

            //The operation of obtaining the remainder of an integer division of two numbers
            double remainder = 10.0 % 4.0; // 2
        }
    }
}
