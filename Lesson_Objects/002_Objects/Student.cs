namespace _002_Objects
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

        //public Student(string name)
        //{
        //    if (!string.IsNullOrEmpty(name))
        //        if (char.IsLetter(name[0]))
        //            this.name = name;
        //}

        public Student(string name, string surname)
            : this(name)
        {
            //this.name = name;
            this.surname = surname;
        }

        public Student(string name, string surname, int age)
            : this(name, surname)
        {
            this.age = age;
        }

        public string name;
        public string surname;
        public int age;
    }
}