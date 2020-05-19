using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Dungeon
{
    class Heros
    {
        #region VariableInit
            int m_iDefensePoints;
            string m_sName;
            Weapon weapon;

            Protection m_Protection;
        #endregion

        #region Constructors
            /// <summary>
            /// Default Hero Class constructor
            /// </summary>
            public Heros()
            {
                m_iDefensePoints = 5;
                m_Protection = new Protection(10, PROTECTIONS_TYPE.SHIELD);
                m_sName = "Thor";
                /// userInterface.displayInfo(Program.debug, "On est dans le constructeur par defaut de  heros");
            }
            /// <summary>
            /// Hero Class, required name
            /// </summary>
            /// <param name="p_sName">Hero Name</param>
            public Heros(string p_sName)
            {
                m_sName = p_sName;
                weapon = new Weapon(10, WEAPONS_TYPE.ARROW);
                /// userInterface.displayInfo(Program.debug, "On est dans le constructeur avec arguments de heros : ", m_sName);
            }

            public void FindWeapon(Weapon myWeapon)
            {
                weapon += myWeapon;
            }
        #endregion
    }
}
