using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon
{
    class Thief : Monster
    {
        public Thief()
        {
            m_Weapon = new Weapon(10, WEAPONS_TYPE.ARROW);
        }
    }
}
