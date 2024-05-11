namespace _008_Null_coalescing_And_Null_Conditional_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            string greeting = $"Hello, {name}!";
            string defaultGreeting = "Hello, stranger!";

            Console.WriteLine(greeting ?? defaultGreeting);

            Console.WriteLine("Enter your age:");
            //int ageInput = int.Parse(Console.ReadLine());
            string ageInput = Console.ReadLine();
            int age;

            if (int.TryParse(ageInput, out age))
            {
                Console.WriteLine($"You are {age} years old.");
            }
            else
            {
                Console.WriteLine("Invalid age input.");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
