using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingDressed
{
    class WinterWear : IWear
    {
        public string PutOnFootwear() { return "boots"; }
        public string PutOnHeadWear() { return "hat"; }
        public string PutOnSocks() { return "socks"; }
        public string PutOnShirt() { return "shirt"; }
        public string PutOnJacket() { return "jacket"; }
        public string PutOnPants() { return "pants"; }
        public string LeaveHouse() { return "leaving house"; }
        public string TakeOffPajamas() { return "Removing PJ's"; }
    }
}
