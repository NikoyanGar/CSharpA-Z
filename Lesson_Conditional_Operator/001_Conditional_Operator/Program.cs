namespace _001_Conditional_Operator
{
    //The conditional operator ?:, also known as the ternary conditional operator,
    //evaluates a Boolean expression and returns the result of one of the two expressions,
    //depending on whether the Boolean expression evaluates to true or false, as the following example shows
    internal class Program
    {
        static void Main(string[] args)
        {
            double tempInCelsius = 20.5;
            //condition ? consequent : alternative
            string tempComfortable = tempInCelsius < 20.0 ? "Cold." : "Perfect!";
            Console.WriteLine(tempComfortable);
        }
    }
}
