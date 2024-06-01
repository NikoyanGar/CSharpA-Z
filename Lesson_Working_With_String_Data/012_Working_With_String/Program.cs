namespace _012_Working_With_String
{
    //String.Intern() и String.IsInterned()
    class Program
    {
        static void Main(string[] args)
        {
            string a = "hello world";
            string b = a;
            a = "hello";
            Console.WriteLine("a:{0}, b:{1}", a, b);
            Console.WriteLine($"a==b{a == b}");
            Console.WriteLine(object.ReferenceEquals(a, b));


            Console.WriteLine($"(a + \" world\") == b is {(a + " world") == b}");


            string hello = "hello";
            string helloWorld = "hello world";
            string helloWorld2 = hello + " world";//"hello world"

            Console.WriteLine("helloWorld:{0}, helloWorld2:{1}  helloWorld == helloWorld2:{2}, ReferenceEquals:{3}", helloWorld, helloWorld2,
                helloWorld == helloWorld2, object.ReferenceEquals(helloWorld, helloWorld2));


            string ref1 = String.Intern(helloWorld);
            string ref2 = String.Intern(helloWorld2);

            Console.WriteLine($"Intern ReferenceEquals:{object.ReferenceEquals(ref1, ref2)}");
        }
    }
}
