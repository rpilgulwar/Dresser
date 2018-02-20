using Dresser.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dresser.BusinessLogic.Implementations
{
    public class ColdRuleEngine : BaseRuleEngine, IRuleEngine
    {
        private static Dictionary<int, string> coldResponses;
        public static void HotResponse()
        {
            coldResponses = new Dictionary<int, string>()
            {
                { 1 , "boots" },
                { 2 , "hat" },
                { 3, "socks" },
                { 4 , "shirt" },
                { 5 , "jacket" },
                { 6 , "pants" },
                { 7 , "leaving house" },
                { 8 , "Removing PJs" }
            };
        }
    }
}
