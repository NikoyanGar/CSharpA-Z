namespace _002_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Type Your name");

            // Read input from the user
            string? name = Console.ReadLine();
            Console.WriteLine("Hi: " + name);

            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"So you are {age} years old.");

            Console.WriteLine("What is your profession?");
            string? profession = Console.ReadLine();
            Console.WriteLine($"Interesting! So you are a {profession}.");

            Console.WriteLine("What is your favorite hobby?");
            string? hobby = Console.ReadLine();
            Console.WriteLine($"Nice! {hobby} is a great hobby.");

            Console.WriteLine("Thank you for sharing. Have a great day!");
        }
    }
}
