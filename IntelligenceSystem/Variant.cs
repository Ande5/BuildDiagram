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

        public Variant() { }

        public Variant(double length, double weight, double draft, 
                       double metacentricHeight, double speed,
                       double thetaM, double pisM)
        {
            m_length = length;
            m_weight = weight;
            m_draft = draft;
            m_metacentricHeight = metacentricHeight;
            m_speed = speed;
            m_waveLength = m_length;
            m_thetaM = thetaM;
            m_psiM = pisM;
        }
    }
}
