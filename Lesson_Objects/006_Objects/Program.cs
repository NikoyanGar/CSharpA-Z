namespace _006_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var st = new Student("a1@gmail.com")
            {
                name = "A1",
                surname = "A1yan"
            };

            st.Age = 200;
            byte age = st.Age;

            //st.SetAge(200);

            //byte age = st.GetAge(); 
        }

    }
}
