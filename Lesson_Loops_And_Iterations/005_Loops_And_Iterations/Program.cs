namespace _005_Loops_And_Iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Please Type name");
                string? name = Console.ReadLine();

                Console.WriteLine("Please Type age");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Type profession");
                string? profession = Console.ReadLine();

                Console.WriteLine($"Success registered Student! Name:{name}, Age: {age},  Profession:{profession}.");
                Console.WriteLine("------------------------------");

                Console.WriteLine("do you want to register new student? Please Type 'yes' or 'no' ");
                string? decision = Console.ReadLine();

                if (decision == "no")
                {
                    exit = true;
                }
            }

            Console.WriteLine("Registration process for this iteration completed");
        }
    }
}
