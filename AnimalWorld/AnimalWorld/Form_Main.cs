using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorld
{
    public partial class Form_Main : Form, IView
    {
        public int LionCount { get; set; }
        public int AntelopeCount { get; set; }
        public int PumaCount { get; set; }
        public int WapitiCount { get; set; }
        public int TigerCount { get; set; }
        public int ElkCount { get; set; }
        public int Period { get; set; }
        public event EventHandler<EventArgs> updateModel;
        public event EventHandler<EventArgs> getPopulationResults;

        public Form_Main()
        {
            InitializeComponent();
            textBox_LionCount.Text = "0";
            textBox_AntelopeCount.Text = "0";
            textBox_PumaCount.Text = "0";
            textBox_WapitiCount.Text = "0";
            textBox_TigerCount.Text = "0";
            textBox_ElkCount.Text = "0";
            numericUpDown_PeriodCount.Value = 0;
        }

        private void textBox_LionCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void numericUpDown_PeriodCount_ValueChanged(object sender, EventArgs e)
        {
            Period = (int)numericUpDown_PeriodCount.Value;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_LionCount.Text = "0";
                textBox_AntelopeCount.Text = "0";
                textBox_PumaCount.Text = "0";
                textBox_WapitiCount.Text = "0";
                textBox_TigerCount.Text = "0";
                textBox_ElkCount.Text = "0";
                numericUpDown_PeriodCount.Value = 0;
                LionCount = 0;
                AntelopeCount = 0;
                PumaCount = 0;
                WapitiCount = 0;
                TigerCount = 0;
                ElkCount = 0;
                Period = 0;
                updateModel?.Invoke(this, EventArgs.Empty);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                Application.Exit();
            }
        }

        private void button_Iteration_Click(object sender, EventArgs e)
        {
            try
            {
                LionCount = Convert.ToInt32(textBox_LionCount.Text);
                AntelopeCount = Convert.ToInt32(textBox_AntelopeCount.Text);
                PumaCount = Convert.ToInt32(textBox_PumaCount.Text);
                WapitiCount = Convert.ToInt32(textBox_WapitiCount.Text);
                TigerCount = Convert.ToInt32(textBox_TigerCount.Text);
                ElkCount = Convert.ToInt32(textBox_ElkCount.Text);
                updateModel?.Invoke(this, EventArgs.Empty);
                getPopulationResults?.Invoke(this, EventArgs.Empty);
                textBox_LionCount.Text = LionCount.ToString();
                textBox_AntelopeCount.Text = AntelopeCount.ToString();
                textBox_PumaCount.Text = PumaCount.ToString();
                textBox_WapitiCount.Text = WapitiCount.ToString();
                textBox_TigerCount.Text = TigerCount.ToString();
                textBox_ElkCount.Text = ElkCount.ToString();
                numericUpDown_PeriodCount.Value = Period;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                Application.Exit();
            }
        }
    }
}
