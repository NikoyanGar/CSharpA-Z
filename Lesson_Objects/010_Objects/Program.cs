namespace _010_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = CreateStudents(10);
            foreach (Student st in students)
            {
                //Console.WriteLine($"{st.surname} {st.name}");
                Console.WriteLine(st.Fullname);

            }

            Console.ReadLine();
        }

        static List<Student> CreateStudents(int count)
        {
            Random rnd = new Random();
            List<Student> source = new List<Student>(count);
            for (int i = 0; i < count; i++)
            {
                Student st = new Student
                {
                    name = $"A{i + 1}",
                    surname = $"A{i + 1}yan",
                    email = $"a{i + 1}@gmail.com",
                    age = (byte)rnd.Next(15, 40)
                };
                source.Add(st);
            }

            return source;
        }

    }
}
