namespace _002_Data_Type_Conversions
{
    public class Program
    {
        //(int) cast expression
        static void Main(string[] args)
        {
            double numDouble = 1.23;

            // Explicit casting
            int numInt = (int)numDouble;

            // Value before conversion
            Console.WriteLine("Original double Value: " + numDouble);

            // Value before conversion
            Console.WriteLine("Converted int Value: " + numInt);
            Console.ReadLine();
        }
    }
}
