using Dresser.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dresser.BusinessLogic.Implementations
{
    public class HotRuleEngine :  BaseRuleEngine, IRuleEngine
    {
        private static Dictionary<int, string> hotResponses;
        public static void HotResponse()
        {
            hotResponses = new Dictionary<int, string>()
            {
                { 1 , "sandals" },
                { 2 , "sunglasses" },
                { 3, "fail" },
                { 4 , "shirt" },
                { 5 , "fail" },
                { 6 , "shorts" },
                { 7 , "leaving house" },
                { 8 , "Removing PJs" }
            };
        }
    }
}
