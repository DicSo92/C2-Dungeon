using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon
{
    class Barbarian : Monster
    {
        public Barbarian()
        {
            m_Weapon = new Weapon(10, WEAPONS_TYPE.SWORD);
        }
    }
}
