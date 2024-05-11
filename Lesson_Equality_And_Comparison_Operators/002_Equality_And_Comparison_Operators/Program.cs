namespace _002_Equality_And_Comparison_Operators
{
    //Two string operands are equal when both of them are null or both string instances
    //are of the same length and have identical characters in each character position:
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello!";
            string s2 = "HeLLo!";
            Console.WriteLine(s1 == s2.ToLower());  // output: True

            string s3 = "Hello!";
            Console.WriteLine(s1 == s3);  // output: False
        }
    }
}
