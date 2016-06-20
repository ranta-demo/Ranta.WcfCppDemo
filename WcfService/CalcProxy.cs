using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace WcfService
{
    public class CalcProxy
    {
        [DllImport("CalcLibrary.dll", EntryPoint = "Add", CallingConvention = CallingConvention.Cdecl)]
        public extern static int Add(int a, int b);
    }
}