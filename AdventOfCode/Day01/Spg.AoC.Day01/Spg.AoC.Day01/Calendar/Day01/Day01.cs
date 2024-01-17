using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AoC.Day01.Calendar.Day01
{
    public class Day01
    {
        public int Run()
        {
            InputReader reader = new();
            List<string> result = reader.ReadFile("input.txt");

            DigitParser digitParser = new DigitParser();

            int i = 0;
            foreach (string s in result)
            {
                i++;
                Console.WriteLine($"{i.ToString().PadLeft(4, '0')} - {s}");
                string x = digitParser.Parse(s);
                Console.WriteLine(x);
            }
            Console.WriteLine(digitParser.Sum);
            return digitParser.Sum;
        }
    }
}
