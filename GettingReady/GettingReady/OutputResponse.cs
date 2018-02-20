using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady
{
    class OutputResponse
    {
        private static Dictionary<int, string> coldResponses;
        private static Dictionary<int, string> hotResponses;
        //output response for cold weather
        public static string ColdResponse(int command)
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
            return coldResponses[command];
        }

        // output response for hot weather
        public static string HotResponse(int command)
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
            return hotResponses[command];
        }        
    }
}
