namespace _009_Null_coalescing_And_Null_Conditional_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nullable types
            int? nullableInt = null;
            nullableInt = default(int?);
            nullableInt = default;
            Console.WriteLine(nullableInt.GetValueOrDefault()); // Output: 0
            Console.WriteLine(nullableInt.GetValueOrDefault(10)); // Output: 10

            // Non-nullable types
            int nonNullableInt = default;
            Console.WriteLine(nonNullableInt); // Output: 0

            string? nonNullableString = default;//not correct for string it always Nullable
            //string  nonNullableString = default;
            Console.WriteLine(nonNullableString); // Output: null
        }
    }
}
