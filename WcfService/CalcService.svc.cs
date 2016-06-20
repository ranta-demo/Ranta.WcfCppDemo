using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    public class CalcService : ICalcService
    {
        public int Add(int a, int b)
        {
            return CalcProxy.Add(a, b);
        }
    }
}
