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
            var colNumForDescendingSort = 3;

            // C#
            var cSharpRes = File.ReadAllLines(filePath)
                .OrderByDescending(l => l.Split("\t")[colNumForDescendingSort - 1]);
            cSharpRes.DebugLog("cSharpResult");

            // Bash
            $"sort -k{colNumForDescendingSort}r -t '\t' {filePath}".WriteBashLine();
        }
    }
}
