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
            system_logic = new SystemLogicalRules(variant_base.m_waveLength, variant_base.m_speed, variant_base.m_weight, 
                                                     variant_base.m_draft, variant_base.m_metacentricHeight);
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
            textResult.Text = system_logic.LogicFunc(Convert.ToDouble(textHeadingAngle.Text));
            textResult.Text += Environment.NewLine + string.Format("При {0} градусах кусового угла!", textHeadingAngle.Text);
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
            panelBortResonanse.Location = new Point(resonanse_bort[0] + 140, -3);
            panelBortResonanse.Width = resonanse_bort[resonanse_bort.Count-1]-20;
            panelBortResonanse.Visible = true;

            panelKeelResonanse.BackColor = Color.FromArgb(100, 0, 0, 0);
            panelKeelResonanse.Location = new Point(resonanse_keel[0] + 206, -3);
            panelKeelResonanse.Width = resonanse_keel[resonanse_keel.Count - 1] - 20;
            panelKeelResonanse.Visible = true;
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

     
    }
}
