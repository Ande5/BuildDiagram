using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligenceSystem
{
    public class Variant
    {
        /// <summary>
        /// Длина корабля
        /// </summary>
        public double m_length { set; get; }
        /// <summary>
        /// Ширина корабля
        /// </summary>
        public double m_weight { set; get; }
        /// <summary>
        /// Осадка
        /// </summary>
        public double m_draft { set; get; }
        /// <summary>
        /// Метацентрическая высота
        /// </summary>
        public double m_metacentricHeight { set; get; }
        /// <summary>
        /// Скорость
        /// </summary>
        public double m_speed { set; get; }
        /// <summary>
        /// Длина волны (= длине корабля)
        /// </summary>
        public double m_waveLength { set; get; }
        /// <summary>
        /// Амплитуды качки
        /// </summary>
        public double m_thetaM { set; get; }

        public double m_psiM { set; get; }

        //              ОЦЕНКИ ВЕРОЯТНОСТЕЙ:
        /// <summary>
        /// P(E)
        /// </summary>
        public double m_val0 { set; get; }
        /// <summary>
        /// P(H/E)
        /// </summary>
        public double m_val1 { set; get; }
        /// <summary>
        /// P(H/NOT E)
        /// </summary>
        public double m_val2 { set; get; }
        /// <summary>
        /// МД(H/E1)
        /// </summary>
        public double m_val3 { set; get; }
        /// <summary>
        /// МД(H/E2)
        /// </summary>
        public double m_val4 { set; get; }

        public Variant() { }

        public Variant(double length, double weight, double draft,
                       double metacentricHeight, double speed,
                       double thetaM, double pisM,
                       double val0, double val1, double val2,
                       double val3, double val4)
        {
            m_length = length;
            m_weight = weight;
            m_draft = draft;
            m_metacentricHeight = metacentricHeight;
            m_speed = speed;
            m_waveLength = m_length;
            m_thetaM = thetaM;
            m_psiM = pisM;
            m_val0 = val0;
            m_val1 = val1;
            m_val2 = val2;
            m_val3 = val3;
            m_val4 = val4;
        }
    }
}
