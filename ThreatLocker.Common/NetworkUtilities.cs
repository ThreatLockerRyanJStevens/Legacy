using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreatLockerCommon
{
    public static class NetworkUtilities
    {
        public static HashSet<int> GetPortRange(string portRange)
        {
            if (!IsValidPortRange(portRange)) return new HashSet<int>();

            var ports = new HashSet<int>();
            var portSplit = portRange.Split('-');
            int portFrom;
            int portTo;

            int.TryParse(portSplit[0], out portFrom);
            int.TryParse(portSplit[1], out portTo);

            for (int p = portFrom; p <= portTo; p++)
            {
                ports.Add(p);
            }

            return ports;
        }

        public static bool IsValidPortRange(string portRange)
        {
            if (portRange.Contains("-"))
            {
                var portSplit = portRange.Split('-');

                if (portSplit.Length != 2 || !IsValidPort(portSplit[0]) || !IsValidPort(portSplit[1]))
                {
                    return false;
                }

                int portFrom = -1;
                int portTo = -1;

                if (portSplit.Length > 0)
                {
                    int.TryParse(portSplit[0], out portFrom);
                }
                if (portSplit.Length > 1)
                {
                    int.TryParse(portSplit[1], out portTo);
                }

                return (portFrom >= 0 && portTo > 0 && portTo <= 65535 && portFrom <= portTo);
            }

            return false;
        }

        public static bool IsValidPort(string numberString)
        {
            int number = 0;

            return int.TryParse(numberString, out number) && number >= 0 && number <= 65535;
        }
    }
}
