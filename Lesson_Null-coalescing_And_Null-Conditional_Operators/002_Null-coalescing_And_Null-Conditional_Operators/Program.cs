namespace _002_Null_coalescing_And_Null_Conditional_Operators
{
    // In this example, nullableValue is null, so the null - coalescing operator assigns the default value of 10 to nonNullableValue.

    internal class Program
    {
        static void Main(string[] args)
        {
            int? nullableValue = null;
            int nonNullableValue = nullableValue ?? 10;
            Console.WriteLine(nonNullableValue); // Output: 10
        }
    }
}
