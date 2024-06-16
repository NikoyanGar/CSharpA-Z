namespace _008_Operator_Category_Unary
{
    //+	Unary Plus	Leaves the sign of operand as it is
    //-	Unary Minus Inverts the sign of operand
    //++	Increment Increment value by 1
    //--	Decrement Decrement value by 1
    //!	Logical Negation(Not)  Inverts the value of a boolean
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10, result;
            bool flag = true;

            result = +number;
            Console.WriteLine("+number = " + result);

            result = -number;
            Console.WriteLine("-number = " + result);

            result = ++number;
            Console.WriteLine("++number = " + result);

            result = --number;
            Console.WriteLine("--number = " + result);

            Console.WriteLine("!flag = " + (!flag));
        }
    }
}
