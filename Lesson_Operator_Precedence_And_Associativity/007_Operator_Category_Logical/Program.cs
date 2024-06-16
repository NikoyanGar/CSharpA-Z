namespace _007_Operator_Category_Logical
{
    internal class Program
    {
        //Operand 1	Operand 2	OR (||)	AND (&&)
        //true	true	true	true
        //true	false	true	false
        //false	true	true	false
        //false	false	false	false
        static void Main(string[] args)
        {
            bool result;
            int firstNumber = 10, secondNumber = 20;

            // OR operator
            result = (firstNumber == secondNumber) || (firstNumber > 5);
            Console.WriteLine(result);

            // AND operator
            result = (firstNumber == secondNumber) && (firstNumber > 5);
            Console.WriteLine(result);
        }
    }
}
