namespace _002_Arithmetic_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int number2 = 2;
            int number3 = number - number2;
            Console.WriteLine($"Difference between {number} and {number2} is {number3}");

            int number4 = 5 - 1;
            Console.WriteLine($"Difference between 5 and 1 is {number4}");
            Console.WriteLine(number4);

            int number5 = 10 - 5;
            Console.WriteLine($"Difference between 10 and 5 is {number5}");

            int number6 = 10 - number5;
            Console.WriteLine($"Difference between 10 and {number5} is {number6}");

            int number7 = number6 - number;
            Console.WriteLine($"Difference between {number6} and {number} is {number7}");

            Console.WriteLine(10 - number6 - number);
        }
    }
}
