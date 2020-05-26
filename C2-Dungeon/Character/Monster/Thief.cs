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
            m_MonsterType = MONSTERS_TYPE.THIEF;
        }

        public override void Attack(Character character)
        {
            WeaponAttack();
            base.Attack(character);
        }

        public override void RemoveLifePoints()
        {
        }

        private void WeaponAttack()
        {
            UserInterface.DisplayInfo(false, "Arrow attack from Thief");
        }
    }
}
