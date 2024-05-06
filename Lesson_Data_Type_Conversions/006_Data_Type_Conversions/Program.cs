namespace _006_Data_Type_Conversions
{
    internal class Program
    {
        //Note: In C#, the integer value 0 is considered False and all other values are considered True.
        static void Main(string[] args)
        {
            // create int variables
            int num1 = 0;
            int num2 = 1;

            // convert int to Boolean
            Boolean bool1 = Convert.ToBoolean(num1);
            Boolean bool2 = Convert.ToBoolean(num2);

            Console.WriteLine("Boolean value of 0 is: " + bool1);
            Console.WriteLine("Boolean value of 1 is: " + bool2);

            Console.ReadLine();
        }
    }
}
