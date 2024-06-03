namespace _001_Arrays
{
    //Lesson Outline:
    //1. Introduction to Arrays
    //Definition: Arrays are a collection of variables of the same type
    //stored in a contiguous memory location.

    //Use: They are used to store multiple values in a single variable,
    //instead of declaring separate variables for each value
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

            Console.WriteLine(array.GetValue(0));
            Console.WriteLine(array.GetValue(1));
            Console.WriteLine(array.GetValue(2));
            Console.WriteLine(array.GetValue(3));
            Console.WriteLine(array.GetValue(4));
        }
    }
}
