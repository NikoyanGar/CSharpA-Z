namespace _005_Data_Type_Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create string variable
            string str = "99.99";
            Console.WriteLine("Original string value: " + str);

            // convert string to double
            Double newDouble = Convert.ToDouble(str);
            Console.WriteLine("Converted Double value: " + newDouble);

            // create double variable
            double num = 88.9;
            Console.WriteLine("Original double value: " + num);

            // converting double to string 
            string newString = Convert.ToString(num);
            Console.WriteLine("Converted string value: " + newString);

            Console.ReadLine();
        }
    }
}
