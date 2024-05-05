namespace _003_Working_With_String
{
    //String Interpolation:
    //You can use string interpolation to embed expressions within strings.This is done by prefixing a string with the $ symbol and placing expressions within curly braces {}. For example:
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Garik";
            string message = $"Hello, {name}!";
            Console.WriteLine(message);

            int age = 30;
            string profession = "SoftWare engineer";
            string programmingLanguage = "C#";
            string message1 = $" Age: {age}, profession: {profession}, Language: {programmingLanguage}";
            Console.WriteLine(message1);
        }
    }
}
