using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPK.Core
{
    public interface IPingChecker
    {
        PingStatistics DoPingCommand(string pingAddress, int port = -1, int counter = 10, params string[] attributes);

        Task<PingStatistics> DoPingCommandAsync(string pingAddress, int port = -1, int counter = 10, params string[] attributes);
    }
}
