using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligenceSystem
{
    class ConditionalProbability
    {
        public double Pe { get; set; }
        public double PNe { get; set; }
        public double PhNotE { get; set; }
        public double MDhe1 { get; set; }
        public double MDhe2 { get; set; }

        public double GetBayesValue(double pHe, double pE, double phNotE)
        {
            return (pHe * pE + phNotE * (1 - pE)) + (1-pHe) * pE + pHe * (1 - pE);
        }

        public double GetShortloffValuie(double mDhe1, double mDhe2)
        {
            return mDhe1 + mDhe2 * (1 - mDhe1);
        }

        public double GetProbability(double pHe, double pE, double phNotE, double mDhe1, double mDhe2)
        {
            return (GetBayesValue(pHe, pE, phNotE) + GetShortloffValuie(mDhe1, mDhe2)) / 2;
        }
    }
}
