namespace _001_Null_coalescing_And_Null_Conditional_Operators
{
    //Understanding Null Coalescing in C#
    //The null coalescing operator, ??, is a handy binary operator that returns its left-hand operand
    //as it is if not null, and otherwise its right-hand operand. This means it simplifies checking for null
    //values in C# while keeping your code clean and concise. Let’s see some benefits of using nullable coalescing operator
    internal class Program
    {
        static void Main(string[] args)
        {
            string? name = Console.ReadLine();
            if (name == null)
            {
                name = "Unknown";
            }

            // With null coalescing operator
            //T result = nullableValue ?? defaultValue;
            string nonNullName = name ?? "Unknown";
            Console.WriteLine(nonNullName);
        }
    }
}
