namespace _009_Loops_And_Iterations
{
    // let's see how the same functionality can be implemented using a do-while loop:
    //The only difference is that a While loop body may not be executed at all (if condition is false before the first run),
    //while a Do/While loop body is guaranteed to be executed at least once.
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 11);
            int guess;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            //Game scope,  player is prompted for their initial guess at least once
            do
            {
                Console.WriteLine("Guess a number between 1 and 10:");
                guess = int.Parse(Console.ReadLine());

                if (guess != targetNumber)
                {
                    Console.WriteLine("Incorrect guess. Try again:");
                }
            } while (guess != targetNumber);

            Console.WriteLine("Congratulations! You guessed the correct number: " + targetNumber);
        }
    }
}
