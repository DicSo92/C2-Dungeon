using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon
{
    class Weapon
    {
        int m_iAttackPoints;

        public Weapon(int p_iAttackPoints)
        {
            m_iAttackPoints = p_iAttackPoints;
        }
        public static Weapon operator+(Weapon a, Weapon b)
        {
            return new Weapon(a.m_iAttackPoints + b.m_iAttackPoints);
        }
    }
}
