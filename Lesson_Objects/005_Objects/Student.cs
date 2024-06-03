namespace _005_Objects
{
    class Student
    {
        public Student(string email)
        {
            this.email = email;
            System.Diagnostics.Debug.WriteLine("my ctor.");
        }

        public string name;
        public string surname;
        public readonly string email;
        public int age;
    }

}