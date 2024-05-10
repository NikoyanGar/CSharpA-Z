namespace _005_Logical_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool condition1 = true;
            bool condition2 = false;

            // Conditional logical AND operator (&&)
            if (condition1 && condition2)
            {
                Console.WriteLine("Both conditions are true");
            }
            else
            {
                Console.WriteLine("At least one condition is false");
            }

            // Conditional logical OR operator (||)
            if (condition1 || condition2)
            {
                Console.WriteLine("At least one condition is true");
            }
            else
            {
                Console.WriteLine("Both conditions are false");
            }
        }
    }
}
