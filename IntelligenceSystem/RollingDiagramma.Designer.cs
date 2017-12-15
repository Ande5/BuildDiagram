namespace IntelligenceSystem
{
    partial class RollingDiagramma
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RollingDiagramma));
            this.groupDiagramma = new System.Windows.Forms.GroupBox();
            this.panelDiagram = new System.Windows.Forms.Panel();
            this.contextMenuDiagram = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelAmplityda = new System.Windows.Forms.Label();
            this.labelWavelength = new System.Windows.Forms.Label();
            this.labelHeadingAngle = new System.Windows.Forms.Label();
            this.labelSpeedShip = new System.Windows.Forms.Label();
            this.labelMetacentr = new System.Windows.Forms.Label();
            this.labelDraftShip = new System.Windows.Forms.Label();
            this.labelWidthShip = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelLengthShip = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.ControlWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupDiagramma.SuspendLayout();
            this.panelDiagram.SuspendLayout();
            this.contextMenuDiagram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDiagramma
            // 
            this.groupDiagramma.Controls.Add(this.panelDiagram);
            this.groupDiagramma.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupDiagramma.ForeColor = System.Drawing.Color.Black;
            this.groupDiagramma.Location = new System.Drawing.Point(12, 12);
            this.groupDiagramma.Name = "groupDiagramma";
            this.groupDiagramma.Size = new System.Drawing.Size(641, 341);
            this.groupDiagramma.TabIndex = 1;
            this.groupDiagramma.TabStop = false;
            this.groupDiagramma.Text = "Диаграмма качки";
            // 
            // panelDiagram
            // 
            this.panelDiagram.BackgroundImage = global::IntelligenceSystem.Properties.Resources._Diagramma2;
            this.panelDiagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelDiagram.ContextMenuStrip = this.contextMenuDiagram;
            this.panelDiagram.Controls.Add(this.panel3);
            this.panelDiagram.Controls.Add(this.panel2);
            this.panelDiagram.Location = new System.Drawing.Point(3, 18);
            this.panelDiagram.Name = "panelDiagram";
            this.panelDiagram.Size = new System.Drawing.Size(635, 317);
            this.panelDiagram.TabIndex = 0;
            // 
            // contextMenuDiagram
            // 
            this.contextMenuDiagram.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReloadToolStripMenuItem,
            this.ClearToolStripMenuItem,
            this.ControlWindowToolStripMenuItem});
            this.contextMenuDiagram.Name = "contextMenuDiagram";
            this.contextMenuDiagram.Size = new System.Drawing.Size(157, 104);
            // 
            // ReloadToolStripMenuItem
            // 
            this.ReloadToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadToolStripMenuItem.Image = global::IntelligenceSystem.Properties.Resources.Button_Reload;
            this.ReloadToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem";
            this.ReloadToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.ReloadToolStripMenuItem.Text = "Обновить";
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearToolStripMenuItem.Image = global::IntelligenceSystem.Properties.Resources.RSS_Feed_2;
            this.ClearToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.ClearToolStripMenuItem.Text = "Очистить";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(386, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 301);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(158, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(66, 301);
            this.panel2.TabIndex = 0;
            // 
            // visualStyler1
            // 
            this.visualStyler1.HostForm = this;
            this.visualStyler1.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler1.License")));
            this.visualStyler1.LoadVisualStyle(null, "SHADED (SHADEDA).vssf");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.labelAmplityda);
            this.groupBox1.Controls.Add(this.labelWavelength);
            this.groupBox1.Controls.Add(this.labelHeadingAngle);
            this.groupBox1.Controls.Add(this.labelSpeedShip);
            this.groupBox1.Controls.Add(this.labelMetacentr);
            this.groupBox1.Controls.Add(this.labelDraftShip);
            this.groupBox1.Controls.Add(this.labelWidthShip);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.labelLengthShip);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(659, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 342);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // textBox8
            // 
            this.textBox8.ForeColor = System.Drawing.Color.Black;
            this.textBox8.Location = new System.Drawing.Point(141, 224);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(141, 22);
            this.textBox8.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(141, 196);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(141, 22);
            this.textBox7.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(141, 168);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(141, 22);
            this.textBox6.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(141, 140);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(141, 22);
            this.textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(141, 112);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 22);
            this.textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(141, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 22);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(141, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 22);
            this.textBox2.TabIndex = 9;
            // 
            // labelAmplityda
            // 
            this.labelAmplityda.AutoSize = true;
            this.labelAmplityda.ForeColor = System.Drawing.Color.Black;
            this.labelAmplityda.Location = new System.Drawing.Point(16, 230);
            this.labelAmplityda.Name = "labelAmplityda";
            this.labelAmplityda.Size = new System.Drawing.Size(114, 16);
            this.labelAmplityda.TabIndex = 8;
            this.labelAmplityda.Text = "Амплитуда качки";
            // 
            // labelWavelength
            // 
            this.labelWavelength.AutoSize = true;
            this.labelWavelength.ForeColor = System.Drawing.Color.Black;
            this.labelWavelength.Location = new System.Drawing.Point(16, 202);
            this.labelWavelength.Name = "labelWavelength";
            this.labelWavelength.Size = new System.Drawing.Size(84, 16);
            this.labelWavelength.TabIndex = 7;
            this.labelWavelength.Text = "Длина волны";
            // 
            // labelHeadingAngle
            // 
            this.labelHeadingAngle.AutoSize = true;
            this.labelHeadingAngle.ForeColor = System.Drawing.Color.Black;
            this.labelHeadingAngle.Location = new System.Drawing.Point(16, 174);
            this.labelHeadingAngle.Name = "labelHeadingAngle";
            this.labelHeadingAngle.Size = new System.Drawing.Size(90, 16);
            this.labelHeadingAngle.TabIndex = 6;
            this.labelHeadingAngle.Text = "Курсовой угол";
            // 
            // labelSpeedShip
            // 
            this.labelSpeedShip.AutoSize = true;
            this.labelSpeedShip.ForeColor = System.Drawing.Color.Black;
            this.labelSpeedShip.Location = new System.Drawing.Point(16, 146);
            this.labelSpeedShip.Name = "labelSpeedShip";
            this.labelSpeedShip.Size = new System.Drawing.Size(118, 16);
            this.labelSpeedShip.TabIndex = 5;
            this.labelSpeedShip.Text = "Скорость корабля";
            // 
            // labelMetacentr
            // 
            this.labelMetacentr.AutoSize = true;
            this.labelMetacentr.ForeColor = System.Drawing.Color.Black;
            this.labelMetacentr.Location = new System.Drawing.Point(16, 110);
            this.labelMetacentr.Name = "labelMetacentr";
            this.labelMetacentr.Size = new System.Drawing.Size(127, 32);
            this.labelMetacentr.TabIndex = 4;
            this.labelMetacentr.Text = "Метацентрическая\r\n          высота";
            // 
            // labelDraftShip
            // 
            this.labelDraftShip.AutoSize = true;
            this.labelDraftShip.ForeColor = System.Drawing.Color.Black;
            this.labelDraftShip.Location = new System.Drawing.Point(16, 90);
            this.labelDraftShip.Name = "labelDraftShip";
            this.labelDraftShip.Size = new System.Drawing.Size(101, 16);
            this.labelDraftShip.TabIndex = 3;
            this.labelDraftShip.Text = "Осадка корабля";
            // 
            // labelWidthShip
            // 
            this.labelWidthShip.AutoSize = true;
            this.labelWidthShip.ForeColor = System.Drawing.Color.Black;
            this.labelWidthShip.Location = new System.Drawing.Point(16, 62);
            this.labelWidthShip.Name = "labelWidthShip";
            this.labelWidthShip.Size = new System.Drawing.Size(109, 16);
            this.labelWidthShip.TabIndex = 2;
            this.labelWidthShip.Text = "Ширина корабля";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(141, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 22);
            this.textBox1.TabIndex = 1;
            // 
            // labelLengthShip
            // 
            this.labelLengthShip.AutoSize = true;
            this.labelLengthShip.ForeColor = System.Drawing.Color.Black;
            this.labelLengthShip.Location = new System.Drawing.Point(16, 34);
            this.labelLengthShip.Name = "labelLengthShip";
            this.labelLengthShip.Size = new System.Drawing.Size(96, 16);
            this.labelLengthShip.TabIndex = 0;
            this.labelLengthShip.Text = "Длина корабля";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(971, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 341);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вычисления резонансных режимов качки";
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Location = new System.Drawing.Point(33, 33);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(273, 222);
            this.textBox9.TabIndex = 0;
            this.textBox9.Text = "вававав";
            // 
            // ControlWindowToolStripMenuItem
            // 
            this.ControlWindowToolStripMenuItem.Name = "ControlWindowToolStripMenuItem";
            this.ControlWindowToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.ControlWindowToolStripMenuItem.Text = "Свернуть";
            this.ControlWindowToolStripMenuItem.Click += new System.EventHandler(this.ControlWindowToolStripMenuItem_Click);
            // 
            // RollingDiagramma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 372);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupDiagramma);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RollingDiagramma";
            this.ShowIcon = false;
            this.Text = "Контроль резонансных режимов качки на волнении";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupDiagramma.ResumeLayout(false);
            this.panelDiagram.ResumeLayout(false);
            this.contextMenuDiagram.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDiagramma;
        private System.Windows.Forms.Panel panelDiagram;
        private System.Windows.Forms.Panel panel2;
        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelLengthShip;
        private System.Windows.Forms.Label labelAmplityda;
        private System.Windows.Forms.Label labelWavelength;
        private System.Windows.Forms.Label labelHeadingAngle;
        private System.Windows.Forms.Label labelSpeedShip;
        private System.Windows.Forms.Label labelMetacentr;
        private System.Windows.Forms.Label labelDraftShip;
        private System.Windows.Forms.Label labelWidthShip;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuDiagram;
        private System.Windows.Forms.ToolStripMenuItem ReloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ToolStripMenuItem ControlWindowToolStripMenuItem;
    }
}

