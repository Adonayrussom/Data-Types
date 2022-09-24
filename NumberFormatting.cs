using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sess02_DataTypes
{
    /// <summary>
    /// C# program demonstrating various ways of formatting numeric output
    /// </summary>
    public class NumberFormatting
    {
        static void Main(string[] args)
        {
            int num2Format = 885500;//NB: using float raises exceptions for decimal & hex formatting.

            Console.WriteLine($"Original number is : {num2Format}");
            Console.WriteLine($"Number formatted as currency(C or c) is: {num2Format:c}");
            Console.WriteLine($"Number formatted as decimal(D or d) is: {num2Format:d}");
            Console.WriteLine($"Number formatted as exponential/scientific(E or e) is: {num2Format:e}");
            Console.WriteLine($"Number formatted as fixed point(F or f) is: {num2Format:f}");
            Console.WriteLine($"Number formatted as a number(N or n) is: {num2Format:n}");
            Console.WriteLine($"Number formatted as hexadecimal(X or x) is: {num2Format:x}");
        }
    }
}
