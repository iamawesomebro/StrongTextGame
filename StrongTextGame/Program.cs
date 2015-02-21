using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongTextGame
{
    class Program
    {
        Player _player;

        static void Main(string[] args)
        {
            //CharCreation newPlayer = new CharCreation(_player);

            //Doesn't compile, too tired, probably something stupid.
        }

        public string Parser(string cmd)
        {
            string resultString = " ";
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            string[] args = cmd.Split(delimiterChars);
            switch (args[0])
            {
                case "walk" :

                default:
                break;
            }

            return resultString;
        }
    }
}
