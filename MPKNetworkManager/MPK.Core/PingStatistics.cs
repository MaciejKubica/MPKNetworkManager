using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPK.Core
{
    public class PingStatistics
    {
        public List<PingResult> PingReplaies { get; private set; }

        public int PositivePercent { get; private set; }

        public int RoundTripMaximumTime { get; private set; }

        public int RoundTripMinimumTime { get; private set; }

        public int RoundTripAverageTime { get; private set; }
    }

    public class PingResult
    {
        public string Address { get; set; }

        public int BufferSize { get; set; }

        public PingStatus Status { get; set; }

        public DateTime RoundtripTime { get; set; }

    }
}
