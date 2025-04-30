using static System.Formats.Asn1.AsnWriter;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System;

namespace _012_Working_With_String
{
    // Demonstrating String.Intern() and String.IsInterned()
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: String assignment and comparison
            string a = "hello world";
            string b = a;
            a = "hello";

            Console.WriteLine($"a: {a}, b: {b}");
            Console.WriteLine($"a == b: {a == b}");
            Console.WriteLine($"ReferenceEquals(a, b): {object.ReferenceEquals(a, b)}");

            // Example 2: String concatenation and comparison
            Console.WriteLine($"(a + \" world\") == b: {(a + " world") == b}");

            // Example 3: String interning
            string hello = "hello";
            string helloWorld = "hello world";
            string helloWorld2 = hello + " world";

            Console.WriteLine($"helloWorld: {helloWorld}, helloWorld2: {helloWorld2}");
            Console.WriteLine($"helloWorld == helloWorld2: {helloWorld == helloWorld2}");
            Console.WriteLine($"ReferenceEquals(helloWorld, helloWorld2): {object.ReferenceEquals(helloWorld, helloWorld2)}");

            // Checking if strings are interned
            string? internedStringRef = string.IsInterned(helloWorld);
            string? internedStringRef1 = string.IsInterned(helloWorld2);
            Console.WriteLine($"ReferenceEquals(internedStringRef, internedStringRef1): {object.ReferenceEquals(internedStringRef, internedStringRef1)}");

            string? helloWorld3 = Console.ReadLine();
            string? internedStringRef2 = string.IsInterned(helloWorld3); //"hello world" is interned
            if (internedStringRef2 != null)
            {
                Console.WriteLine("text from console interned");
            }
            else 
            {
                Console.WriteLine("in is null because not exists CLR intern pool");
            }

            // Interning strings explicitly
            //string ref1 = string.Intern(helloWorld);
            //string ref2 = string.Intern(helloWorld2);

            //Console.WriteLine($"ReferenceEquals(ref1, ref2) after interning: {object.ReferenceEquals(ref1, ref2)}");
        }
    }
    //The intern pool is a table maintained by the Common Language Runtime(CLR) in .NET
    //to store a single instance of each unique string literal declared in a program.
    //This process is called string interning.
    //The purpose of the intern pool is to optimize memory usage and improve performance
    //by ensuring that identical string literals share the same memory reference.
    //How Strings Become Part of the Intern Pool:

    //1.	String Literals: When a string literal (e.g., "hello world") is declared
    //in the code, the CLR automatically adds it to the intern pool.
    //Any subsequent use of the same literal will reference the same memory location.
    //if needed.  
    //Benefits of String Interning:  
    //1.	Memory Optimization: By storing only one instance of each unique string,  
    //the intern pool reduces memory usage, especially in applications with many identical strings.  
    //2.	Performance Improvement: Comparing interned strings is faster because it involves  
    //comparing memory references rather than the actual string content.  
    //Limitations and Considerations:  
    //1.	Memory Overhead: The intern pool itself consumes memory, so excessive interning  
    //of strings may lead to increased memory usage.  
    //2.	Explicit Interning: While string literals are automatically interned,  
    //you need to explicitly intern runtime strings, which may add complexity to your code.  
    //3.	Garbage Collection: Interned strings are not garbage collected until the application  
    //domain is unloaded, which may lead to memory retention issues in long-running applications.

}
