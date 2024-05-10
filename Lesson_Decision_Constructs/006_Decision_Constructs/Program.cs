namespace _006_Decision_Constructs
{
    //Try 100 variables
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            int num3 = 15;
            int num4 = 20;
            int num5 = 25;
            int num6 = 30;
            int num7 = 35;
            int num8 = 40;
            int num9 = 45;
            int num10 = 50;

            int max = num1;

            if (num2 > max)
                max = num2;
            if (num3 > max)
                max = num3;
            if (num4 > max)
                max = num4;
            if (num5 > max)
                max = num5;
            if (num6 > max)
                max = num6;
            if (num7 > max)
                max = num7;
            if (num8 > max)
                max = num8;
            if (num9 > max)
                max = num9;
            if (num10 > max)
                max = num10;

            Console.WriteLine("The maximum number is: " + max);
        }
    }
}
