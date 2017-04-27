using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPK.Core
{
    public interface IProcessManager
    {
        void StartProcess(string processName, params string[] attributes);
    }
}
