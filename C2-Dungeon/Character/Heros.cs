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

            Protection m_Protection;
        #endregion

        #region Constructors
            /// <summary>
            /// Default Hero Class constructor
            /// </summary>
            public Heros()
            {
                m_iDefensePoints = 5;
                m_Protection = new Protection();
                m_sName = "Thor";
            }
            /// <summary>
            /// Hero Class, required name
            /// </summary>
            /// <param name="p_sName">Hero Name</param>
            public Heros(string p_sName)
            {
                m_sName = p_sName;
            }
        #endregion
    }
}
