using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AoC.Day01.Calendar.Day02
{
    public class CardParser
    {
        private static readonly char[] separator = [' '];

        public string Parse(string line)
        {
            string[] parts = line.Split(new char[] { '|' }, StringSplitOptions.TrimEntries);

            IEnumerable<int> winningCards = parts[1]
                .Split(separator)
                .Select(int.Parse);

            return "";
        }
    }
}
