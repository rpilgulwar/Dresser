using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady
{
    class HotWeatherRules //: BaseRules
    {
        private static Dictionary<int, string> hotResponses;
        public static void Response()
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
