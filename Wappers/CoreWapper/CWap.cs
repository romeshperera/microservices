using System;
using System.Runtime.InteropServices;

namespace CoreWapper
{
    public class CWap
    {
        [DllImport(@"DLLs\Demo.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Add(int a, int b);
    }
}
