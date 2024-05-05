namespace _002_Working_With_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Concatenation:
            //You can concatenate strings using the + operator or by using string.Concat() method.For example:
            string firstName = "Garik";
            string lastName = "Nikoyan";

            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            Console.WriteLine("-----------------------------------------");

            string fullName1 = string.Concat(firstName, lastName);
            Console.WriteLine(fullName1);
        }
    }
}
