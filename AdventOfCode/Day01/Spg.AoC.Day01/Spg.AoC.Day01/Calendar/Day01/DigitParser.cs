using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AoC.Day01.Calendar.Day01
{
    public class DigitParser
    {
        public int Sum { get; private set; }

        public string Parse(string line)
        {
            var array = line
                .ToArray()
                .Where(char.IsDigit);

            string first = array
                .FirstOrDefault()
                .ToString();
            string? last = array
                .LastOrDefault()
                .ToString()
                    ?? first;

            string result = $"{first}{last}";

            Sum = Sum + int.Parse(result);

            return result;
        }
    }
}
