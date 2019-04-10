using System;
using LogExtension;
using BashExtension;
using System.IO;
using System.Linq;

namespace Q17
{
    class Program
    {
        const string filePath = "../hightemp.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var colNumForDescedingSort = 3;

            // C#
            var cSharpRes = File.ReadAllLines(filePath)
                .OrderByDescending(l => l.Split("\t")[colNumForDescedingSort - 1]);
            cSharpRes.DebugLog("cSharpResult");

            // Bash
            $"sort -k{colNumForDescedingSort}r -t '\t' {filePath}".WriteBashLine();
        }
    }
}
