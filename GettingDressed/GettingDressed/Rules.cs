using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingDressed
{
    class Rules : IRules
    {
        public string Rule1(int[] input)
        {
            if (input[0] != 8)
            {
                return "fail";
            }
            return "pass";
        }

        public string Rule2(int[] input)
        {
            List<int> val = new List<int>();
            foreach (var item in input)
            {
                if (val.Contains(item))
                {
                    return "fail";
                }
                val.Add(item);
            }
            return "pass";
        }

        //footware before socks and pant
        public string Rule3(int[] input)
        {
            int socksIndex = Array.IndexOf(input, 3);
            int pantIndex = Array.IndexOf(input, 6);
            int footwareIndex = Array.IndexOf(input, 1);
            if (footwareIndex > socksIndex || footwareIndex > pantIndex)
            {
                return "fail";
            }
            return "pass";
        }

        //Rule: shirt before jacket and headwear
        public string Rule4(int[] input)
        {
            int shirtIndex = Array.IndexOf(input, 4);
            int headwearIndex = Array.IndexOf(input, 2);
            int jacketIndex = Array.IndexOf(input, 5);
            if (jacketIndex > shirtIndex || headwearIndex > shirtIndex)
            {
                return "fail";
            }
            return "pass";
        }

        //Rule: You cannot leave the house until all items of clothing are on

    }
}
