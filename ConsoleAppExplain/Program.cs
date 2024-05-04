namespace ConsoleAppExplain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Line 1");
            Console.WriteLine("Line 2");
            Console.WriteLine("Line 3");
            Console.WriteLine("Hello, World!");
            Console.Write("Hello, ");
            Console.Write("World!");
            Console.WriteLine(24.5);

            string name = "Garik";
            int age = 30;
            double height = 1.8;
            Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}m");

            Console.WriteLine($"Name: {name}  Age: {age}  Height: {height}m");

            Console.WriteLine("Name: {0}  Age: {2}  Height: {1}m", name, height, age);

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello, " + name + "!");
        }
    }
    //The Console class in C# provides functionality for interacting with the console window,
    //which is the text-based interface where input and output operations can be performed.
    //It allows you to read input from the user, write output to the console, and perform other console-related operations.
    //In the provided code, the Console.WriteLine method is used to write the string "Hello, World!" to the console.
    //This method writes the specified string followed by a line terminator to the console window.
    //The line terminator is a platform-specific character or characters that separate lines in the console output.
}
