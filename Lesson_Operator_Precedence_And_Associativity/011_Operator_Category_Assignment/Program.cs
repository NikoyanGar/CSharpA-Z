namespace _011_Operator_Category_Assignment
{
    //Compound Assignment
    // +=	Addition Assignment	x += 5	x = x + 5
    // -=	Subtraction Assignment  x -= 5	x = x - 5
    // *=	Multiplication Assignment   x *= 5	x = x* 5
    // /=	Division Assignment x /= 5	x = x / 5
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            number += 5;
            Console.WriteLine(number);

            number -= 3;
            Console.WriteLine(number);

            number *= 2;
            Console.WriteLine(number);

            number /= 3;
            Console.WriteLine(number);

            number %= 3;
            Console.WriteLine(number);

            number &= 10;
            Console.WriteLine(number);

            number |= 14;
            Console.WriteLine(number);

            number ^= 12;
            Console.WriteLine(number);

            number <<= 2;
            Console.WriteLine(number);

            number >>= 3;
            Console.WriteLine(number);
        }
    }
}
