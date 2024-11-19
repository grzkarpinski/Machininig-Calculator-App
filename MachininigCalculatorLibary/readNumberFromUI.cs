using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachininigCalculatorLibary
{
    public class ReadNumberFromUI
    {
        public static int ReadIntNumber(string input)
        {
            if (int.TryParse(input, out int intNumber))
            {
                return intNumber;
            }
            else
            {
                throw new Exception($"Input '{input}' is not a valid integer number");
            }
        }

        public static double ReadDoubleNumber(string input)
        {
            if (double.TryParse(input, out double doubleNumber))
            {
                return doubleNumber;
            }
            else
            {
                throw new Exception($"Input '{input}' is not a valid double number");
            }
        }
    }
}
