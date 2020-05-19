using C2_Dungeon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon
{
    class Dungeon
    {
        private Room[] m_ArrayRoom = new Room[Program.ROOM_COUNT];

        DragonsLair m_DragonsLair;


        public Dungeon()
        {
            for (int i = 0; i < m_ArrayRoom.Length; i++)
            {
                m_ArrayRoom[i] = new Room(i);

            }
            m_DragonsLair = new DragonsLair();
        }

        internal void Enter(Heros newHero)
        {
            throw new NotImplementedException();
        }

        public void EnterRoom (int index, Heros newHero)
        {
            if (index < m_ArrayRoom.Length)
            {
                m_ArrayRoom[index].Enter(newHero);
            }
            else
            {
                m_DragonsLair.Enter(newHero);
            }
        }
    }
}
