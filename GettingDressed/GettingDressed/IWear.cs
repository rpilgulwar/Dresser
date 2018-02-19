using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingDressed
{
    interface IWear 
    {
        string PutOnHeadWear();
        string PutOnSocks();
        string PutOnShirt();
        string PutOnJacket();
        string PutOnPants();
        string LeaveHouse();
        string TakeOffPajamas();
    }
}
