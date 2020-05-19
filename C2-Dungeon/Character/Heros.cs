using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon
{
    class Heros : Character
    {
        #region VariableInit
            int m_iDefensePoints;
            string m_sName;

            Protection m_Protection;
        #endregion

        #region Constructors
            /// <summary>
            /// Hero Class, required name
            /// </summary>
            /// <param name="p_sName">Hero Name</param>
            /// 
            public Heros(string p_sName) : base(100)
            {
                m_sName = p_sName;
                m_Weapon = new Weapon(10, WEAPONS_TYPE.ARROW);
                /// userInterface.displayInfo(Program.debug, "On est dans le constructeur avec arguments de heros : ", m_sName);
                m_Protection = new Protection(10, PROTECTIONS_TYPE.SHIELD); 
        }

        //public void FindWeapon(Weapon myWeapon)
        //    {
        //        weapon += myWeapon;
        //    }
        #endregion
    }
}
