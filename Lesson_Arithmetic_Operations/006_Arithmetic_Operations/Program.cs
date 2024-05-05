namespace _006_Arithmetic_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The unary increment operator ++increments its operand by 1.


            // Postfix increment operator
            //The result of x++ is the value of x before the operation, as the following example shows:
            int i = 3;
            Console.WriteLine(i);   // output: 3
            Console.WriteLine(i++); // output: 3
            Console.WriteLine(i);   // output: 4


            // Prefix increment operator
            //The result of++x is the value of x after the operation, as the following example shows:

            double a = 1.5;
            Console.WriteLine(a);   // output: 1.5
            Console.WriteLine(++a); // output: 2.5
            Console.WriteLine(a);   // output: 2.5

            //Decrement operator --

            //Postfix decrement operator
            //The result of x-- is the value of x before the operation, as the following example shows:
            int i1 = 3;
            Console.WriteLine(i1);   // output: 3
            Console.WriteLine(i1--); // output: 3
            Console.WriteLine(i1);   // output: 2

            //Prefix decrement operator
            //The result of--x is the value of x after the operation, as the following example shows:
            double a2 = 1.5;
            Console.WriteLine(a2);   // output: 1.5
            Console.WriteLine(--a2); // output: 0.5
            Console.WriteLine(a2);   // output: 0.5
        }
    }
}
