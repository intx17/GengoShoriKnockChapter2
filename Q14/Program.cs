using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using BashExtension;

namespace Q14
{
    class Program
    {
        const string filePath = "../hightemp.txt";

        static void Main(string[] args)
        {
            int count = 2;
            Console.WriteLine(GetHeadNLinesText(filePath, count));

            // Bash
            $"head -n {count} {filePath}".WriteBashLine();
        }

        static string GetHeadNLinesText(string textFilePath, int n)
        {
            return string.Join("\n", GetHeadNLines(textFilePath, n));
        }

        static IEnumerable<string> GetHeadNLines(string textFilePath, int n)
        {
            using (var sr = new StreamReader(filePath, Encoding.Default))
            {
                foreach (var i in Enumerable.Range(1, n))
                {
                    yield return sr.ReadLine();
                }
            }
        }
    }
}
