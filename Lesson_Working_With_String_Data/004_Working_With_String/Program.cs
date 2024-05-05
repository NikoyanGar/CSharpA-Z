namespace _004_Working_With_String
{
    //Accessing Characters:
    //You can access individual characters in a string using index notation([]). Strings in C# are zero-indexed, meaning the index of the first character is 0. For example
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, World!";
            int lenght = str.Length;
            char firstChar = str[0];
            char secondChar = str[1];
            char lastChar = str[lenght - 1];


            Console.WriteLine(firstChar);
            Console.WriteLine(secondChar);
            Console.WriteLine(lastChar);
        }
    }
}
