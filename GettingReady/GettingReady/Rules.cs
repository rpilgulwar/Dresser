using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady
{
    public class Rules
    {
        private string _temperature;
        private string[] _commands;
        private string _output;
        private string _status;
        public TempratureType.Temp temp;

        public Rules(string temperature, string[] commands)
        {
            _temperature = temperature.ToUpper();
            _commands = commands;
        }

        public string ApplyRules()
        {
            if (BaseRule())
            {
                //int command = 0;
                foreach (string command in _commands)
                {
                    switch (Int32.Parse(command))
                    {
                        case 4:
                            PutOnShirt();
                            break;
                        case 2:
                            PutOnHeadware();
                            break;
                        case 5:
                            PutOnJacket();
                            break;
                        case 6:
                            PutOnPants();
                            break;
                        case 3:
                            PutOnSocks();
                            break;
                        case 1:
                            PutOnFootware();
                            break;
                        case 7:
                            LeaveHouse();
                            break;
                        default:
                            break;
                    }
                    if (_status == "fail")
                        break;
                }
            }
            else
                _output = "fail";
            return _output;
        }

        //If an invalid command is issued, respond with “fail” and stop processing commands
        private Boolean BaseRule()
        {
            //temperature is hot or cold
            if(temp.Equals(_temperature))
            //if (_temperature != "hot" & _temperature != "cold")
            {
                return false;
            }
            if (_commands.Length > 0)
            {
                if (CheckForInvalidCommand())
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        // Below 2 Rule implementation:
        //If an invalid command is issued, respond with “fail” and stop processing commands
        //Only 1 piece of each type of clothing may be put on
        private Boolean CheckForInvalidCommand()
        {
            List<string> val = new List<string>();
            //Check if input is not other than 1,2,3,4,5,6,7,8
            for (int i = 0; i < _commands.Length; i++)
            {
                if (!(Int32.Parse(_commands[i]) > 0 && Int32.Parse(_commands[i]) <= 8) | val.Contains(_commands[i]))
                {
                    return false;
                }
                val.Add(_commands[i]);
            }
            if (TakeOffPajamas())
                return true;
            else
                return false;
        }

        //If the first step is not Removing PJ's we print failure.
        private Boolean TakeOffPajamas()
        {
            int command = 8;
            if (_commands[0] != "8")
                //UpdateOutPut("Fail");
                return false;
            else
            {
                UpdateOutPut(OutputResponse.ColdResponse(command));
                return true;
            }
        }

       /* //Only 1 piece of each type of clothing may be put on
        private Boolean CheckForDuplicates()
        {
            List<string> val = new List<string>();
            foreach (string s in _commands)
            {
                if (val.Contains(s))
                {
                    return false;
                }
                val.Add(s);
                // if (_temperature == "cold")
                //   UpdateOutPut(OutputResponse.ColdResponse(Int32.Parse(s)));
                //else
                //  UpdateOutPut(OutputResponse.HotResponse(Int32.Parse(s)));
            }
            return true;
        }*/


        private void PutOnShirt()
        {
            int command = 4;
            if (_commands.Contains("2"))
            {
                int jacketIndex = -1;
                if (_commands.Contains("5"))
                {
                    jacketIndex = Array.IndexOf(_commands, "5");
                }
                int shirtIndex = Array.IndexOf(_commands, "4");
                int headwearIndex = Array.IndexOf(_commands, "2");
                if ((shirtIndex < headwearIndex) | (shirtIndex < jacketIndex & shirtIndex < headwearIndex))
                {
                    if (_temperature == "COLD")
                        UpdateOutPut(OutputResponse.ColdResponse(command));
                    else
                        UpdateOutPut(OutputResponse.HotResponse(command));
                }
                else
                    UpdateOutPut("Fail");
            }
            else
                UpdateOutPut("Fail");
        }

        private void PutOnHeadware()
        {
            int command = 2;
            if (_temperature == "COLD")
                UpdateOutPut(OutputResponse.ColdResponse(command));
            else
                UpdateOutPut(OutputResponse.HotResponse(command));
        }

        private void PutOnJacket()
        {
            int command = 5;
            if (_temperature == "COLD")
                UpdateOutPut(OutputResponse.ColdResponse(command));
            else
                UpdateOutPut(OutputResponse.HotResponse(command));
        }

        private void PutOnPants()
        {
            int command = 6;
            if (_temperature == "COLD")
                UpdateOutPut(OutputResponse.ColdResponse(command));
            else
                UpdateOutPut(OutputResponse.HotResponse(command));
        }

        private void PutOnSocks()
        {
            int command = 3;
            if (_temperature == "COLD")
                UpdateOutPut(OutputResponse.ColdResponse(command));
            else
                UpdateOutPut(OutputResponse.HotResponse(command));
        }

        private void PutOnFootware()
        {
            int command = 1;
            if (_commands.Contains("6"))
            {
                int socksIndex = -1;
                if (_commands.Contains("3"))
                {
                    socksIndex = Array.IndexOf(_commands, "3");
                }
                int pantIndex = Array.IndexOf(_commands, "6");
                int footWareIndex = Array.IndexOf(_commands, "1");
                if ((footWareIndex > pantIndex) | (footWareIndex > socksIndex & footWareIndex > pantIndex))
                {
                    if (_temperature == "COLD")
                        UpdateOutPut(OutputResponse.ColdResponse(command));
                    else
                        UpdateOutPut(OutputResponse.HotResponse(command));
                }
                else
                    UpdateOutPut("Fail");
            }
            else
                UpdateOutPut("Fail");
        }

        //You cannot leave the house until all items of clothing are on (except socks and a jacket when it’s hot)
        private void LeaveHouse()
        {
            int command = 7;
            int leavingIndex = Array.IndexOf(_commands, "7");
            if (_temperature == "COLD" & leavingIndex == 7)
                UpdateOutPut(OutputResponse.ColdResponse(command));
            else if (_temperature == "HOT" & leavingIndex == 5)
                UpdateOutPut(OutputResponse.HotResponse(command));
            else
                UpdateOutPut("fail");
        }

        public void UpdateOutPut(string outPut)
        {
            if (outPut == "fail")
                _status = "fail";
            if (_output == null)
                _output = outPut;
            else
                _output = _output + ", " + outPut;
        }
    }
}
