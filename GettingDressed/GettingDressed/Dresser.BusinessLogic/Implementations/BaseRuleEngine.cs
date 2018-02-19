using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dresser.BusinessLogic.Implementations
{
    public abstract class BaseRuleEngine
    {
        public static Dictionary<int, string> baseCommands;
        public static Dictionary<string, HashSet<int>> definedOrder;
        public static Dictionary<int, string> response;
        private const string Fail = "fail";

        public static void PopulateData()
        {
            baseCommands = new Dictionary<int, string>()
            {
                { 1 , "Put on footwear" },
                { 2 , "Put on headwear" },
                { 3, "Put on socks" },
                { 4 , "Put on shirt" },
                { 5 , "Put on jacket" },
                { 6 , "Put on pants" },
                { 7 , "Leave house" },
                { 8 , "Take off Pajamas" }
            };

            definedOrder = new Dictionary<string, HashSet<int>>()
            {
                {"hot", new HashSet<int>(){8, 6, 4, 2, 1, 7}},
                {"cold", new HashSet<int>(){8, 6, 3, 4, 2, 5, 1, 7} }
            };
        }
        public static IEnumerable<int> ParseInput(string input)
        {
            var array = input?.Trim().Split(',');
            return array
            .Where(x => !string.IsNullOrEmpty(x))
            .Select(x => int.Parse(x.Trim()))
            .ToList();
        }

        public static string Process(string input, Dictionary<int, string> responseDictionary, HashSet<int> commandOrder)
        {
            HashSet<string> result = new HashSet<string>();
            var enuemrableInput = ParseInput(input);
            var currentIndex = 0;
            foreach (var i in enuemrableInput)
            {
                if (i != commandOrder.ElementAt(currentIndex))
                {
                    result.Add(Fail);
                    break;
                }

                if (!result.Add(responseDictionary[i]))
                {
                    result.Add(Fail);
                    break;
                }

                currentIndex++;
            }
            return string.Join(", ", result);
        }
    }
}
