namespace _013_Working_With_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = new string('t', 3);
            Console.WriteLine(String.IsInterned(s) ?? "not interned");
            String.Intern(s);//comment
            Console.WriteLine(String.IsInterned(s) ?? "not interned");
            Console.WriteLine(object.ReferenceEquals(String.IsInterned(new string('c', 3)), s));
        }
    }
}
