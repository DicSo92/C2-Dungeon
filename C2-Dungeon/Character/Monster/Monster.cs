using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon
{
    enum MONSTERS_TYPE
    {
        BARBARIAN,
        MAGICIAN,
        THIEF,
        DRAGON
    }
    abstract class Monster : Character
    {
        protected MONSTERS_TYPE m_MonsterType;

        public Monster() : base(100)
        {

        }

        internal MONSTERS_TYPE GetMonsterType()
        {
            return m_MonsterType;
        }
    }
}
