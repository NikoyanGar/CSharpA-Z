namespace _007_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var st = new Student("a1@gmail.com")
            {
                name = "A1",
                surname = "A1yan",
                Age = 18
            };

            Console.WriteLine($"{st.surname} {st.name}");
            Console.WriteLine(st.FullName);

            Console.ReadLine();
        }

    }
}
