using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon
{
    abstract class Character
    {
        protected int m_iHealthPoints;

        protected Weapon m_Weapon;

        public Character(int p_iHealthPoints)
        {
            m_iHealthPoints = p_iHealthPoints;

            //m_Weapon = new Weapon(m_AtkPoint);
            
        }

        //public void Attack(Character character)
        //{
        //    character.RemoveLifePoints();
        //}

        //private void RemoveLifePoints()
        //{
        //    m_iHealthPoints -= m_Weapon.m_iAttackPoints;

        //}

        public abstract void Attack(Character character);

        public abstract void RemoveLifePoints();
    }
}
