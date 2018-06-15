using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NetWapper
{
    public class NWap
    {
        [DllImport(@"DLLs\Demo.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Add(int a, int b);
    }
}
