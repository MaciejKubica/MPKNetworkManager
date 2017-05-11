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
        public void StartProcess(string processName, params string[] attributes)
        {            
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.FileName = @"C:\windows\system32\cmd.exe";            
            Process.Start(new ProcessStartInfo(@"C:\windows\system32\cmd.exe", "/c" + processName));
            //Process proceess = new Process();
            //proceess.OutputDataReceived += Proceess_OutputDataReceived;
        }

        //private void Proceess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        //{
        //    e.Data
        //}
    }
}
