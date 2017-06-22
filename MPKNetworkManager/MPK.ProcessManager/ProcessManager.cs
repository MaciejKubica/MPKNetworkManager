using MPK.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPK.ProcessManager
{
    public class ProcessManager : IProcessManager
    {
        public void StartProcess(string processName, out string stdOutput, out string stdError, params string[] attributes)
        {            
            var procesInfo = new ProcessStartInfo(@"C:\windows\system32\cmd.exe", "/c" + processName);
            var process = new Process();
            procesInfo.RedirectStandardOutput = true;
            procesInfo.RedirectStandardError = true;
            procesInfo.UseShellExecute = false;
            process.StartInfo = procesInfo;
            process.Start();
            process.WaitForExit();

            stdOutput = process.StandardOutput.ReadToEnd();
            stdError = process.StandardError.ReadToEnd();
        }
    }
}
