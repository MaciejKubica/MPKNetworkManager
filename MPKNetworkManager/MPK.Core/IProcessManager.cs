using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPK.Core
{
    public interface IProcessManager
    {
        void StartProcess(string processName, out string stdOutput, out string stdError, params string[] attributes);
    }
}
