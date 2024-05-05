namespace _001_Arithmetic_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int number2 = 2;
            int number3 = number + number2;
            Console.WriteLine($"Sum of{number} and {number2} is {number3}");

            int number4 = 5 + 1;
            Console.WriteLine($"Sum of 5 and 1 is {number4}");
            Console.WriteLine(number4);

            int number5 = 10 - 5;
            Console.WriteLine(number5);

            int number6 = 10 - number5;
            Console.WriteLine(number6);
            int number7 = number6 - number;
            Console.WriteLine(number7);

            Console.WriteLine(5 + number6 + 5 + number);
        }
    }
    //    1.	Variables:
    //•	number: This variable is of type int and is assigned the value 1. It represents a numeric value.
    //•	number2: This variable is also of type int and is assigned the value 2. It represents another numeric value.
    //•	number3: This variable is of type int and is assigned the sum of number and number2.It represents the result of the addition operation between number and number2.
    //•	number4: This variable is of type int and is assigned the value 5 + 1. It represents the result of the addition operation between the literals 5 and 1.
    //•	number5: This variable is of type int and is assigned the value 10 - 5. It represents the result of the subtraction operation between the literals 10 and 5.
    //•	number6: This variable is of type int and is assigned the value 10 - number5.It represents the result of the subtraction operation between the literal 10 and the variable number5.
    //•	number7: This variable is of type int and is assigned the value number6 - number.It represents the result of the subtraction operation between the variable number6 and the variable number.
    //2.	Literals:
    //•	1, 2, 5, 10: These are numeric literals, representing specific values.
    //•	"Sum of", " and ", " is ": These are string literals, representing specific text values used in the Console.WriteLine statements.
    //Variables allow you to store and manipulate data, while literals are fixed values used directly in the code. In this code, variables are used to 
    //    perform arithmetic operations and store the results, while literals are used to display messages in the console output.
}
