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
            //Process newProcess = new Process(new ProcessStartInfo(processName, attributes))
        }
    }
}
