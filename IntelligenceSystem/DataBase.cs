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
            m_variantList.Add(new Variant(20, 5, 2, 0.4, 8.5, 15, 3, 0.75, 0.8, 0.01, 0.85, 0.86));
            m_variantList.Add(new Variant(25, 6.2, 2.1, 0.42, 9.5, 15, 3, 0.74, 0.79, 0.01, 0.85, 0.86));
            m_variantList.Add(new Variant(30, 7, 2.5, 0.45, 10, 15, 3, 0.73, 0.78, 0.01, 0.85, 0.87));
            m_variantList.Add(new Variant(35, 7.2, 3, 0.47, 11, 15, 3, 0.72, 0.77, 0.02, 0.84, 0.87));
            m_variantList.Add(new Variant(40, 7.5, 3.4, 0.5, 12, 15, 3, 0.71, 0.76, 0.02, 0.84, 0.86));
            m_variantList.Add(new Variant(45, 8, 3.5, 0.52, 12.5, 15, 3, 0.7, 0.75, 0.02, 0.84, 0.86));
            m_variantList.Add(new Variant(50, 8.5, 3.6, 0.55, 13, 15, 3, 0.69, 0.74, 0.03, 0.83, 0.86));
        }

        public Variant GetVariant(int variantNumber)
        {
            return m_variantList[variantNumber];
        }
    }
}
