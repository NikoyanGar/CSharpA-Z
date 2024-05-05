namespace _010_Basic_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool myBool = true;

            int myInt = 10;
            float myFloat = 3.14f;
            double myDouble = 2.71828;
            decimal myDecimail = 2.71828m;

            string str = myBool.ToString();
            string str2 = myInt.ToString();
            string str3 = myFloat.ToString();
            string str4 = myDouble.ToString();
            string str5 = myDecimail.ToString();
            Console.WriteLine(str);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);
            Console.WriteLine(str5);

        }
    }
}
