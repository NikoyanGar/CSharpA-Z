namespace _007_Working_With_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Garik";
            int age = 30;

            // Composite formatting
            string compositeFormattedString = string.Format("My name is {0} and I am {1} years old.", name, age);
            Console.WriteLine(compositeFormattedString);

            // Interpolated string
            string interpolatedString = $"My name is {name} and I am {age} years old.";
            Console.WriteLine(interpolatedString);
        }
    }
}
