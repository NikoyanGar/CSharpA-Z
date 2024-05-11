namespace _006_Null_coalescing_And_Null_Conditional_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int? nullableInt = null;
            double? nullableDouble = null;
            bool? nullableBool = null;
            char? nullableChar = null;
            DateTime? nullableDateTime = null;

            Console.WriteLine($"Nullable int: {nullableInt}");
            Console.WriteLine($"Nullable double: {nullableDouble}");
            Console.WriteLine($"Nullable bool: {nullableBool}");
            Console.WriteLine($"Nullable char: {nullableChar}");
            Console.WriteLine($"Nullable DateTime: {nullableDateTime}");

            int nonNullableInt = nullableInt ?? 0;
            double nonNullableDouble = nullableDouble ?? 0.0;
            bool nonNullableBool = nullableBool ?? false;
            char nonNullableChar = nullableChar ?? '\0';
            DateTime nonNullableDateTime = nullableDateTime ?? DateTime.MinValue;

            Console.WriteLine($"Non-nullable int: {nonNullableInt}");
            Console.WriteLine($"Non-nullable double: {nonNullableDouble}");
            Console.WriteLine($"Non-nullable bool: {nonNullableBool}");
            Console.WriteLine($"Non-nullable char: {nonNullableChar}");
            Console.WriteLine($"Non-nullable DateTime: {nonNullableDateTime}");
        }
    }
}
