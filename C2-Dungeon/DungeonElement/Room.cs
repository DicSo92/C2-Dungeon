using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C2_Dungeon
{
    class Room
    {
        int m_iCurrentRoom;
        Dungeon m_currentDungeon;

        Monster m_Monster;
        Chest m_Chest;

        public Room(int p_iCurrentRoom, Dungeon dungeon, Random rand)
        {
            m_currentDungeon = dungeon;

            m_iCurrentRoom = p_iCurrentRoom;


            int random = rand.Next(1, 4);

            //Thread.Sleep(30);

            //Console.WriteLine(random);

            switch (random)
            {
                case 1:
                    this.m_Monster = new Barbarian();
                    break;
                case 2:
                    this.m_Monster = new Magician();
                    break;
                case 3:
                    this.m_Monster = new Thief();
                    break;
                default:
                    break;
            }
        }

        protected Room (Monster monster)
        {
            m_Monster = monster;
        }

        internal virtual void Enter(Heros newHero)
        {
            m_Monster.Attack(newHero);
            newHero.Attack(m_Monster);



        }


    }
}
