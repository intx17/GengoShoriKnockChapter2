using System;
using System.Diagnostics;

namespace BashExtension
{
    public static class BashExtention
    {
        public static string Bash(this string cmd)
        {
            var escapedArgs = cmd.Replace("\"", "\\\"");

            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    Arguments = $"-c \"{escapedArgs}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };

            process.Start();
            string result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            return result;
        }

        public static void WriteBashLine(this string cmd)
        {
            Console.WriteLine("=====START BASH=====");
            Console.WriteLine(cmd.Bash());
            Console.WriteLine("=====END BASH=====");
        }
    }
}