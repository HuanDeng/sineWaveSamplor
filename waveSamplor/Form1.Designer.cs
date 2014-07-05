namespace waveSamplor
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.SimulationChart = new ZhengJuyin.UI.ZGraph();
            this.countInput = new System.Windows.Forms.TextBox();
            this.maxInput = new System.Windows.Forms.TextBox();
            this.minInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.arrayNameInput = new System.Windows.Forms.TextBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.hexOutPutCheck = new System.Windows.Forms.CheckBox();
            this.halfCycleCheck = new System.Windows.Forms.CheckBox();
            this.vectorDrawCheck = new System.Windows.Forms.CheckBox();
            this.showRefWave = new System.Windows.Forms.CheckBox();
            this.arrayOutput = new System.Windows.Forms.RichTextBox();
            this.dotShowCheck = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SimulationChart
            // 
            this.SimulationChart.BackColor = System.Drawing.Color.White;
            this.SimulationChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SimulationChart.Location = new System.Drawing.Point(6, 23);
            this.SimulationChart.m_backColorH = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.SimulationChart.m_backColorL = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SimulationChart.m_BigXYBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SimulationChart.m_BigXYButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SimulationChart.m_BigXYButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SimulationChart.m_ControlButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SimulationChart.m_ControlButtonForeColorH = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.SimulationChart.m_ControlButtonForeColorL = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.SimulationChart.m_ControlItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SimulationChart.m_coordinateLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SimulationChart.m_coordinateStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SimulationChart.m_coordinateStringTitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SimulationChart.m_DirectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SimulationChart.m_DirectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SimulationChart.m_fXBeginSYS = -0.5F;
            this.SimulationChart.m_fXEndSYS = 7.28F;
            this.SimulationChart.m_fYBeginSYS = 0F;
            this.SimulationChart.m_fYEndSYS = 1F;
            this.SimulationChart.m_GraphBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SimulationChart.m_iLineShowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SimulationChart.m_iLineShowColorAlpha = 100;
            this.SimulationChart.m_SySnameX = "Time";
            this.SimulationChart.m_SySnameY = "Peak";
            this.SimulationChart.m_SyStitle = " Simulation Chart";
            this.SimulationChart.m_titleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.SimulationChart.m_titleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SimulationChart.m_titlePosition = 0.4F;
            this.SimulationChart.m_titleSize = 14;
            this.SimulationChart.Margin = new System.Windows.Forms.Padding(0);
            this.SimulationChart.MinimumSize = new System.Drawing.Size(390, 270);
            this.SimulationChart.Name = "SimulationChart";
            this.SimulationChart.Size = new System.Drawing.Size(625, 270);
            this.SimulationChart.TabIndex = 0;
            this.SimulationChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SimulationChart_MouseMove);
            // 
            // countInput
            // 
            this.countInput.Location = new System.Drawing.Point(712, 25);
            this.countInput.Name = "countInput";
            this.countInput.Size = new System.Drawing.Size(85, 21);
            this.countInput.TabIndex = 2;
            this.countInput.Text = "50";
            this.countInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countInput_KeyPress);
            // 
            // maxInput
            // 
            this.maxInput.Location = new System.Drawing.Point(712, 52);
            this.maxInput.Name = "maxInput";
            this.maxInput.Size = new System.Drawing.Size(85, 21);
            this.maxInput.TabIndex = 3;
            this.maxInput.Text = "4096";
            this.maxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxInput_KeyPress);
            // 
            // minInput
            // 
            this.minInput.Location = new System.Drawing.Point(712, 79);
            this.minInput.Name = "minInput";
            this.minInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.minInput.Size = new System.Drawing.Size(85, 21);
            this.minInput.TabIndex = 4;
            this.minInput.Text = "0";
            this.minInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minInput_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Max Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(635, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Min Value:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.eXITToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(637, 297);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(160, 77);
            this.generateButton.TabIndex = 9;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Array Name:";
            // 
            // arrayNameInput
            // 
            this.arrayNameInput.Location = new System.Drawing.Point(712, 106);
            this.arrayNameInput.Name = "arrayNameInput";
            this.arrayNameInput.Size = new System.Drawing.Size(85, 21);
            this.arrayNameInput.TabIndex = 10;
            this.arrayNameInput.Text = "waveTable";
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(637, 380);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(160, 22);
            this.copyButton.TabIndex = 12;
            this.copyButton.Text = "Copy to Clipboard";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // hexOutPutCheck
            // 
            this.hexOutPutCheck.AutoSize = true;
            this.hexOutPutCheck.Location = new System.Drawing.Point(637, 264);
            this.hexOutPutCheck.Name = "hexOutPutCheck";
            this.hexOutPutCheck.Size = new System.Drawing.Size(84, 16);
            this.hexOutPutCheck.TabIndex = 13;
            this.hexOutPutCheck.Text = "Hex Output";
            this.hexOutPutCheck.UseVisualStyleBackColor = true;
            // 
            // halfCycleCheck
            // 
            this.halfCycleCheck.AutoSize = true;
            this.halfCycleCheck.Location = new System.Drawing.Point(637, 146);
            this.halfCycleCheck.Name = "halfCycleCheck";
            this.halfCycleCheck.Size = new System.Drawing.Size(126, 16);
            this.halfCycleCheck.TabIndex = 14;
            this.halfCycleCheck.Text = "Half-cycle Output";
            this.halfCycleCheck.UseVisualStyleBackColor = true;
            // 
            // vectorDrawCheck
            // 
            this.vectorDrawCheck.AutoSize = true;
            this.vectorDrawCheck.Checked = true;
            this.vectorDrawCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vectorDrawCheck.Location = new System.Drawing.Point(637, 236);
            this.vectorDrawCheck.Name = "vectorDrawCheck";
            this.vectorDrawCheck.Size = new System.Drawing.Size(108, 16);
            this.vectorDrawCheck.TabIndex = 16;
            this.vectorDrawCheck.Text = "Vector Drawing";
            this.vectorDrawCheck.UseVisualStyleBackColor = true;
            // 
            // showRefWave
            // 
            this.showRefWave.AutoSize = true;
            this.showRefWave.Location = new System.Drawing.Point(637, 176);
            this.showRefWave.Name = "showRefWave";
            this.showRefWave.Size = new System.Drawing.Size(138, 16);
            this.showRefWave.TabIndex = 18;
            this.showRefWave.Text = "Show Reference Wave";
            this.showRefWave.UseVisualStyleBackColor = true;
            // 
            // arrayOutput
            // 
            this.arrayOutput.Location = new System.Drawing.Point(6, 297);
            this.arrayOutput.Name = "arrayOutput";
            this.arrayOutput.ReadOnly = true;
            this.arrayOutput.Size = new System.Drawing.Size(625, 105);
            this.arrayOutput.TabIndex = 24;
            this.arrayOutput.Text = "";
            // 
            // dotShowCheck
            // 
            this.dotShowCheck.AutoSize = true;
            this.dotShowCheck.Location = new System.Drawing.Point(637, 206);
            this.dotShowCheck.Name = "dotShowCheck";
            this.dotShowCheck.Size = new System.Drawing.Size(114, 16);
            this.dotShowCheck.TabIndex = 17;
            this.dotShowCheck.Text = "Show Sample Dot";
            this.dotShowCheck.UseVisualStyleBackColor = true;
            this.dotShowCheck.CheckedChanged += new System.EventHandler(this.dotShowCheck_CheckedChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 407);
            this.Controls.Add(this.arrayOutput);
            this.Controls.Add(this.showRefWave);
            this.Controls.Add(this.dotShowCheck);
            this.Controls.Add(this.vectorDrawCheck);
            this.Controls.Add(this.halfCycleCheck);
            this.Controls.Add(this.hexOutPutCheck);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.arrayNameInput);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minInput);
            this.Controls.Add(this.maxInput);
            this.Controls.Add(this.countInput);
            this.Controls.Add(this.SimulationChart);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Single-cycle Sine Wave Samplor";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZhengJuyin.UI.ZGraph SimulationChart;
        private System.Windows.Forms.TextBox countInput;
        private System.Windows.Forms.TextBox maxInput;
        private System.Windows.Forms.TextBox minInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox arrayNameInput;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.CheckBox hexOutPutCheck;
        private System.Windows.Forms.CheckBox halfCycleCheck;
        private System.Windows.Forms.CheckBox vectorDrawCheck;
        private System.Windows.Forms.CheckBox showRefWave;
        private System.Windows.Forms.RichTextBox arrayOutput;
        private System.Windows.Forms.CheckBox dotShowCheck;



    }
}

