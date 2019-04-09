using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using BashExtension;

namespace Q15
{
    class Program
    {
        const string filePath = "../hightemp.txt";

        static void Main(string[] args)
        {
            int num = 3;
            Console.WriteLine(GetTailNLinesText(filePath, num));

            // Bash
            $"tail -n {num} {filePath}".WriteBashLine();
        }

        static string GetTailNLinesText(string path, int num)
        {
            IEnumerable<string> f(string p, int n)
            {
                return File.ReadAllLines(p)
                    .TakeLast(n);
            }

            return string.Join("\n", f(path, num));
        }
    }
}
