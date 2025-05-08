namespace _009_Bitwise_And_Shift_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Turn ON flags: 0, 2, 3, 5, 7, 9  
            FeatureFlags flags = FeatureFlags.Flag0 | FeatureFlags.Flag2 | FeatureFlags.Flag3 |
                                 FeatureFlags.Flag5 | FeatureFlags.Flag7 | FeatureFlags.Flag9;

            // CHECK: Is Flag5 set?  
            if (flags.HasFlag(FeatureFlags.Flag5))
                Console.WriteLine("Flag5 is ON");
            else
                Console.WriteLine("Flag5 is OFF");

            // TOGGLE: Flag3 (turn off if on, turn on if off)  
            flags = flags.ToggleFlag(FeatureFlags.Flag3);

            // CLEAR: Flag7  
            flags = flags.ClearFlag(FeatureFlags.Flag7);

            // PRINT all flags  
            Console.WriteLine("All flags:");
            for (int i = 0; i <= 9; i++)
            {
                FeatureFlags currentFlag = (FeatureFlags)(1 << i);
                bool isOn = flags.HasFlag(currentFlag);
                Console.WriteLine($"Flag{i} = {isOn}");
            }
        }
    }
}
