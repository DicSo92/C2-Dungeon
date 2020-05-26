using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon.Communication
{
    class UserInterface
    {
        static public void DisplayInfo(bool debug, params string[] infos)
        {
            if ((Program.DEBUG_MODE && debug) || !debug)
            {
                Console.WriteLine(infos[0]);
            } 
        }
        public UserInterface()
        {
            
        }
    }
}
