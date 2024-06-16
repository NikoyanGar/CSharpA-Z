namespace _002_Operator_Precedence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;// Assignment operators(=, +=, -= etc.)
            x += 5; // x is now 15

            //Conditional operator (?:)
            int a = 10, b = 5;
            int max = (a > b) ? a : b; // max is 10

            // Logical OR(||)
            bool result = false || true; // result is true

            //Logical AND (&&)
            bool result1 = false && true; // result is false

            //Equality and relational operators (==, !=, <, >, <=, >=)
            bool isEqual = (5 == 5); // isEqual is true

            // Additive operators(+, -)
            int sum = 10 + 5; // sum is 15

            //Multiplicative operators (*, /, %)
            int product = 10 * 2; // product is 20

            //Unary operators (!, ~, ++, --, +, -)
            int num = 10;
            int negation = -num; // negation is -10

            //Primary (method calls, array access, etc.)
            int[] numbers = { 1, 2, 3 };
            int firstNumber = numbers[0]; // firstNumber is 1

        }
    }
}
