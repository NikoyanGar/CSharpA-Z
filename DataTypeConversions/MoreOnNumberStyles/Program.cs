using System.Globalization;

namespace MoreOnNumberStyles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.NumberStyles.None: This style indicates that no additional number styles are applied.
            //It is the default style if no other styles are specified. For example:
            int number = int.Parse("123", NumberStyles.None);

            // 2.NumberStyles.AllowLeadingWhite: This style allows leading white spaces before the number.For example:
            int number1 = int.Parse("   123", NumberStyles.AllowLeadingWhite);

            // The string "   123" is parsed as an integer, ignoring the leading white spaces.
            //3.NumberStyles.AllowTrailingWhite: This style allows trailing white spaces after the number.For example:
            int number3 = int.Parse("123   ", NumberStyles.AllowTrailingWhite);

            //  The string "123   " is parsed as an integer, ignoring the trailing white spaces.
            //4.NumberStyles.AllowLeadingSign: This style allows a leading positive or negative sign before the number. For example:
            int number4 = int.Parse("-123", NumberStyles.AllowLeadingSign);

            //The string "123.45" is parsed as a decimal number.
            //5.NumberStyles.AllowThousands: This style allows the use of thousands separators in the number. For example:
            decimal number5 = decimal.Parse("123.45", NumberStyles.AllowDecimalPoint);

            // The string "1,234,567" is parsed as an integer with thousands separators.
            //6.NumberStyles.AllowExponent: This style allows the use of exponential notation in the number. For example:
            int number6 = int.Parse("1,234,567", NumberStyles.AllowThousands);

        }
    }
}
