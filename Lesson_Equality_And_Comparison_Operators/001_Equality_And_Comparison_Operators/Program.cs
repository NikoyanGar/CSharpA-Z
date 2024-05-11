namespace _001_Equality_And_Comparison_Operators
{
    //Equality operator ==
    //The equality operator == returns true if its operands are equal, false otherwise.
    internal class Program
    {
        //Operands of the built-in value types are equal if their values are equal:
        static void Main(string[] args)
        {
            int a = 1 + 2 + 3;
            int b = 6;
            Console.WriteLine(a == b);  // output: True

            char c1 = 'a';
            char c2 = 'A';
            Console.WriteLine(c1 == c2);  // output: False
            Console.WriteLine(c1 == char.ToLower(c2));  // output: True
        }
    }
}

//For the ==, <, >, <=, and >= operators, if any of the operands is not a number (Double.NaN or Single.NaN), the result of operation is false.
//That means that the NaN value is neither greater than, less than, nor equal to any other double (or float) value,
//including NaN. For more information and examples, see the Double.NaN or Single.NaN reference article.