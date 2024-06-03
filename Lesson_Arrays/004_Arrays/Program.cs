namespace _004_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 4, 3, 2, 1, };
            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers[4]);//[5]
            //numbers[5] = 5;
            int index = Array.IndexOf(numbers, 3);
            Console.WriteLine(index);
            Array.Reverse(numbers);
            Array.Sort(numbers);
            Console.WriteLine(numbers.Rank);
            int[] copy = new int[5];
            Array.Copy(numbers, copy, 5);
            Array.Clear(numbers, 0, numbers.Length);

        }
    }
}
