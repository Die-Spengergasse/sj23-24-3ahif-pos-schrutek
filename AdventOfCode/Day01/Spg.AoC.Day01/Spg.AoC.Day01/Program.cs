using Spg.AoC.Day01.Calendar.Day01;
using Spg.AoC.Day01.Calendar.Day02;
using System.Runtime.CompilerServices;

//Day01 day01 = new Day01();
//int result01 = day01.Run();

//Day02 day02 = new Day02();
//int result02 = day02.Run();

Func<string, int> result = (filename) =>
{
    int sum = 0;

    StreamReader? sr = new StreamReader(filename);

    string? line = sr.ReadLine();
    while (line is not null)
    {
        line = sr.ReadLine();
        if (line is not null)
        {
            Func<string, int> result = (line) =>
            {
                IEnumerable<char> array = line
                    .ToArray()
                    .Where(char.IsDigit);
                string first = array
                    .FirstOrDefault()
                    .ToString();
                string? last = array
                    .LastOrDefault()
                    .ToString()
                        ?? first;
                return int.Parse($"{first}{last}");
            };
            sum = sum + result(line);
        }
    }
    sr?.Close();
    return sum;
};
Console.WriteLine(result("input_01.txt"));
