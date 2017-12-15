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
       
        public RollingDiagramma()
        {
            InitializeComponent();
            this.Size = new Size(975, 398);
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0,0,0);
            panel3.BackColor = Color.FromArgb(110, 0, 0, 0);
           
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
    }
}
