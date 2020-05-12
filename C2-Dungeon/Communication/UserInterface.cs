using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon.Communication
{
    class UserInterface
    {
        static public void displayInfo(bool debug, params string[] infos)
        {

            Console.WriteLine(infos[0]);
        }
        public UserInterface()
        {
           
        }
    }
}
