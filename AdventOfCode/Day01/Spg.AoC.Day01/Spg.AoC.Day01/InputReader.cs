using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AoC.Day01
{
    public class InputReader
    {
        public List<string> ReadFile(string fileName)
        {
            StreamReader? sr = null!;
            List<string> vaueList = new();
            try
            {
                sr = new StreamReader(fileName);
                string? line = sr.ReadLine();
                while (line is  not null)
                {
                    if (line is not null)
                    {
                        vaueList.Add(line);
                        line = sr.ReadLine();
                    }
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("404-File not found! No advent for you! :(");
            }
            catch (IOException ex)
            {
                Console.WriteLine("404-File not found! No advent for you! :(");
            }
            finally
            { 
                sr?.Close(); 
            }
            return vaueList;
        }
    }
}
