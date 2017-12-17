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
        SystemLogicalRules system_logic = new SystemLogicalRules();
        public RollingDiagramma()
        {
            InitializeComponent();
           // this.Size = new Size(975, 398);
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0,0,0);
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
     
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
           
        }
        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            ClearToolStripMenuItem.Enabled = false;
        }

        private void ControlWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1323,398);
        }

        private void butResult_Click(object sender, EventArgs e)
        {

        }

        private void butResult_Click_1(object sender, EventArgs e)
        {
            Variant variant_base = data_base.GetVariant(5);
            textResult.Text = system_logic.LogicFunc(variant_base.m_waveLength, variant_base.m_speed, Convert.ToDouble(textHeadingAngle.Text), variant_base.m_weight,
                                         variant_base.m_draft, variant_base.m_metacentricHeight);
            textResult.Text += string.Format("При {0} градусах", textHeadingAngle.Text); 
        }
    }
}
