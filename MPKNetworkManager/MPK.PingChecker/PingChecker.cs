using MPK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using MPK.PingChecker.Converters;
using System.IO;

namespace MPK.PingChecker
{
    public class PingChecker : IPingChecker
    {
        public PingStatistics DoPingCommand(string pingAddress, int port = -1, params string[] attributes)
        {
            //Ping doPing = new Ping();

            //var reply = doPing.Send(pingAddress);
            throw new FileNotFoundException();

        }

        public Task<PingStatistics> DoPingCommandAsync(string pingAddress, int port = -1, params string[] attributes)
        {
            throw new NotImplementedException();
        }
    }
}
