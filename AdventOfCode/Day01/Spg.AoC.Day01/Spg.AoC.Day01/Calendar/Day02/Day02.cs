using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AoC.Day01.Calendar.Day02
{
    public class Day02
    {
        public int Run()
        {
            InputReader reader = new();
            List<string> result = reader.ReadFile("input_02.txt");

            CardParser parser = new CardParser();
            parser.Parse(result.First());

            return 0;
        }
    }
}
