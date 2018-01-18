using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contester
{
    static class Tester
    {
        public static bool Test(string processName, string input, string expectedResult, int delay, out TimeSpan wortingTime)
        {
            string actualResult = string.Empty;
            using (Process process = new Process())
            {
                process.StartInfo = new ProcessStartInfo
                {
                    FileName = processName,
                    Arguments = input,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardInput = true
                };
                process.Start();
                process.WaitForExit(delay);
                if((DateTime.Now - process.StartTime).Milliseconds >= delay)
                {
                    process.Kill();
                    wortingTime = new TimeSpan(0, 0, 0, 0, -1);
                    return false;
                }
                actualResult = process.StandardOutput.ReadToEnd();
                wortingTime =  process.ExitTime - process.StartTime;
            }
            return expectedResult == actualResult;
        }
    }
}
