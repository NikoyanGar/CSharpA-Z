namespace _004_Null_coalescing_And_Null_Conditional_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ageStr = Console.ReadLine();
            //string? ageStr = Console.ReadLine();
            int ageInt;
            if (ageStr != null)
            {
                Console.WriteLine($"ageStr in not null it's{ageStr}");

                bool canParseToInt = int.TryParse(ageStr, out ageInt);
                if (canParseToInt)
                {
                    Console.WriteLine($"ageStr success parsed to int type {ageInt}");
                }
                else
                {
                    Console.WriteLine($"ageStr cant parse to int type and ageInt has default value {ageInt}");
                }
            }
        }
    }
}
