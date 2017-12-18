using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligenceSystem
{
    class InfoDecisionMaking
    {
        /// <summary>
        /// Кажущийся период волны
        /// </summary>
        /// <param name="lambda"></param>
        /// <param name="V"></param>
        /// <param name="fi"></param>
        /// <returns></returns>
        public double ApparentWavePeriod(double lambda, double V, double fi)
        {
            double Cw =1.25* Math.Pow(lambda,0.5);
            return lambda / (Cw - V * Math.Cos(fi / 180));
        }
        /// <summary>
        /// Собственные колебания бортовой качки
        /// </summary>
        /// <param name="ширина корабля"></param>
        /// <param name="метацентрическая высота"></param>
        public double Rolling(double B,double h)
        {
            double C= 0.8;
            return C * B / Math.Sqrt(h);
        }
        /// <summary>
        /// Сообственные колебания килевой качки
        /// </summary>
        public double Pitching(double T)
        {
            return 2.5 * Math.Sqrt(T);
        }
    }
}
