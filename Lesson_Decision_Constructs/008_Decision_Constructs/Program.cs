namespace _008_Decision_Constructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 17;
            string gender = "male";
            bool isStudent = true;
            bool works = false;

            if (age < 18)
            {
                if (gender == "male")
                {
                    if (isStudent)
                    {
                        Console.WriteLine("You are a young male student.");
                    }
                    else
                    {
                        if (works)
                        {
                            Console.WriteLine("You are a young male student who also works.");
                        }
                        else
                        {
                            Console.WriteLine("You are a young male non-student who does not work.");
                        }
                    }
                }
                else if (gender == "female")
                {
                    if (isStudent)
                    {
                        Console.WriteLine("You are a young female student.");
                    }
                    else
                    {
                        if (works)
                        {
                            Console.WriteLine("You are a young female student who also works.");
                        }
                        else
                        {
                            Console.WriteLine("You are a young female non-student who does not work.");
                        }
                    }
                }
            }
            else
            {
                if (gender == "male")
                {
                    if (isStudent)
                    {
                        Console.WriteLine("You are an adult male student.");
                    }
                    else
                    {
                        if (works)
                        {
                            Console.WriteLine("You are an adult male student who also works.");
                        }
                        else
                        {
                            Console.WriteLine("You are an adult male non-student who does not work.");
                        }
                    }
                }
                else if (gender == "female")
                {
                    if (isStudent)
                    {
                        Console.WriteLine("You are an adult female student.");
                    }
                    else
                    {
                        if (works)
                        {
                            Console.WriteLine("You are an adult female student who also works.");
                        }
                        else
                        {
                            Console.WriteLine("You are an adult female non-student who does not work.");
                        }
                    }
                }
            }
        }
    }
}
}
