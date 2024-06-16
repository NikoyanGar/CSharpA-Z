﻿namespace _010_Operator_Category_Bitwise_And_Bit_Shift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 10;
            int secondNumber = 20;
            int result;

            result = ~firstNumber;
            Console.WriteLine("~{0} = {1}", firstNumber, result);

            result = firstNumber & secondNumber;
            Console.WriteLine("{0} & {1} = {2}", firstNumber, secondNumber, result);

            result = firstNumber | secondNumber;
            Console.WriteLine("{0} | {1} = {2}", firstNumber, secondNumber, result);

            result = firstNumber ^ secondNumber;
            Console.WriteLine("{0} ^ {1} = {2}", firstNumber, secondNumber, result);

            result = firstNumber << 2;
            Console.WriteLine("{0} << 2 = {1}", firstNumber, result);

            result = firstNumber >> 2;
            Console.WriteLine("{0} >> 2 = {1}", firstNumber, result);
        }
    }
}
