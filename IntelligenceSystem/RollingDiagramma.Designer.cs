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
            this.ControlWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelKeelResonanse = new System.Windows.Forms.Panel();
            this.panelBortResonanse = new System.Windows.Forms.Panel();
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butResultProbability = new System.Windows.Forms.Button();
            this.butBuild = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textMDHE2 = new System.Windows.Forms.TextBox();
            this.textMDHE1 = new System.Windows.Forms.TextBox();
            this.textPHNOTE = new System.Windows.Forms.TextBox();
            this.textPHE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textPE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textAmplityda = new System.Windows.Forms.TextBox();
            this.textWavelength = new System.Windows.Forms.TextBox();
            this.textHeadingAngle = new System.Windows.Forms.TextBox();
            this.textSpeedShip = new System.Windows.Forms.TextBox();
            this.textMetacentr = new System.Windows.Forms.TextBox();
            this.textDraftShip = new System.Windows.Forms.TextBox();
            this.textWidthShip = new System.Windows.Forms.TextBox();
            this.labelAmplityda = new System.Windows.Forms.Label();
            this.labelWavelength = new System.Windows.Forms.Label();
            this.labelHeadingAngle = new System.Windows.Forms.Label();
            this.labelSpeedShip = new System.Windows.Forms.Label();
            this.labelMetacentr = new System.Windows.Forms.Label();
            this.labelDraftShip = new System.Windows.Forms.Label();
            this.labelWidthShip = new System.Windows.Forms.Label();
            this.textLengthShip = new System.Windows.Forms.TextBox();
            this.labelLengthShip = new System.Windows.Forms.Label();
            this.butResult = new System.Windows.Forms.Button();
            this.groupDiagramma.SuspendLayout();
            this.panelDiagram.SuspendLayout();
            this.contextMenuDiagram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.panelDiagram.BackgroundImage = global::IntelligenceSystem.Properties.Resources._Diagramma1;
            this.panelDiagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelDiagram.ContextMenuStrip = this.contextMenuDiagram;
            this.panelDiagram.Controls.Add(this.panelKeelResonanse);
            this.panelDiagram.Controls.Add(this.panelBortResonanse);
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
            this.contextMenuDiagram.Size = new System.Drawing.Size(141, 82);
            // 
            // ReloadToolStripMenuItem
            // 
            this.ReloadToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReloadToolStripMenuItem.Image = global::IntelligenceSystem.Properties.Resources.Button_Reload;
            this.ReloadToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem";
            this.ReloadToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.ReloadToolStripMenuItem.Text = "Обновить";
            this.ReloadToolStripMenuItem.Click += new System.EventHandler(this.ReloadToolStripMenuItem_Click);
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearToolStripMenuItem.Image = global::IntelligenceSystem.Properties.Resources.RSS_Feed_2;
            this.ClearToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.ClearToolStripMenuItem.Text = "Очистить";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // ControlWindowToolStripMenuItem
            // 
            this.ControlWindowToolStripMenuItem.Name = "ControlWindowToolStripMenuItem";
            this.ControlWindowToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.ControlWindowToolStripMenuItem.Text = "Свернуть";
            this.ControlWindowToolStripMenuItem.Click += new System.EventHandler(this.ControlWindowToolStripMenuItem_Click);
            // 
            // panelKeelResonanse
            // 
            this.panelKeelResonanse.Location = new System.Drawing.Point(386, -3);
            this.panelKeelResonanse.Name = "panelKeelResonanse";
            this.panelKeelResonanse.Size = new System.Drawing.Size(90, 301);
            this.panelKeelResonanse.TabIndex = 1;
            this.panelKeelResonanse.Visible = false;
            // 
            // panelBortResonanse
            // 
            this.panelBortResonanse.Location = new System.Drawing.Point(158, -3);
            this.panelBortResonanse.Name = "panelBortResonanse";
            this.panelBortResonanse.Size = new System.Drawing.Size(66, 301);
            this.panelBortResonanse.TabIndex = 0;
            this.panelBortResonanse.Visible = false;
            // 
            // visualStyler1
            // 
            this.visualStyler1.HostForm = this;
            this.visualStyler1.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler1.License")));
            this.visualStyler1.LoadVisualStyle(null, "SHADED (SHADEDA).vssf");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textResult);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(659, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 286);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вычисления резонансных режимов качки";
            // 
            // textResult
            // 
            this.textResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textResult.Location = new System.Drawing.Point(17, 33);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.Size = new System.Drawing.Size(298, 222);
            this.textResult.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butResultProbability);
            this.groupBox1.Controls.Add(this.butBuild);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.butResult);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 296);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // butResultProbability
            // 
            this.butResultProbability.Location = new System.Drawing.Point(536, 134);
            this.butResultProbability.Name = "butResultProbability";
            this.butResultProbability.Size = new System.Drawing.Size(90, 45);
            this.butResultProbability.TabIndex = 19;
            this.butResultProbability.Text = "Условная \r\nвероятность";
            this.butResultProbability.UseVisualStyleBackColor = true;
            this.butResultProbability.Click += new System.EventHandler(this.butResultProbability_Click);
            // 
            // butBuild
            // 
            this.butBuild.Location = new System.Drawing.Point(536, 33);
            this.butBuild.Name = "butBuild";
            this.butBuild.Size = new System.Drawing.Size(90, 39);
            this.butBuild.TabIndex = 18;
            this.butBuild.Text = "Построить \r\nдиагрмму";
            this.butBuild.UseVisualStyleBackColor = true;
            this.butBuild.Click += new System.EventHandler(this.butBuild_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textMDHE2);
            this.groupBox3.Controls.Add(this.textMDHE1);
            this.groupBox3.Controls.Add(this.textPHNOTE);
            this.groupBox3.Controls.Add(this.textPHE);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textPE);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(321, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 263);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Исходные оценки вероятности";
            // 
            // textMDHE2
            // 
            this.textMDHE2.ForeColor = System.Drawing.Color.Black;
            this.textMDHE2.Location = new System.Drawing.Point(98, 194);
            this.textMDHE2.Name = "textMDHE2";
            this.textMDHE2.Size = new System.Drawing.Size(86, 22);
            this.textMDHE2.TabIndex = 22;
            // 
            // textMDHE1
            // 
            this.textMDHE1.ForeColor = System.Drawing.Color.Black;
            this.textMDHE1.Location = new System.Drawing.Point(98, 151);
            this.textMDHE1.Name = "textMDHE1";
            this.textMDHE1.Size = new System.Drawing.Size(87, 22);
            this.textMDHE1.TabIndex = 21;
            // 
            // textPHNOTE
            // 
            this.textPHNOTE.ForeColor = System.Drawing.Color.Black;
            this.textPHNOTE.Location = new System.Drawing.Point(98, 111);
            this.textPHNOTE.Name = "textPHNOTE";
            this.textPHNOTE.Size = new System.Drawing.Size(87, 22);
            this.textPHNOTE.TabIndex = 20;
            // 
            // textPHE
            // 
            this.textPHE.ForeColor = System.Drawing.Color.Black;
            this.textPHE.Location = new System.Drawing.Point(98, 69);
            this.textPHE.Name = "textPHE";
            this.textPHE.Size = new System.Drawing.Size(87, 22);
            this.textPHE.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "MД(H/E2)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "MД(H/E1)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "P(H/NOT E)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "P(H/E)";
            // 
            // textPE
            // 
            this.textPE.ForeColor = System.Drawing.Color.Black;
            this.textPE.Location = new System.Drawing.Point(98, 27);
            this.textPE.Name = "textPE";
            this.textPE.Size = new System.Drawing.Size(87, 22);
            this.textPE.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(16, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "P(E)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textAmplityda);
            this.groupBox4.Controls.Add(this.textWavelength);
            this.groupBox4.Controls.Add(this.textHeadingAngle);
            this.groupBox4.Controls.Add(this.textSpeedShip);
            this.groupBox4.Controls.Add(this.textMetacentr);
            this.groupBox4.Controls.Add(this.textDraftShip);
            this.groupBox4.Controls.Add(this.textWidthShip);
            this.groupBox4.Controls.Add(this.labelAmplityda);
            this.groupBox4.Controls.Add(this.labelWavelength);
            this.groupBox4.Controls.Add(this.labelHeadingAngle);
            this.groupBox4.Controls.Add(this.labelSpeedShip);
            this.groupBox4.Controls.Add(this.labelMetacentr);
            this.groupBox4.Controls.Add(this.labelDraftShip);
            this.groupBox4.Controls.Add(this.labelWidthShip);
            this.groupBox4.Controls.Add(this.textLengthShip);
            this.groupBox4.Controls.Add(this.labelLengthShip);
            this.groupBox4.Location = new System.Drawing.Point(16, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(299, 263);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Исходные данные для систем логически правил";
            // 
            // textAmplityda
            // 
            this.textAmplityda.ForeColor = System.Drawing.Color.Black;
            this.textAmplityda.Location = new System.Drawing.Point(151, 217);
            this.textAmplityda.Name = "textAmplityda";
            this.textAmplityda.Size = new System.Drawing.Size(115, 22);
            this.textAmplityda.TabIndex = 31;
            // 
            // textWavelength
            // 
            this.textWavelength.ForeColor = System.Drawing.Color.Black;
            this.textWavelength.Location = new System.Drawing.Point(151, 189);
            this.textWavelength.Name = "textWavelength";
            this.textWavelength.Size = new System.Drawing.Size(115, 22);
            this.textWavelength.TabIndex = 30;
            // 
            // textHeadingAngle
            // 
            this.textHeadingAngle.ForeColor = System.Drawing.Color.Black;
            this.textHeadingAngle.Location = new System.Drawing.Point(151, 161);
            this.textHeadingAngle.Name = "textHeadingAngle";
            this.textHeadingAngle.Size = new System.Drawing.Size(115, 22);
            this.textHeadingAngle.TabIndex = 29;
            // 
            // textSpeedShip
            // 
            this.textSpeedShip.ForeColor = System.Drawing.Color.Black;
            this.textSpeedShip.Location = new System.Drawing.Point(151, 133);
            this.textSpeedShip.Name = "textSpeedShip";
            this.textSpeedShip.Size = new System.Drawing.Size(115, 22);
            this.textSpeedShip.TabIndex = 28;
            // 
            // textMetacentr
            // 
            this.textMetacentr.ForeColor = System.Drawing.Color.Black;
            this.textMetacentr.Location = new System.Drawing.Point(151, 105);
            this.textMetacentr.Name = "textMetacentr";
            this.textMetacentr.Size = new System.Drawing.Size(115, 22);
            this.textMetacentr.TabIndex = 27;
            // 
            // textDraftShip
            // 
            this.textDraftShip.ForeColor = System.Drawing.Color.Black;
            this.textDraftShip.Location = new System.Drawing.Point(151, 77);
            this.textDraftShip.Name = "textDraftShip";
            this.textDraftShip.Size = new System.Drawing.Size(115, 22);
            this.textDraftShip.TabIndex = 26;
            // 
            // textWidthShip
            // 
            this.textWidthShip.ForeColor = System.Drawing.Color.Black;
            this.textWidthShip.Location = new System.Drawing.Point(151, 49);
            this.textWidthShip.Name = "textWidthShip";
            this.textWidthShip.Size = new System.Drawing.Size(115, 22);
            this.textWidthShip.TabIndex = 25;
            // 
            // labelAmplityda
            // 
            this.labelAmplityda.AutoSize = true;
            this.labelAmplityda.ForeColor = System.Drawing.Color.Black;
            this.labelAmplityda.Location = new System.Drawing.Point(16, 220);
            this.labelAmplityda.Name = "labelAmplityda";
            this.labelAmplityda.Size = new System.Drawing.Size(114, 16);
            this.labelAmplityda.TabIndex = 24;
            this.labelAmplityda.Text = "Амплитуда качки";
            // 
            // labelWavelength
            // 
            this.labelWavelength.AutoSize = true;
            this.labelWavelength.ForeColor = System.Drawing.Color.Black;
            this.labelWavelength.Location = new System.Drawing.Point(16, 194);
            this.labelWavelength.Name = "labelWavelength";
            this.labelWavelength.Size = new System.Drawing.Size(84, 16);
            this.labelWavelength.TabIndex = 23;
            this.labelWavelength.Text = "Длина волны";
            // 
            // labelHeadingAngle
            // 
            this.labelHeadingAngle.AutoSize = true;
            this.labelHeadingAngle.ForeColor = System.Drawing.Color.Black;
            this.labelHeadingAngle.Location = new System.Drawing.Point(16, 167);
            this.labelHeadingAngle.Name = "labelHeadingAngle";
            this.labelHeadingAngle.Size = new System.Drawing.Size(90, 16);
            this.labelHeadingAngle.TabIndex = 22;
            this.labelHeadingAngle.Text = "Курсовой угол";
            // 
            // labelSpeedShip
            // 
            this.labelSpeedShip.AutoSize = true;
            this.labelSpeedShip.ForeColor = System.Drawing.Color.Black;
            this.labelSpeedShip.Location = new System.Drawing.Point(16, 139);
            this.labelSpeedShip.Name = "labelSpeedShip";
            this.labelSpeedShip.Size = new System.Drawing.Size(118, 16);
            this.labelSpeedShip.TabIndex = 21;
            this.labelSpeedShip.Text = "Скорость корабля";
            // 
            // labelMetacentr
            // 
            this.labelMetacentr.AutoSize = true;
            this.labelMetacentr.ForeColor = System.Drawing.Color.Black;
            this.labelMetacentr.Location = new System.Drawing.Point(16, 103);
            this.labelMetacentr.Name = "labelMetacentr";
            this.labelMetacentr.Size = new System.Drawing.Size(127, 32);
            this.labelMetacentr.TabIndex = 20;
            this.labelMetacentr.Text = "Метацентрическая\r\n          высота";
            // 
            // labelDraftShip
            // 
            this.labelDraftShip.AutoSize = true;
            this.labelDraftShip.ForeColor = System.Drawing.Color.Black;
            this.labelDraftShip.Location = new System.Drawing.Point(16, 83);
            this.labelDraftShip.Name = "labelDraftShip";
            this.labelDraftShip.Size = new System.Drawing.Size(101, 16);
            this.labelDraftShip.TabIndex = 19;
            this.labelDraftShip.Text = "Осадка корабля";
            // 
            // labelWidthShip
            // 
            this.labelWidthShip.AutoSize = true;
            this.labelWidthShip.ForeColor = System.Drawing.Color.Black;
            this.labelWidthShip.Location = new System.Drawing.Point(16, 55);
            this.labelWidthShip.Name = "labelWidthShip";
            this.labelWidthShip.Size = new System.Drawing.Size(109, 16);
            this.labelWidthShip.TabIndex = 18;
            this.labelWidthShip.Text = "Ширина корабля";
            // 
            // textLengthShip
            // 
            this.textLengthShip.ForeColor = System.Drawing.Color.Black;
            this.textLengthShip.Location = new System.Drawing.Point(151, 21);
            this.textLengthShip.Name = "textLengthShip";
            this.textLengthShip.Size = new System.Drawing.Size(115, 22);
            this.textLengthShip.TabIndex = 17;
            // 
            // labelLengthShip
            // 
            this.labelLengthShip.AutoSize = true;
            this.labelLengthShip.ForeColor = System.Drawing.Color.Black;
            this.labelLengthShip.Location = new System.Drawing.Point(16, 27);
            this.labelLengthShip.Name = "labelLengthShip";
            this.labelLengthShip.Size = new System.Drawing.Size(96, 16);
            this.labelLengthShip.TabIndex = 16;
            this.labelLengthShip.Text = "Длина корабля";
            // 
            // butResult
            // 
            this.butResult.Location = new System.Drawing.Point(536, 82);
            this.butResult.Name = "butResult";
            this.butResult.Size = new System.Drawing.Size(90, 25);
            this.butResult.TabIndex = 16;
            this.butResult.Text = "Считать";
            this.butResult.UseVisualStyleBackColor = true;
            this.butResult.Click += new System.EventHandler(this.butResult_Click);
            // 
            // RollingDiagramma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 686);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupDiagramma);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RollingDiagramma";
            this.ShowIcon = false;
            this.Text = "Контроль резонансных режимов качки на волнении";
            this.Load += new System.EventHandler(this.RollingDiagramma_Load);
            this.groupDiagramma.ResumeLayout(false);
            this.panelDiagram.ResumeLayout(false);
            this.contextMenuDiagram.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDiagramma;
        private System.Windows.Forms.Panel panelDiagram;
        private System.Windows.Forms.Panel panelBortResonanse;
        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
        private System.Windows.Forms.Panel panelKeelResonanse;
        private System.Windows.Forms.ContextMenuStrip contextMenuDiagram;
        private System.Windows.Forms.ToolStripMenuItem ReloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.ToolStripMenuItem ControlWindowToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textMDHE2;
        private System.Windows.Forms.TextBox textMDHE1;
        private System.Windows.Forms.TextBox textPHNOTE;
        private System.Windows.Forms.TextBox textPHE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textAmplityda;
        private System.Windows.Forms.TextBox textWavelength;
        private System.Windows.Forms.TextBox textHeadingAngle;
        private System.Windows.Forms.TextBox textSpeedShip;
        private System.Windows.Forms.TextBox textMetacentr;
        private System.Windows.Forms.TextBox textDraftShip;
        private System.Windows.Forms.TextBox textWidthShip;
        private System.Windows.Forms.Label labelAmplityda;
        private System.Windows.Forms.Label labelWavelength;
        private System.Windows.Forms.Label labelHeadingAngle;
        private System.Windows.Forms.Label labelSpeedShip;
        private System.Windows.Forms.Label labelMetacentr;
        private System.Windows.Forms.Label labelDraftShip;
        private System.Windows.Forms.Label labelWidthShip;
        private System.Windows.Forms.TextBox textLengthShip;
        private System.Windows.Forms.Label labelLengthShip;
        private System.Windows.Forms.Button butResult;
        private System.Windows.Forms.Button butBuild;
        private System.Windows.Forms.Button butResultProbability;
    }
}

