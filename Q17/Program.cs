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
            const int colNumUsedForSortingByDesc = 1;

            // C#
            var cSharpRes = File.ReadLines(filePath)
                .Select(l => l.Split("\t").FirstOrDefault())
                .Where(w => w != null)
                .Distinct();

            cSharpRes.DebugLog("cSharpResult");


            // Bash
            $"cat {filePath} | cut -f{colNumUsedForSortingByDesc} | sort | uniq".WriteBashLine();
        }
    }
}