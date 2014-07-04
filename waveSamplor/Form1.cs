using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace waveSamplor
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            SimulationChart.m_fXEndSYS = (float)(Math.PI * 2 + 0.5);
            SimulationChart.m_titleSize = 15;
            SimulationChart.m_titlePosition = 0.4f;
            SimulationChart.m_titleColor = Color.FromArgb(255, 255, 255);
            SimulationChart.m_titleBorderColor = Color.FromArgb(0, 64, 128);
            SimulationChart.m_backColorL = Color.FromArgb(0, 0, 0);
            SimulationChart.m_backColorH = Color.FromArgb(0, 64, 128);
            SimulationChart.m_coordinateLineColor = Color.FromArgb(0, 128, 255);
            SimulationChart.m_coordinateStringColor = Color.FromArgb(128, 255, 255);
            SimulationChart.m_coordinateStringTitleColor = Color.FromArgb(68, 189, 255);
            SimulationChart.m_iLineShowColorAlpha = 200;
            SimulationChart.m_iLineShowColor = Color.FromArgb(0, 128, 128);
            SimulationChart.m_GraphBackColor = Color.FromArgb(255, 255, 255);
            SimulationChart.m_ControlItemBackColor = Color.FromArgb(0, 64, 128);
            SimulationChart.m_ControlButtonBackColor = Color.FromArgb(0, 0, 0);
            SimulationChart.m_ControlButtonForeColorL = Color.FromArgb(0, 255, 255);
            SimulationChart.m_ControlButtonForeColorH = Color.FromArgb(0, 64, 128);
            SimulationChart.m_DirectionBackColor = Color.FromArgb(0, 0, 0);
            SimulationChart.m_DirectionForeColor = Color.FromArgb(255, 255, 0);
            SimulationChart.m_BigXYBackColor = Color.FromArgb(0, 64, 128);
            SimulationChart.m_BigXYButtonBackColor = Color.FromArgb(255, 128, 0);
            SimulationChart.m_BigXYButtonForeColor = Color.FromArgb(255, 255, 0);
            SimulationChart.Refresh();
        }

        int realDreference = 1000;
        int sampleCount, peakPos, peakNeg;//采样点数，波峰值，波谷值
        double referenceStep, realStep, offSet, Amplitude;//参考步进，实际步进，实际步进/参考步进=realDreference；

        List<float> realWave_x = new List<float>();
        List<float> realWave_y = new List<float>();
        List<float> realWaveVector_x = new List<float>();
        List<float> realWaveVector_y = new List<float>();
        List<float> referenceWave_x = new List<float>();
        List<float> referenceWave_y = new List<float>();
        private void generateButton_Click(object sender, EventArgs e)
        {
            sampleCount = Convert.ToInt32(countInput.Text);
            peakPos = Convert.ToInt32(maxInput.Text);
            peakNeg = Convert.ToInt32(minInput.Text);

            Amplitude = (peakPos - peakNeg) / 2;
            offSet = Amplitude + peakNeg;
            if (halfCycleCheck.Checked == true)
            {
                Amplitude = (peakPos - peakNeg);
                offSet = peakNeg;

                realStep = Math.PI / (sampleCount - 1);
                referenceStep = Math.PI / (realDreference - 1);
                SimulationChart.m_fXEndSYS = (float)(Math.PI + 0.5);
            }
            else
            {
                Amplitude = (peakPos - peakNeg) / 2;
                offSet = Amplitude + peakNeg;
                realStep = 2 * Math.PI / (sampleCount - 1);
                referenceStep = 2 * Math.PI / (realDreference - 1);
                SimulationChart.m_fXEndSYS = (float)(Math.PI * 2 + 0.5);
            }
            realWave_x.Clear(); realWave_y.Clear();
            referenceWave_x.Clear(); referenceWave_y.Clear(); realWaveVector_x.Clear(); realWaveVector_y.Clear();
            int i = 0;
            for (double stepAdd = 0; i < sampleCount; stepAdd += realStep, i++)
            {
                realWave_y.Add(Convert.ToInt32(Math.Sin(stepAdd) * Amplitude + offSet));
                realWave_x.Add((float)stepAdd);
            }
            i = 0;
            for (double stepAdd = 0; i < realDreference; stepAdd += referenceStep, i++)
            {
                referenceWave_y.Add(Convert.ToSingle(Math.Sin(stepAdd) * Amplitude + offSet));
                referenceWave_x.Add((float)stepAdd);
                //realWaveVector_x.Add((float)stepAdd);

            }
            if (vectorDrawCheck.Checked == true)
            {
                for (int m = 0; m < realWave_x.Count; m++)
                {
                    realWaveVector_x.Add(realWave_x[m]);
                    realWaveVector_y.Add(realWave_y[m]);

                    if (m + 1 < realWave_x.Count)
                    {
                        realWaveVector_x.Add(realWave_x[m + 1]);
                        realWaveVector_y.Add(realWave_y[m]);
                    }

                }

                //for (int m = 0, n = 1; m < realWaveVector_x.Count  && n < realWave_y.Count; m++) 
                //{
                //    if (realWaveVector_x[m] <=realWave_x[n])
                //    {
                //        realWaveVector_y.Add(realWave_y[n-1]);
                //    }
                //    else 
                //    {
                //        m--;
                //        n++;
                //    }
                //}
                //if (realWaveVector_x.Count > realWaveVector_y.Count) 
                //{
                //    realWaveVector_y.Add(realWaveVector_y[realWaveVector_y.Count -1]);
                //}
                //else if (realWaveVector_x.Count < realWaveVector_y.Count) 
                //{
                //    realWaveVector_y.RemoveAt(realWaveVector_y.Count - 1);
                //}
            }
            SimulationChart.m_fYBeginSYS = (float)(peakNeg - Amplitude / 10);
            SimulationChart.m_fYEndSYS = (float)(peakPos + Amplitude / 10);
            SimulationChart.f_ClearAllPix();
            SimulationChart.f_reXY();
            if (showRefWave.Checked == true)
            {
                SimulationChart.f_LoadOnePix(ref referenceWave_x, ref referenceWave_y, Color.Green, 1);
            }
            if (vectorDrawCheck.Checked == false)
            {
                SimulationChart.f_AddPix(ref realWave_x, ref realWave_y, Color.Red, 2);
            }
            else
            {
                SimulationChart.f_AddPix(ref realWaveVector_x, ref realWaveVector_y, Color.Red, 2);
            }

            if (dotShowCheck.Checked == true)
            {
                SimulationChart.f_AddPix(ref realWave_x, ref realWave_y, Color.Brown, 5, LineJoin.MiterClipped, LineCap.NoAnchor, ZhengJuyin.UI.ZGraph.DrawStyle.dot);
            }
            SimulationChart.f_Refresh();
            arrayOutput.Clear();
            arrayOutput.AppendText("const unsigned int " + arrayNameInput.Text + "[]{\n");
            for (int n = 0; n < realWave_y.Count; n++)
            {
                int temp = Convert.ToInt32(realWave_y[n]);
                if (hexOutPutCheck.Checked) { arrayOutput.AppendText("0x" + Convert.ToString(temp, 16) + ","); }
                else
                {
                    arrayOutput.AppendText(Convert.ToString(temp) + ",");
                }
            }
            arrayOutput.AppendText("\n");
            arrayOutput.AppendText("};");


        }

        private void countInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8) { }
            else { e.Handled = true; }
        }

        private void maxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8) { }
            else { e.Handled = true; }
        }

        private void minInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8) { }
            else { e.Handled = true; }
        }

        private void dotShowCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (arrayOutput.Text != "")
            {
                arrayOutput.SelectAll();
                arrayOutput.Copy();
                MessageBox.Show("Copy Success");
            }

        }

        private void SimulationChart_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Designed by FireKey Team:Fane.--http//www.fire-key.com", "Sampler",MessageBoxButtons .OK  , MessageBoxIcon.Asterisk);
        }
    }
}