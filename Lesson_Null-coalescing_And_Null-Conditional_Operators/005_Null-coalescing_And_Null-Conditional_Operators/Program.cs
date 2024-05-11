namespace _005_Null_coalescing_And_Null_Conditional_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                var ageStr = Console.ReadLine();
                int ageInt;

                Console.WriteLine(ageStr != null ? $"ageStr is not null, it's {ageStr}" : "ageStr is null");

                Console.WriteLine(int.TryParse(ageStr, out ageInt) ?
                    $"ageStr successfully parsed to int type: {ageInt}"
                    : $"ageStr cannot be parsed to int type and ageInt has the default value: {ageInt}");
            }
        }
    }
}
