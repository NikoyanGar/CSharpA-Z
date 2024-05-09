namespace _004_Decision_Constructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Type age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("In Armenia you are adult");
                if (age > 120)
                {
                    Console.WriteLine("Not supported age in our program");
                }
                if (age == 119)
                {
                    Console.WriteLine("Last supported age in our program");
                }
                if (age == 118)
                {
                    Console.WriteLine("You can legally drink alcohol in Usa");
                }
            }
        }
    }
}
