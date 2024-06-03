namespace _007_Objects
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

        public string FullName
        {
            get { return $"{surname} {name}"; }
        }

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
        public string Surname { get; set; }
        public string Email { get; set; }

        //private string _email;
        //public string Email
        //{
        //    get { return _email; }
        //    set { _email = value; }
        //}

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    if (char.IsLetter(value[0]))
                        _name = value;
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