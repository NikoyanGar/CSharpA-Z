namespace _004_Basic_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 255;
            string binaryRepresentation = Convert.ToString(myByte, 2);
            Console.WriteLine(binaryRepresentation);


            sbyte mySByte = 127;
            string binaryRepresentation1 = Convert.ToString(mySByte, 2);
            Console.WriteLine(binaryRepresentation1);

            sbyte mySByte1 = -128;
            string binaryRepresentation2 = Convert.ToString(mySByte1, 2);
            Console.WriteLine(binaryRepresentation2);
        }
    }
}
