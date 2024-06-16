namespace _005_Operator_Category_Arithmetic
{
    //+	Addition Operator	6 + 3 evaluates to 9
    //-	Subtraction Operator	10 - 6 evaluates to 4
    //* Multiplication Operator	4 * 2 evaluates to 8
    //	Division Operator	10 / 5 evaluates to 2
    //%	Modulo Operator (Remainder)	16 % 3 evaluates to 1
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = 14.40, secondNumber = 4.60, result;
            int num1 = 26, num2 = 4, rem;

            // Addition operator
            result = firstNumber + secondNumber;
            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);

            // Subtraction operator
            result = firstNumber - secondNumber;
            Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, result);

            // Multiplication operator
            result = firstNumber * secondNumber;
            Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, result);

            // Division operator
            result = firstNumber / secondNumber;
            Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, result);

            // Modulo operator
            rem = num1 % num2;
            Console.WriteLine("{0} % {1} = {2}", num1, num2, rem);
        }
    }
}
