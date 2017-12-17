using System;

namespace IntelligenceSystem
{
    class SystemLogicalRules
    {
        private double m_lambda;
        private double m_speed;
        private double m_B, m_T, m_H;

        public SystemLogicalRules(double lambda, double speed, double B, double T, double H)
        {
            m_lambda = lambda;
            m_speed = speed;
            m_B = B; m_T = T; m_H = H;
        }

        public string LogicFunc(double phi)
        {
            if ((m_lambda <= 0) || (m_speed <= 0) || (m_B <= 0) || (m_T <= 0) || (m_H <= 0))
            {
                return "Данные введены неверно!";
            }
            else
            {
                // Вычисление скорости волны:

                double Cw = 1.25 * Math.Sqrt(m_lambda);

                // Вычисление кажущегося периода:

                double tauK = m_lambda / (Cw - m_speed * Math.Cos(phi * Math.PI / 180));

                // Вычисление собственного периода бортовой качки:

                double C = 0.8;

                double tauTheta = C * m_B / Math.Sqrt(m_H);

                // Вычисление собственного периода килевой качки:

                double tauPsi = 2.5 * Math.Sqrt(m_T);

                // Анализ и вывод результата:

                string strResult = "";

                strResult += RuleFirst(tauK, tauTheta);

                strResult += RuleSecond(tauK, tauTheta);

                strResult += RuleThird(tauK, tauPsi);

                return strResult == "" ? "Резонансных периодов не обнаружено." : strResult;
            }
        }

        private string RuleFirst(double tauK, double tauTheta)
        {
            if ((tauK / tauTheta > 0.8) && (tauK / tauTheta < 1.2))
                return "\nОбнаружен основной резонанс бортовой качки!";
            else return null;
        }

        private string RuleSecond(double tauK, double tauTheta)
        {
            if ((tauK / tauTheta > 1.85) && (tauK / tauTheta < 2.15))
                return "\nОбнаружен параметрический резонанс бортовой качки!";
            else return null;
        }

        private string RuleThird(double tauK, double tauPsi)
        {
            if ((tauK / tauPsi > 0.8) && (tauK / tauPsi < 1.2))
                return "\nОбнаружен основной резонанс килевой качки!";
            else return null;
        }

    }
}
