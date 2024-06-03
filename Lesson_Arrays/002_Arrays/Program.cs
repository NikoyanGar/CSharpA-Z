namespace _002_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array array = Array.CreateInstance(typeof(int), 5);

            array.SetValue(1, 0);
            array.SetValue(2, 1);
            array.SetValue(3, 2);
            array.SetValue(4, 3);
            array.SetValue(5, 4);
            //Array.Clear(array);
            //Array.Clear(array, 0, 2);
            Array.Reverse(array);
            Array.Reverse(array, 0, 2);
            Array.Sort(array);
            Array.IndexOf(array, 1);
            Console.WriteLine(Array.MaxLength);
            Console.WriteLine(array.Length);
            Console.WriteLine(array.LongLength);
            Console.WriteLine(array.IsFixedSize);
            Console.WriteLine(array.Rank);
            Console.WriteLine(array.IsReadOnly);
            Console.WriteLine(array.ToString());

        }
    }
}
