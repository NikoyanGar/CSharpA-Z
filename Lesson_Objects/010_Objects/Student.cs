namespace _010_Objects
{
    class Student
    {
        public string surname;
        public string email;
        public string name;
        public byte age;

        public string Fullname
        {
            get { return $"{surname} {name}"; }
        }

        //public string GetFullname()
        //{
        //    return $"{surname} {name}";
        //}

        public int Test { get; private set; }

        #region Object Override

        public override string ToString()
        {
            return $"Name: {name}, Surname: {surname}, Email: {email}, Age: {age}, Fullname: {Fullname}, Test: {Test}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Student other = (Student)obj;
            return surname == other.surname &&
                   email == other.email &&
                   name == other.name &&
                   age == other.age &&
                   Fullname == other.Fullname &&
                   Test == other.Test;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(surname, email, name, age, Fullname, Test);
        }

        #endregion
    }

}