namespace _009_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var st1 = new Student { name = "A1" };
            var st2 = new Student { name = "A2" };

            st1.Print();
            st2.Print();

            //Print(st1);

            Console.ReadLine();
        }

    }
}
