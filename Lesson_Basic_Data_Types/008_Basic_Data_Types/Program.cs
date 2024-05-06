namespace _008_Basic_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            string message = "Hello, World!";
            int length = message.Length;
            Console.WriteLine(length);

            int number = 42;
            string numberString = number.ToString();
            Console.WriteLine(numberString);

            string name = "Alice";
            int age = 25;
            string message1 = $"My name is {name} and I am {age} years old.";
            Console.WriteLine(message1);
        }
    }
}
