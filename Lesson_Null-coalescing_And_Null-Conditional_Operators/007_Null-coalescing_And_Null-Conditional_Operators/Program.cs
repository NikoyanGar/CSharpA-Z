namespace _007_Null_coalescing_And_Null_Conditional_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? nullableInt = null;
            double? nullableDouble = 3.14;
            bool? nullableBool = true;
            char? nullableChar = 'A';
            DateTime? nullableDateTime = DateTime.Now;

            int intValue = nullableInt ?? 0;//Comment this line
            double doubleValue = nullableDouble ?? 0.0;
            bool boolValue = nullableBool ?? false;
            char charValue = nullableChar ?? ' ';
            DateTime dateTimeValue = nullableDateTime ?? DateTime.MinValue;

            Console.WriteLine($"Nullable Int: {nullableInt?.ToString() ?? "null"}");
            Console.WriteLine($"Nullable Double: {nullableDouble?.ToString() ?? "null"}");
            Console.WriteLine($"Nullable Bool: {nullableBool?.ToString() ?? "null"}");
            Console.WriteLine($"Nullable Char: {nullableChar?.ToString() ?? "null"}");
            Console.WriteLine($"Nullable DateTime: {nullableDateTime?.ToString() ?? "null"}");

            Console.WriteLine($"Int Value: {intValue}");
            Console.WriteLine($"Double Value: {doubleValue}");
            Console.WriteLine($"Bool Value: {boolValue}");
            Console.WriteLine($"Char Value: {charValue}");
            Console.WriteLine($"DateTime Value: {dateTimeValue}");

        }
    }
}
