using System.Threading.Tasks;

namespace _008_Bitwise_And_Shift_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag0 = true;
            bool flag1 = false;
            bool flag2 = true;
            bool flag3 = true;
            bool flag4 = false;
            bool flag5 = true;
            bool flag6 = false;
            bool flag7 = true;
            bool flag8 = false;
            bool flag9 = true;

            //bool[] flags = new bool[10] { true, false, true, true, false, true, false, true, false, true };

            if (flag5)
            {
                Console.WriteLine("flag5 is ON");
            }
            int flagBits = 0b_1010010101; // some flags ON (bits 0, 2, 4, 7, 9) // decimal 661
            bool[] individualFlags = new bool[9];


            for (int bitPosition = 0; bitPosition < 9; bitPosition++)
            {
                // Check if the bit at this position is ON (1)

                //🔹 Step 1: (1 << bitPosition)
                // This shifts the binary number 1 to the left by bitPosition places.
                // (1 << 3) == 0b_00001000 // equals 8

                //🔹 Step 2: flagBits & (1 << bitPosition)
                //Performs a bitwise AND between flagBits and the mask.
                //flagBits = 0b_1010010101
                //mask =     0b_0000001000(only bit 3 set)
                //------------------------------ -
                //result(AND) = 0b_0000000000(bit 3 in flagBits is 0)
                //🔹 Step 3: != 0
                //Final check: (flagBits & (1 << bitPosition)) != 0
                bool isSet = (flagBits & (1 << bitPosition)) != 0;
                individualFlags[bitPosition] = isSet;
            }


            // Display results
            for (int bitPosition = 0; bitPosition < 9; bitPosition++)
            {
                Console.WriteLine($"Flag{bitPosition} = {individualFlags[bitPosition]}");
            }
            //Main1();
        }
        static void Main1()
        {
            //Explanation:
            //Initializes a 32 - bit integer with all bits set to 0.
            //This means all 10 boolean flags are OFF(false).


            int flags = 0;
            //Explanation:
            //This section turns specific bits ON using |= (bitwise OR) and bit-shifting.
            // SET: turn ON flags 0, 2, 3, 5, 7, 9

            //1 << 0 → binary 0000000001 → turns ON bit 0,
            //flags |= X means: "set the bit at position X to 1 while leaving others unchanged."
            flags |= 1 << 0;
            flags |= 1 << 2;
            flags |= 1 << 3;
            flags |= 1 << 5;
            flags |= 1 << 7;
            flags |= 1 << 9;

            //Checks whether bit 5 is ON(1):
            //1 << 5 → binary 000100000
            //flags & (1 << 5) keeps only bit 5 — all others become 0
            //If the result is not 0, then flag 5 is ON

            if ((flags & (1 << 5)) != 0)
                Console.WriteLine("flag5 is ON");
            else
                Console.WriteLine("flag5 is OFF");

            //Explanation:
            //Toggles(inverts) bit 3 using XOR (^):
            
            //If bit 3 was 1 → it becomes 0
            
            //If bit 3 was 0 → it becomes 1
            flags ^= 1 << 3;

            // CLEAR: turn OFF flag 7
            flags &= ~(1 << 7);

            // PRINT: all 10 flags
            Console.WriteLine("All 10 flags:");
            for (int i = 0; i < 10; i++)
            {
                bool isOn = (flags & (1 << i)) != 0;
                Console.WriteLine($"flag{i} = {isOn}");
            }
        }
    }
}
