using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using BashExtension;

namespace Q12
{
    class Program
    {
        const string filePath = "../hightemp.txt";

        static void Main(string[] args)
        {
            var allLines = File.ReadAllLines(filePath);

            var col1Contents = new List<string>();
            var col2Contents = new List<string>();

            foreach (var line in allLines)
            {
                var splittedLine = Regex.Split(line, @"\t");
                col1Contents.Add(splittedLine.Count() >= 1 ? splittedLine[0] : string.Empty);
                col1Contents.Add(splittedLine.Count() >= 2 ? splittedLine[1] : string.Empty);
            }

            File.WriteAllText("../col1.txt", string.Join('\n', col1Contents));
            File.WriteAllText("../col2.txt", string.Join('\n', col2Contents));

            $"cat {filePath} | cut -f1".WriteBashLine();
            $"cat {filePath} | cut -f2".WriteBashLine();
        }
    }
}
