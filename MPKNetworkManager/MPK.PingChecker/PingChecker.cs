using MPK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using MPK.PingChecker.Converters;
using System.IO;
using System.Threading;

namespace MPK.PingChecker
{
    public class PingChecker : IPingChecker
    {
        public PingStatistics DoPingCommand(string pingAddress, int port = -1, int counter = 10, params string[] attributes)
        {
            List<PingReply> replies = new List<PingReply>();
            Ping doPing = new Ping();

            for (int i = 0; i < counter; i++)
            {
                replies.Add(doPing.Send(pingAddress));
                Thread.Sleep(1000);
            }

            return CalculatePingStatistics(replies);
        }

        public Task<PingStatistics> DoPingCommandAsync(string pingAddress, int port = -1, int counter = 10, params string[] attributes)
        {
            return Task.Run(() => DoPingCommand(pingAddress, port,counter, attributes));
        }

        private PingStatistics CalculatePingStatistics(List<PingReply> repies)
        {
            var roundTrips = repies.Select(x => x.RoundtripTime).ToList();
            PingStatistics statistics = new PingStatistics(
                repies.Select(x => x.ConvertToPingResult()).ToList(),
                (repies.Count(x => x.Status == IPStatus.Success) / repies.Count) * 100,
                (int)Enumerable.Max(roundTrips),
                (int)Enumerable.Min(roundTrips),
                (int)Math.Floor(Enumerable.Average(roundTrips)));
            return statistics;
        }
    }
}
