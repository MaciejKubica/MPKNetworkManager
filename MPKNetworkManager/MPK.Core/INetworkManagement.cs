using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPK.Core
{
    public interface INetworkManagement
    {
        IEnumerable<string> IPAddresses { get;}

        IEnumerable<string> IPSubnets { get; }

        IEnumerable<string> Gateways { get; }

        bool ChangeIP(string ipAddress, string subnetMask);

        bool ChangeGateway(string gateway);

        bool ChangeDNS(string NIC, string DNS);

        bool ChangeWINS(string NIC, string privWINS, string secWINS);
    }
}
