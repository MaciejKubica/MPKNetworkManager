using MPK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MPK.PingChecker.Converters
{
    public static class PingStatisticConverter
    {
        public static PingStatistics ConvertToPingStatistic(this PingReply reply)
        {
            return new PingStatistics();         
        }
    }
}
