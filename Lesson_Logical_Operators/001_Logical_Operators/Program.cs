namespace _001_Logical_Operators
{
    //The logical Boolean operators perform logical operations with bool operands.
    //The operators include the unary logical negation (!), binary logical AND (&), OR (|),
    //and exclusive OR (^), and the binary conditional logical AND (&&) and OR (||).
    internal class Program
    {
        static void Main(string[] args)
        {
            bool passed = false;
            Console.WriteLine(!passed);  // output: True
            Console.WriteLine(!true);    // output: False


            bool hasPermission = true;
            bool doesNotHavePermission = !hasPermission;
            Console.WriteLine(doesNotHavePermission);  // Output: False
        }
    }
}
