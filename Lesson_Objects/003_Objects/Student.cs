namespace _003_Objects
{
    class Student
    {
        public Student()
        {
            age = 18;
        }

        public Student(string name)
        {
            this.name = name;
        }

        public Student(string name, string surname)
            : this(name)
        {
            //this.name = name;
            this.surname = surname;
        }

        public Student(string name, string surname, string email)
            : this(name, surname)
        {
            this.email = email;
        }

        public Student(string name, string surname, string email, int age)
            : this(name, surname, email)
        {
            this.age = age;
        }

        public string name;
        public string surname;
        public string email;
        public int age;
    }
}