namespace _006_Working_With_String
{
    //String Manipulation:
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello, World!";

            // Using Substring() method to get a substring
            string substring = message.Substring(7);
            Console.WriteLine(substring); // Output: World!

            // Using ToUpper() method to convert the string to uppercase
            string uppercase = message.ToUpper();
            Console.WriteLine(uppercase); // Output: HELLO, WORLD!

            // Using ToLower() method to convert the string to lowercase
            string lowercase = message.ToLower();
            Console.WriteLine(lowercase); // Output: hello, world!

            // Using Trim() method to remove leading and trailing whitespace
            string trimmed = "   Hello, World!   ".Trim();
            Console.WriteLine(trimmed); // Output: Hello, World!

            // Using Replace() method to replace a substring with another string
            string replaced = message.Replace("World", "Universe");
            Console.WriteLine(replaced); // Output: Hello, Universe!

            // Using Split() method to split the string into an array of substrings
            string[] split = message.Split(',');
            Console.WriteLine(split[0]); // Output: Hello
            Console.WriteLine(split[1]); // Output: World!

            // Using IndexOf() method to find the index of a substring
            int index = message.IndexOf("World");
            Console.WriteLine(index); // Output: 7

            // Using LastIndexOf() method to find the last index of a substring
            int lastIndex = message.LastIndexOf("o");
            Console.WriteLine(lastIndex); // Output: 8
        }
    }
}
