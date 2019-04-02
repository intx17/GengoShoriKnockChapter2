using System;
using System.IO;
using System.Linq;
using BashExtension;

namespace Q10
{
    class Program
    {
        const string filePath = "../hightemp.txt";

        static void Main(string[] args)
        {
            var allLines = File.ReadAllLines(filePath);
            Console.WriteLine(allLines.Count());

            $"cat {filePath} | wc -l".WriteBashLine();
        }
    }
}
