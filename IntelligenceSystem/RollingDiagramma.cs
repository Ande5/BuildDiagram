using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace IntelligenceSystem
{
    public partial class RollingDiagramma : Form
    {

        DataBase data_base = new DataBase();
        SystemLogicalRules system_logic;
        ConditionalProbability conditional_probability = new ConditionalProbability();
        public RollingDiagramma()
        {
            InitializeComponent();
           // this.Size = new Size(975, 398);
        }

        private void RollingDiagramma_Load(object sender, EventArgs e)
        {
            LoadVariant(data_base.GetVariant(5));
        }

        private void LoadVariant(Variant variant_base)
        {
            textLengthShip.Text = variant_base.m_length.ToString();
            textWidthShip.Text = variant_base.m_weight.ToString();
            textDraftShip.Text = variant_base.m_draft.ToString();
            textMetacentr.Text = variant_base.m_metacentricHeight.ToString();
            textSpeedShip.Text = variant_base.m_speed.ToString();
            textWavelength.Text = variant_base.m_waveLength.ToString();
            textAmplityda.Text = variant_base.m_thetaM.ToString();

            textPE.Text = variant_base.m_val0.ToString();
            textPHE.Text = variant_base.m_val1.ToString();
            textPHNOTE.Text = variant_base.m_val2.ToString();
            textMDHE1.Text = variant_base.m_val3.ToString();
            textMDHE2.Text = variant_base.m_val4.ToString();

            system_logic = new SystemLogicalRules(double.Parse(textWavelength.Text), double.Parse(textSpeedShip.Text), double.Parse(textWidthShip.Text),
                                                    double.Parse(textDraftShip.Text), double.Parse(textMetacentr.Text));

           // conditional_probability.MDhe1 = variant_base.m_val3.ToString();
          //  textResult.Text += Convert.ToString(conditional_probability.GetProbability(variant_base.m_val1, variant_base.m_val0, variant_base.m_val2, variant_base.m_val3, variant_base.m_val4));

        }
        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelBortResonanse.Visible = false;
            panelKeelResonanse.Visible = false;
            ClearToolStripMenuItem.Enabled = false;
        }

        private void ControlWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1323,398);
        }

        private void butResult_Click(object sender, EventArgs e)
        {
            try
            {
                textResult.Text = system_logic.LogicFunc(Convert.ToDouble(textHeadingAngle.Text));
                textResult.Text += Environment.NewLine + string.Format("При {0} градусах кусового угла!", textHeadingAngle.Text);
            }
            catch
            {
                MessageBox.Show("Проверте правильность введенных полей!", "Ошибка ввода!");
            }
           // ShowResonance();
        }
        private void ShowResonance()
        {
            List<int> resonanse_bort = new List<int>();
            List<int> resonanse_keel= new List<int>();
            List<int> resonanse_bort_parm = new List<int>();
            for (int k = 0; k <= 180; k++ )
            {
                if (system_logic.LogicFunc(k) == "\nОбнаружен основной резонанс бортовой качки!")
                {
                    resonanse_bort.Add(k);
                }
                if (system_logic.LogicFunc(k)== "\nОбнаружен основной резонанс килевой качки!")
                {
                    resonanse_keel.Add(k);
                }
                if (system_logic.LogicFunc(k) == "\nОбнаружен параметрический резонанс бортовой качки!")
                {
                    resonanse_bort_parm.Add(k);
                }
            }
            panelBortResonanse.BackColor = Color.FromArgb(100, 0, 0, 0);
            panelBortResonanse.Location = new Point(resonanse_bort[0] + 135, 3);
            panelBortResonanse.Width = resonanse_bort[resonanse_bort.Count-1]-20;
            panelBortResonanse.Visible = true;

            panelKeelResonanse.BackColor = Color.FromArgb(100, 0, 0, 0);
            panelKeelResonanse.Location = new Point(resonanse_keel[0] + 206, 3);
            panelKeelResonanse.Width = resonanse_keel[resonanse_keel.Count - 1] - 20;
            panelKeelResonanse.Visible = true;

            panelBort_ParmResonanse.BackColor = Color.FromArgb(100, 0, 0, 0);
            panelBort_ParmResonanse.Location = new Point(resonanse_bort_parm[0] + 112, 3);
            panelBort_ParmResonanse.Width = resonanse_bort_parm[resonanse_bort_parm.Count - 1]-55 ;
            panelBort_ParmResonanse.Visible = true;
        }

        private void butBuild_Click(object sender, EventArgs e)
        {
            ShowResonance();
            butBuild.Enabled = false;
        }

        private void ReloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowResonance();
        }

        private void butResultProbability_Click(object sender, EventArgs e)
        {
            double probability = conditional_probability.GetProbability(double.Parse(textPHE.Text), double.Parse(textPE.Text),
                                     double.Parse(textPHNOTE.Text), double.Parse(textMDHE1.Text), double.Parse(textMDHE2.Text));
            if (probability < 0.5)
            {
                textResult.Text += Environment.NewLine + string.Format(@"Достоверность возникновения сильной резонансной качки {0}", probability);
            } else
            {
                textResult.Text += Environment.NewLine + string.Format(@"{1}Достоверность возникновения сильной резонансной качки {0}{1}{1}Рекомендация – изменить курсовой угол и скорость судна, используя диаграмму качки.", probability, Environment.NewLine);
            }
        }

        private void butResultShow_Click(object sender, EventArgs e)
        {
            InfoDecisionMaking info_decision_making = new InfoDecisionMaking();
            double apparent_wave_period = info_decision_making.ApparentWavePeriod(double.Parse(textWavelength.Text), double.Parse(textSpeedShip.Text), double.Parse(textHeadingAngle.Text));
            double pitching = info_decision_making.Pitching(double.Parse(textDraftShip.Text));
            double rolling = info_decision_making.Rolling(double.Parse(textWidthShip.Text), double.Parse(textMetacentr.Text));

            textDecision.Text += string.Format("Кажущийся период волны {0:f4}", apparent_wave_period);
            textDecision.Text += string.Format("{1}{1}Собственные колебания килевой качки {0:f4}", pitching, Environment.NewLine);
            textDecision.Text += string.Format("{1}{1}Собственные колебания бортовой качки {0:f4}", rolling, Environment.NewLine);

            double get_bayes_value = conditional_probability.GetBayesValue(double.Parse(textPHE.Text), double.Parse(textPE.Text), double.Parse(textPHNOTE.Text));
            double get_shortloff_value = conditional_probability.GetShortloffValuie(double.Parse(textMDHE1.Text), double.Parse(textMDHE2.Text));

            textDecision.Text += string.Format("{1}{1}Решение по формуле Байеса {0}", get_bayes_value, Environment.NewLine);
            textDecision.Text += string.Format("{1}{1}Решение по формуле Шортлиффа {0}", get_shortloff_value, Environment.NewLine);
        }

     
    }
}
