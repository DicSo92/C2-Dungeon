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
            m_MonsterType = MONSTERS_TYPE.BARBARIAN;
        }

        public override void Attack(Character character)
        {
            //UserInterface.DisplayInfo(false, "The barbarian attacking you with : ", m_Weapon.ToString());
            WeaponAttack();
            base.Attack(character);
        }

        public override void RemoveLifePoints()
        {
        }

        private void WeaponAttack()
        {
            UserInterface.DisplayInfo(false, "Sword attack from Brabarian");
        }
    }
}
