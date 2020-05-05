using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon
{
    class Character
    {
        int m_iHealthPoints;

        Weapon m_Weapon;

        public Character(int p_iHealthPoints)
        {
            m_iHealthPoints = p_iHealthPoints;
            m_Weapon = new Weapon();
        }
    }
}
