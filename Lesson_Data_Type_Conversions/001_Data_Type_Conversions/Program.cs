namespace _001_Data_Type_Conversions
{
    //Implicit Type Conversion
    //Automatic ,Compatible types, small to big
    //https://www.bytehide.com/blog/csharp-implicit-conversion
    // Hence, there is no loss of data during the conversion
    internal class Program
    {
        static void Main(string[] args)
        {
            int numInt = 500;
            Type n = numInt.GetType();
            double numDouble = numInt;
            Type n1 = numDouble.GetType();

            Console.WriteLine("numInt value: " + numInt);
            Console.WriteLine("numInt Type: " + n);
            Console.WriteLine("numDouble value: " + numDouble);
            Console.WriteLine("numDouble Type: " + n1);
            Console.ReadLine();
        }
    }
}
