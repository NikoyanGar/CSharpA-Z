namespace WorkingWithFlags
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    //Combine multiple flags using bitwise OR (|)
        //    FileAccess myAccess = FileAccess.Read | FileAccess.Write;
        //    Console.WriteLine(myAccess);

        //    // Check if a flag is set using bitwise AND (&)
        //    if ((myAccess & FileAccess.Write) != 0)
        //    {
        //        Console.WriteLine("Write access is granted.");
        //    }

        //    // Check if multiple flags are set
        //    if ((myAccess & (FileAccess.Read | FileAccess.Write)) == (FileAccess.Read | FileAccess.Write))
        //    {
        //        Console.WriteLine("Both read and write access are granted.");
        //    }

        //    // Toggle a flag using bitwise XOR (^)
        //    myAccess ^= FileAccess.Write;

        //    // Check if a flag is no longer set
        //    if ((myAccess & FileAccess.Write) == 0)
        //    {
        //        Console.WriteLine("Write access is revoked.");
        //    }
        //}
        static void Main(string[] args)
        {
            FileAccess myAccess = FileAccess.Read | FileAccess.Write;
            Console.WriteLine(myAccess);
            // Using helper methods to work with flags
            Console.WriteLine(FlagsHelper<FileAccess>.IsSet(myAccess, FileAccess.Write)); // true
            Console.WriteLine(FlagsHelper<FileAccess>.IsSet(myAccess, FileAccess.Execute)); // false

            myAccess = FlagsHelper<FileAccess>.Unset(myAccess, FileAccess.Write);
            Console.WriteLine(myAccess); // Read

            myAccess = FlagsHelper<FileAccess>.Set(myAccess, FileAccess.Execute);
            Console.WriteLine(myAccess); // Read, Execute
        }
    }
}
