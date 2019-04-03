using System;
using System.IO;
using System.Linq;
using BashExtension;

namespace Q13
{
    class Program
    {
        static void Main(string[] args)
        {
            var col1Lines = File.ReadAllLines("../col1.txt");
            var col2Lines = File.ReadAllLines("../col1.txt");

            var mergedContent = string.Join("\n", col1Lines.Zip(col2Lines, (l1, l2) => $"{l1}\t{l2}"));

            File.WriteAllText("./merged.txt", mergedContent);

            // 確認用
            "paste ../col1.txt ../col2.txt".WriteBashLine();
        }
    }
}
