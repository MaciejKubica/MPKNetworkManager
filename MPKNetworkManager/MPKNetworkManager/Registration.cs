using MPK.Core;
using MPK.NetworkConfigurator;
using MPK.PingChecker;
using MPK.ProcessManager;
using MPKNetworkManager.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
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

        public static List<string> Commands { get; private set; }

        public static void Bulid()
        {
            NetworkManagement = new NetworkManagement();

            PingChecker = new PingChecker();

            ProcessManager = new ProcessManager();

            var customSection = ConfigurationManager.GetSection("CommandsSettings") as CommandsSection;
            List<string> processes = new List<string>();
            for (int i = 0; i < customSection.Command.Count; i++)
            {
                processes.Add(customSection.Command[i].value);
            }
            Commands = processes;
        }
    }
}
