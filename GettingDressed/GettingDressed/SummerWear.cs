using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingDressed
{
    class SummerWear : IWear
    {
        public string PutOnFootwear() { return "sandals"; }
        public string PutOnHeadWear() { return "sunglass"; }
        public string PutOnSocks() { return "fail"; }
        public string PutOnShirt() { return "shirt"; }
        public string PutOnJacket() { return "fail"; }
        public string PutOnPants() { return "shorts"; }
        public string LeaveHouse() { return "leaving house"; }
        public string TakeOffPajamas() { return "Removing PJ's"; }
    }
}
