using MPK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPK.NetworkConfigurator
{
    public class NetworkManagement : INetworkManagement
    {
        private readonly NetworkConfigurator networkConfigurator;

        public NetworkManagement()
        {
            networkConfigurator = new NetworkConfigurator();
        }

        public IEnumerable<string> Gateways
        {
            get
            {
                return this.networkConfigurator.Gateways;
            }
        }

        public IEnumerable<string> IPAddresses
        {
            get
            {
                return networkConfigurator.IPAddresses;
            }
        }

        public IEnumerable<string> IPSubnets
        {
            get
            {
                return networkConfigurator.IPSubnets;
            }
        }

        public bool ChangeDNS(string NIC, string DNS)
        {
            networkConfigurator.setDNS(NIC, DNS);
            return true;
        }

        public bool ChangeGateway(string gateway)
        {
            networkConfigurator.setGateway(gateway);
            return true;
        }

        public bool ChangeIP(string ipAddress, string subnetMask)
        {
            networkConfigurator.setIP(ipAddress, subnetMask);
            return true;
        }

        public bool ChangeWINS(string NIC, string privWINS, string secWINS)
        {
            networkConfigurator.setWINS(NIC, privWINS, secWINS);
            return true;
        }
    }
}
