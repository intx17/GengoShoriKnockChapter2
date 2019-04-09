using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LogExtension;
using BashExtension;

namespace Q16
{
    class Program
    {
        const string filePath = "../hightemp.txt";

        static void Main(string[] args)
        {
            int num = 7;
            var ret = GetSplittedLines(File.ReadAllLines(filePath), num);
            ret.DebugLog("splitted");

            $"split -l {num} {filePath} q16_output".Bash();
        }

        static IEnumerable<List<string>> GetSplittedLines(IEnumerable<string> list, int n)
        {
            Func<int, Func<int>> f1 = x => () => x++;
            var i = f1(0);

            while (true)
            {
                var ret = list.Skip(i() * n).Take(n).ToList();

                if (ret.Any())
                {
                    yield return ret;
                }

                if (ret.Count < n)
                {
                   yield break;
                }
            }
        }
    }
}
