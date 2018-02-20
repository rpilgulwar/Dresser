using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReady
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();
            args = input.Split(' ');
            if(args.Length < 2)
            {
                Console.Write("fail");
            }
            else
            {
                string temperature = args[0];
                string[] commands = args[1].Split(',');
                Console.WriteLine(temperature);
                for (int i = 0; i < commands.Length; i++)
                {
                    Console.WriteLine(commands[i]);
                }
                Rules rules = new Rules(temperature, commands);
                Console.WriteLine($"Output:  {rules.ApplyRules()}");

            }
            Console.ReadLine();

        }
    }
}
