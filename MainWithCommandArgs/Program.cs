namespace MainWithCommandArgs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Check if command-line arguments were provided
            if (args.Length > 0)
            {
                // Process the command-line arguments
                foreach (string arg in args)
                {
                    Console.WriteLine("Command-line argument: " + arg);
                }
            }
            else
            {
                Console.WriteLine("No command-line arguments provided.");
            }
        }
    }
}
//dotnet new console
//dotnet build
//dotnet run -- 3

//Menu/Debug/Properties
