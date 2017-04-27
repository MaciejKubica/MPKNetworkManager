using MPK.Core;
using MPK.NetworkConfigurator;
using MPK.PingChecker;
using MPK.ProcessManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPKNetworkManager
{
    public static class Registration
    {
        public static INetworkManagement NetworkManagement { get; set; }

        public static IPingChecker PingChecker { get; set; }

        public static IProcessManager ProcessManager { get; set; }

        public static void Bulid()
        {
            NetworkManagement = new NetworkManagement();

            PingChecker = new PingChecker();

            ProcessManager = new ProcessManager();
        }
    }
}
