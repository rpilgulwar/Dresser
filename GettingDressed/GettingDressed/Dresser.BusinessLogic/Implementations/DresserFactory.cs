using Dresser.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dresser.BusinessLogic.Implementations
{
    public class DresserFactory : BaseRuleEngine,IdresserFactory
    {
        public string ProcessBasedOnTempreature(string input)
        {
            int index = input.IndexOf(' ');
            string temperature = input.Substring(0, index)?.Trim().ToLower();
            string commands = input.Substring(index + 1);
            var commandOrder = BaseRuleEngine.definedOrder[temperature];

            if (temperature.Equals("hot"))
            {
                return Process(commands, HotRuleEngine.HotResponse<>, commandOrder);
            }

            if (temperature.Equals("cold"))
            {
                return Process(commands, coldResponses, commandOrder);
            }

            return string.Empty;
        }
    }
}
