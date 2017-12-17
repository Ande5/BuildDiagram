using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligenceSystem
{
    public class DataBase
    {
        List<Variant> m_variantList = new List<Variant>();

        public DataBase()
        {
            m_variantList.Add(new Variant(20, 5,   2,   0.4,  8.5,  15, 3));
            m_variantList.Add(new Variant(25, 6.2, 2.1, 0.42, 9.5,  15, 3));
            m_variantList.Add(new Variant(30, 7,   2.5, 0.45, 10,   15, 3));
            m_variantList.Add(new Variant(35, 7.2, 3,   0.47, 11,   15, 3));
            m_variantList.Add(new Variant(40, 7.5, 3.4, 0.5,  12,   15, 3));
            m_variantList.Add(new Variant(45, 8,   3.6, 0.52, 12.5, 15, 3));
            m_variantList.Add(new Variant(50, 8.5, 3.7, 0.55, 13,   15, 3));
        }

        public Variant GetVariant(int variantNumber)
        {
            return m_variantList[variantNumber];
        }
    }
}
