namespace _001_Implicitly_Typed_Local_Variables
{
    //https://www.geeksforgeeks.org/c-sharp-implicitly-typed-local-variables-var/
    //The var keyword may be used in the following contexts:
    //On local variables (variables declared at method scope),
    //in a for initialization statement,---------
    //in a foreach initialization statement,-----------
    //and in a using statement.-----------
    internal class Program
    {
        static void Main(string[] args)
        {
            // i is compiled as an int
            var i = 5;

            // s is compiled as a string
            var s = "Hello";

            var d = 5.12;
            //var d = 5.12m;
            //var d = 5.12d;
            //var d = 5.12f;
            var x = 1 / 2;
            //var x = 1 / 2.0;
        }
    }
}
