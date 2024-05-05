namespace _005_Working_With_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "AAA";
            string str2 = "aaa";

            bool isEqual = str1 == str2;
            bool isEqualIgnoreCase = str1.Equals(str2, StringComparison.OrdinalIgnoreCase);

            Console.WriteLine(isEqual);
            Console.WriteLine(isEqualIgnoreCase);
        }
    }
}
