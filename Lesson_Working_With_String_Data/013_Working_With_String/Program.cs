using Microsoft.VisualBasic;
using System;

namespace _013_Working_With_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1: String literals are automatically interned
            string literal1 = "hello";
            string literal2 = "hello";
            Console.WriteLine(object.ReferenceEquals(literal1, literal2)); // Output: True

            // Example 2: Strings created at runtime are not automatically interned
            string runtimeString1 = new string('h', 5); // "hhhhh"
            string runtimeString2 = new string('h', 5); // "hhhhh"
            Console.WriteLine(object.ReferenceEquals(runtimeString1, runtimeString2)); // Output: False

            // Example 3: Interning a runtime string
            string internedRuntimeString1 = string.Intern(runtimeString1);
            string internedRuntimeString2 = string.Intern(runtimeString2);
            Console.WriteLine(object.ReferenceEquals(internedRuntimeString1, internedRuntimeString2)); // Output: True

            // Example 4: Checking if a string is interned
            string nonInternedString = new string('x', 3); // "xxx"
            Console.WriteLine(string.IsInterned(nonInternedString) ?? "not interned"); // Output: "not interned"

            string internedString = string.Intern(nonInternedString);
            Console.WriteLine(string.IsInterned(nonInternedString) ?? "not interned"); // Output: "xxx"

            // Example 5: Benefits of interning - memory optimization
            string repeatedString1 = new string('y', 4); // "yyyy"
            string repeatedString2 = new string('y', 4); // "yyyy"
            Console.WriteLine(object.ReferenceEquals(repeatedString1, repeatedString2)); // Output: False

            string internedRepeatedString1 = string.Intern(repeatedString1);
            string internedRepeatedString2 = string.Intern(repeatedString2);
            Console.WriteLine(object.ReferenceEquals(internedRepeatedString1, internedRepeatedString2)); // Output: True

            // Example 6: Using ReferenceEquals to compare interned and non-interned strings
            string nonInterned = new string('z', 2); // "zz"
            string interned = string.Intern(nonInterned);
            Console.WriteLine(object.ReferenceEquals(nonInterned, interned)); // Output: True

            // Example 7: String literals and runtime strings with the same value
            string literal = "abc";
            string runtime = new string(new[] { 'a', 'b', 'c' });
            Console.WriteLine(object.ReferenceEquals(literal, runtime)); // Output: False

            string internedRuntime = string.Intern(runtime);
            Console.WriteLine(object.ReferenceEquals(literal, internedRuntime)); // Output: True
        }
    }
//string runtimeString1 = new string('e', 7); // "eeeeeee"
//string runtimeString2 = new string('e', 7); // "eeeeeee"

//// Without interning, these are different references
//Console.WriteLine(object.ReferenceEquals(runtimeString1, runtimeString2)); // False

//// Intern the strings
//string interned1 = string.Intern(runtimeString1);
//string interned2 = string.Intern(runtimeString2);

//// Now they share the same reference
//Console.WriteLine(object.ReferenceEquals(interned1, interned2)); // True
//In this case, interning ensures that the runtime-generated strings share
//the same reference, making subsequent comparisons faster.
}
