using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using BashExtension;

namespace Q11
{
    class Program
    {
        const string filePath = "../hightemp.txt";

        static void Main(string[] args)
        {
            using (var sr = new StreamReader(filePath, Encoding.Default))
            {
                Console.WriteLine(sr.ReadToEnd().Replace('\t', ' '));
            }

            $"cat {filePath} | sed -e 's/\t/ /g'".WriteBashLine();
        }
    }
}
