using System;

namespace IntelligenceSystem
{
    class SystemLogicalRules
    {
        private double[] m_X1 = new double[3]; //заданная амплитуда качки
        private double[] m_X2 = new double[3];
        private double[] m_A1 = new double[3]; // амплитуда сильной качки
        private double[] m_A2 = new double[3];
        private double[] m_Y = new double[3]; //курсовой угол

        private double m_tauTheta;

        public SystemLogicalRules()
        {
            // Амплитуды качки:
            m_tauTheta = 15;

        }

        private void SystemLogical()
        {
            for (int i = 0; i <= 2; i++)
            {
                if ((_x1[i] == _a1[i]) && (_x2[i] == _a2[i]))
                {
                    procedurepi(i);
                }
            }

        }

        public string LogicFunc(double lambda, double v, double phi, double b, double t, double h)
        {
            if ((lambda <= 0) || (v <= 0) || (b <= 0) || (t <= 0) || (h <= 0))
            {
                return "Данные введены неверно!";
            }
            else
            {
                // Вычисление скорости волны:

                double cw = 1.25 * Math.Sqrt(lambda);

                // Вычисление кажущегося периода:

                double tauK = lambda / (cw - v * Math.Cos(phi * Math.PI / 180));

                // Вычисление собственного периода бортовой качки:

                double c = 0.8;

                double tauTheta = c * b / Math.Sqrt(h);

                // Вычисление собственного периода килевой качки:

                double tauPsi = 2.5 * Math.Sqrt(t);

                // Аналих и вывод результата:

                string strResult = "Резонансных периодов не обнаружено.";

                strResult += RuleFirst(tauK, tauTheta);

                strResult += RuleSecond(tauK, tauTheta);

                strResult += RuleThird(tauK, tauPsi);

                return strResult;
            }
        }

        private string RuleFirst(double tauK, double tauTheta)
        {
            if ((tauK / tauTheta > 0.8) && (tauK / tauTheta < 1.2))
                return "\nОбнаружен основной резонанс бортовой качки!";
            else return "";
        }

        private string RuleSecond(double tauK, double tauTheta)
        {
            if ((tauK / tauTheta > 1.85) && (tauK / tauTheta < 2.15))
                return "\nОбнаружен параметрический резонанс бортовой качки!";
            else return "";
        }

        private string RuleThird(double tauK, double tauPsi)
        {
            if ((tauK / tauPsi > 0.8) && (tauK / tauPsi < 1.2))
                return "\nОбнаружен основной резонанс килевой качки!";
            else return "";
        }

    }
}
