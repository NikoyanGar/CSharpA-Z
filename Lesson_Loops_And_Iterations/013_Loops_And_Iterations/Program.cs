namespace _013_Loops_And_Iterations
{
    //Process to exit
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students do you want to register?");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("Please Type name");
                string? name = Console.ReadLine();

                Console.WriteLine("Please Type age");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Type profession");
                string? profession = Console.ReadLine();

                Console.WriteLine($"Success registered Student! Name:{name}, Age: {age},  Profession:{profession}.");
                Console.WriteLine("do you want to register new student? Please Type 'yes' or 'no' ");

                string? decision = Console.ReadLine();
                if (decision == "no")
                {
                    //i < numberOfStudents; true
                    i = numberOfStudents;
                }
                Console.WriteLine("------------------------------");
            }
        }
    }
}
