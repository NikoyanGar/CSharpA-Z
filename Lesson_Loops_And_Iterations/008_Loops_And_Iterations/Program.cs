namespace _008_Loops_And_Iterations
{
    //Let's consider a scenario where you want to simulate a simple game where the player has to guess
    //a number between 1 and 10. The game should keep prompting the player for their guess until they guess the correct number.
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 11);
            int guess;

            Console.WriteLine("Welcome to the Number Guessing Game!");

            Console.WriteLine("Guess a number between 1 and 10:");
            guess = int.Parse(Console.ReadLine());

            while (guess != targetNumber)
            {
                Console.WriteLine("Incorrect guess. Try again:");
                guess = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Congratulations! You guessed the correct number: " + targetNumber);
        }
    }
}
