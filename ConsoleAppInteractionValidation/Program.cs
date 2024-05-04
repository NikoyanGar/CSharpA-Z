namespace ConsoleAppInteractionValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Are you registered? type yes or no");
            string? isRegistered = Console.ReadLine();
            if (isRegistered == "yes")
            {
                Console.Write("Enter your username: ");
                string? username = Console.ReadLine();

                Console.Write("Enter your password: ");
                string? password = Console.ReadLine();


                Console.WriteLine("You are successfully Logged in");
            }
            else
            {
                Console.Write("Enter your Name: ");
                string? name = Console.ReadLine();

                Console.Write("Enter your age: ");
                string? age = Console.ReadLine(); //What about ?

                Console.Write("Enter your SSN: ");
                string? ssn = Console.ReadLine();

                Console.Write("Enter your username: ");
                string? username = Console.ReadLine();

                Console.Write("Enter your password: ");
                string? password = Console.ReadLine();

                Console.Write("repeat your password: ");
                string? password2 = Console.ReadLine();

                if (password != password2)
                {
                    Console.WriteLine("passwords mismatch, please enter the same password");
                }

                Console.WriteLine("User registration successful!");

            }
        }
    }
}
