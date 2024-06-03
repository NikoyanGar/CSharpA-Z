namespace _001_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();

            Type t = st.GetType();
            string str = st.ToString();
            int code = st.GetHashCode();

            Student st1 = new Student();
            Student st2 = new Student();

            if (st1.Equals(st))
            {

            }

            Student st3 = st1;

            Console.ReadLine();

        }
    }
}
