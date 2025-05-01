using System.Globalization;

namespace _009_Data_Type_Conversions
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("NumberStyles Examples:\n");

            // None - only digits allowed
            Parse("123", NumberStyles.None, "Only digits allowed");

            // AllowLeadingWhite
            Parse("   123", NumberStyles.AllowLeadingWhite, "Allows leading whitespace");

            // AllowTrailingWhite
            Parse("123   ", NumberStyles.AllowTrailingWhite, "Allows trailing whitespace");

            // AllowLeadingSign
            Parse("-123", NumberStyles.AllowLeadingSign, "Allows leading sign (+ or -)");

            // AllowTrailingSign
            Parse("123-", NumberStyles.AllowTrailingSign, "Allows sign at the end");

            // AllowParentheses
            Parse("(123)", NumberStyles.AllowParentheses, "Allows parentheses for negative numbers");

            // AllowThousands
            Parse("1,234", NumberStyles.AllowThousands, "Allows thousands separator (e.g. 1,234)");

            // AllowCurrencySymbol
            Parse("$1234", NumberStyles.AllowCurrencySymbol, "Allows currency symbol (e.g. $)");

            // AllowHexSpecifier
            Parse("1A", NumberStyles.AllowHexSpecifier, "Parses as hexadecimal (e.g. 1A = 26)");

            // Composite style: Integer
            Parse("   -456   ", NumberStyles.Integer, "Composite: whitespace + sign");

            // Composite style: Currency
            Parse("($1,000)", NumberStyles.Currency, "Composite: parentheses + thousands + currency");

            // Composite style: Any
            Parse("   -1,234  ", NumberStyles.Any, "Allows almost everything (except hex)");
        }

        static void Parse(string input, NumberStyles style, string explanation)
        {
            try
            {
                int result = int.Parse(input, style, CultureInfo.GetCultureInfo("en-US"));
                Console.WriteLine($"'{input}' parsed as {result} using [{style}] — {explanation}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"'{input}' failed: {ex.Message} — [{style}] — {explanation}");
            }
        }
    }
}
