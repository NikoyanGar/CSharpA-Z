namespace _001_Basic_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "Some text";
            char myChar = 'A';

            bool myBool = true;

            int myInt = 10;
            float myFloat = 3.14f;
            double myDouble = 2.71828;
            decimal myDecimail = 2.71828m;
            ///
            byte myByte = 255;
            sbyte mySByte = -128;

            short myShort = -32768;
            ushort myUShort = 65535;

            long myLong = 9223372036854775807;
            ulong myULong = 18446744073709551615;

            // Output the values
            Console.WriteLine("Integer: " + myInt);
            Console.WriteLine("Float: " + myFloat);
            Console.WriteLine("Double: " + myDouble);
            Console.WriteLine("Decimal: " + myDecimail);
            Console.WriteLine("Character: " + myChar);
            Console.WriteLine("Boolean: " + myBool);
            Console.WriteLine("String: " + myString);
            Console.WriteLine("Byte: " + myByte);
            Console.WriteLine("Signed Byte: " + mySByte);
            Console.WriteLine("Short: " + myShort);
            Console.WriteLine("Unsigned Short: " + myUShort);
            Console.WriteLine("Long: " + myLong);
            Console.WriteLine("Unsigned Long: " + myULong);
        }
    }
}
