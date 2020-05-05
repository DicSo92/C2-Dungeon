using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon
{
    class Room
    {
        int m_iCurrentRoom;

        Monster m_Monster;
        Chest m_Chest;

        public Room(int p_iCurrentRoom)
        {
            m_iCurrentRoom = p_iCurrentRoom;
        }
    }
}
