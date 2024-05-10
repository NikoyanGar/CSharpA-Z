namespace _003_Logical_Operators
{
    // operator computes the same result as the inequality operator !=.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Logical exclusive OR operator ^
            Console.WriteLine(true ^ true);    // output: False
            Console.WriteLine(true ^ false);   // output: True
            Console.WriteLine(false ^ true);   // output: True
            Console.WriteLine(false ^ false);  // output: False
        }
    }
}
