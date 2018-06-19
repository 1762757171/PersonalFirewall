using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace PersonalFirewall
{
    class FireWall
    {
        [DllImport("FirewallInterlayer.dll", EntryPoint = "Install")]
        static extern void Install();
        [DllImport("FirewallInterlayer.dll", EntryPoint = "Remove")]
        static extern void Uninstall();

        public static void StartFilter()
        {
            Install();
        }

        public static void StopFilter()
        {
            Uninstall();
        }
    }
}
