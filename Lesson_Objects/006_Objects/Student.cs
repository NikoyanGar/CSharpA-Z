namespace _006_Objects
{
    class Student
    {
        public Student(string email)
        {
            this.email = email;
        }

        public string name;
        public string surname;
        public readonly string email;

        private byte age;
        public byte Age
        {
            get { return age; }
            set
            {
                if (value < 12 || value > 50)
                    age = 0;
                else
                    age = value;
            }
        }

        //public byte get_Age()
        //{
        //    return age;
        //}

        //public void set_Age(byte value)
        //{
        //    if (value < 12 || value > 50)
        //        age = 0;
        //    else
        //        age = value;
        //}
    }

}