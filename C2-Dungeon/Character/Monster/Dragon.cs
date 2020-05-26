using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon
{
    class Dragon : Monster
    {
        public Dragon()
        {
            m_MonsterType = MONSTERS_TYPE.DRAGON;
        }

        public override void Attack(Character character)
        {
            DragonAttack();
            base.Attack(character);
        }

        public override void RemoveLifePoints()
        {
        }

        private void DragonAttack()
        {
            UserInterface.DisplayInfo(false, "Fire and blood, Dragon attack !");
        }
    }
}
