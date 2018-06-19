using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFirewall
{
    public struct FilterRule
    {
        public string IP;
        public int PortTargetStart;
        public int PortTargetEnd;
        public int PortSelfStart;
        public int PortSelfEnd;
        public string Protocol;
        public string Direction;

        public FilterRule(string ip, int portTS, int portTE, int portSS, int portSE, string protocol, string direction)
        {
            IP = ip;
            PortTargetStart = portTS;
            PortTargetEnd = portTE;
            PortSelfStart = portSS;
            PortSelfEnd = portSE;
            Protocol = protocol;
            Direction = direction;
        }
    }
}
