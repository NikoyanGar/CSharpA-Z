namespace _003_Equality_And_Comparison_Operators
{
    //Inequality operator !=
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1 + 1 + 2 + 3;
            int b = 6;
            Console.WriteLine(a != b);  // output: True

            string s1 = "Hello";
            string s2 = "Hello";
            Console.WriteLine(s1 != s2);  // output: False

            object o1 = 1;
            object o2 = 1;
            Console.WriteLine(o1 != o2);  // output: True
        }
    }
}
