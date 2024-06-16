namespace _006_Operator_Category_Relational
{
    //==	Equal to	6 == 4 evaluates to false
    //>	Greater than    3 > -1 evaluates to true
    //<	Less than   5 < 3 evaluates to false
    //>=	Greater than or equal to	4 >= 4 evaluates to true
    //<=	Less than or equal to	5 <= 3 evaluates to false
    //!=	Not equal to	10 != 2 evaluates to true
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int firstNumber = 10, secondNumber = 20;

            result = (firstNumber == secondNumber);
            Console.WriteLine("{0} == {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber > secondNumber);
            Console.WriteLine("{0} > {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber < secondNumber);
            Console.WriteLine("{0} < {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber >= secondNumber);
            Console.WriteLine("{0} >= {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber <= secondNumber);
            Console.WriteLine("{0} <= {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber != secondNumber);
            Console.WriteLine("{0} != {1} returns {2}", firstNumber, secondNumber, result);
        }
    }
}
