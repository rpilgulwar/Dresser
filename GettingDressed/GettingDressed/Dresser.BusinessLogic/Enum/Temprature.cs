using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dresser.BusinessLogic.Enum
{
    public enum Temprature
    {
        [Description("Not applicable")] NA,        
        [Description("Hot")]Hot,
        [Description("Cold")] Cold
    } 

}
