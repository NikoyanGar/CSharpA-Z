﻿namespace _008_Working_With_String
{
    //You can see the memory of the object by using Memory window in VS.
    //Just go to Debug->Windows->Memory and open one of the four available or use the shortcut Ctrl+Alt+M, 1-4.
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "SomeText";
            string s2 = "SomeText";
            string s3 = s2;
            //s2 = "NewText";

            if (s1.Equals(s2))
            {

            }

            if (ReferenceEquals(s1, s3))
            {

            }

            var someText = Console.ReadLine();
            if (s1.Equals(someText))
            {

            }

            if (ReferenceEquals(s1, someText))
            {

            }

            someText = string.Intern(someText);

            if (ReferenceEquals(s1, someText))
            {

            }

            string res = "";
            res += "a1";
            res += "a2";
            res += "a3";
            res += "a4";

            //Intern Table
            //a1
            //a2
            //a1a2
            //a3
            //a1a2a3
            //a4
            //a1a2a3a4
        }
    }
}
