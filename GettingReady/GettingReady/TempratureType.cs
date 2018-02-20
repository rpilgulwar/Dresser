using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady
{
    public class TempratureType
    {
        public enum Temp
        {
            [Description("Not Applicable")]NA,
            [Description("HOT")]HOT,
            [Description("COLD")]COLD
        }
    }
}
