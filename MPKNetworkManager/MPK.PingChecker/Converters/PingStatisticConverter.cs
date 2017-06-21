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
        public static PingResult ConvertToPingResult(this PingReply reply)
        {
            PingResult stat = new PingResult();

            stat.Address = reply.Address?.ToString();
            stat.Status = reply.Status == IPStatus.Success ? PingStatus.Success : PingStatus.Failed;
            stat.RoundtripTime = reply.RoundtripTime;
            stat.BufferSize = reply.Buffer.Length;
            stat.TimeToLive = reply.Options != null ? reply.Options.Ttl : 0;
            return stat;
        }
    }
}
