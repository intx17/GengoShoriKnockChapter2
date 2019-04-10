using System;
using System.IO;
using System.Linq;
using BashExtension;
using LogExtension;

namespace Q19
{
    class Program
    {
        const int colNumUsedForSortingByDesc = 1;
        const string filePath = "../hightemp.txt";

        static void Main(string[] args)
        {
            var cSharpResult = File.ReadAllLines(filePath)
                .Select(l => l.Split("\t")[colNumUsedForSortingByDesc - 1])
                .GroupBy(w => w)
                .OrderByDescending(g => g.Count())
                .Select(g => g.FirstOrDefault());
            cSharpResult.DebugLog("cSharpResult");

            $"cat {filePath} | cut -f{colNumUsedForSortingByDesc} | sort | uniq -c | sed -e 's/^[ ]*//g' | sort -k{colNumUsedForSortingByDesc} -r -t ' ' | cut -f{colNumUsedForSortingByDesc + 1} -d ' '".WriteBashLine();
        }
    }
}
