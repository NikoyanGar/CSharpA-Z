namespace _003_Decision_Constructs
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
                if (age > 21)
                {
                    Console.WriteLine("You can legally drink alcohol in USA");
                }
            }
        }
    }
}
