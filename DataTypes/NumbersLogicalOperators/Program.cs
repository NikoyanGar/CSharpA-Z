namespace NumbersLogicalOperators
{
    //string binary = Convert.ToString(number, 2);
    internal class Program
    {
        static void Main(string[] args)
        {
            //& logical Multiply
            int x1 = 2; //010
            int y1 = 5; //101
            Console.WriteLine(x1 & y1); // print 0

            int x2 = 4; //100
            int y2 = 5; //101
            Console.WriteLine(x2 & y2); // print 4

            //| (logical addition)
            int x3 = 2; //010
            int y3 = 5; //101
            Console.WriteLine(x3 | y3); // print 7 - 111
            int x4 = 4; //100
            int y4 = 5; //101
            Console.WriteLine(x4 | y4); // print 5 - 101

            //^ (logical checking OR)

            int x = 45; // The value to be encrypted - in binary form 101101
            int key = 102; // Let this be the key - in binary form 1100110

            int encrypt = x ^ key; // The result will be the number 1001011 or 75
            Console.WriteLine($"Encrypted number: {encrypt}");

            int decrypt = encrypt ^ key; // The result will be the original number 45
            Console.WriteLine($"Decrypted number: {decrypt}");


            //~(logical negation or inversion)
            //Another bitwise operation that inverts all the bits: if the bit value is 1,it becomes 0, and vice versa.
            int x5 = 12;                // 00001100
            Console.WriteLine(~x5);      // 11110011   or -13
        }
    }
}
