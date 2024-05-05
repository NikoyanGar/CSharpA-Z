namespace _002_Basic_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Range of bool: {0} to {1}", bool.FalseString, bool.TrueString);

            Console.WriteLine("Range of int: {0} to {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("Range of float: {0} to {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("Range of double: {0} to {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("Range of decimal: {0} to {1}", decimal.MinValue, decimal.MaxValue);

            Console.WriteLine("Range of byte: {0} to {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Range of sbyte: {0} to {1}", sbyte.MinValue, sbyte.MaxValue);

            Console.WriteLine("Range of short: {0} to {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("Range of ushort: {0} to {1}", ushort.MinValue, ushort.MaxValue);

            Console.WriteLine("Range of long: {0} to {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("Range of ulong: {0} to {1}", ulong.MinValue, ulong.MaxValue);

            Console.WriteLine("Range of char: {0} to {1}", char.MinValue, char.MaxValue);

        }
    }
}
