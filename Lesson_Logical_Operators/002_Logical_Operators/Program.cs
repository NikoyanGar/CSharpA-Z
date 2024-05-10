namespace _002_Logical_Operators
{
    internal class Program
    {
        // Logical AND operator examples
        static void Main(string[] args)
        {
            // Example 1: Using the Logical AND operator with boolean values
            bool a = true;
            bool b = false;
            bool result = a & b;
            Console.WriteLine(result);  // Output: False

            // Example 2: Using the Logical AND operator with integers
            int x = 5;
            int y = 10;
            bool condition = (x > 0) & (y < 20);
            Console.WriteLine(condition);  // Output: True

            // Example 3: Using the Logical AND operator with strings
            string str1 = "Hello";
            string str2 = "World";
            bool check = (str1.Length > 0) & (str2.Length > 0);
            Console.WriteLine(check);  // Output: True
        }
    }
}
