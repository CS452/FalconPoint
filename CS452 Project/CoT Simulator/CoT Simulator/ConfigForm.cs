using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoT_Simulator
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
            PopulateGUIfromSettings();
        }

        private void PopulateGUIfromSettings()
        {
            IP_TB_config.Text = CoT_Simulator.Properties.Settings.Default.IP;
            Port_TB.Text = CoT_Simulator.Properties.Settings.Default.Port.ToString();

            if (CoT_Simulator.Properties.Settings.Default.LoopFile == true)
                CB_loop.Checked = true;
            else
                CB_loop.Checked = false;

            if (CoT_Simulator.Properties.Settings.Default.OutputTCP == true)
            {
                rbTCP.Checked = true;
                rbUDP.Checked = false;
            }
            else
            {
                rbTCP.Checked = false;
                rbUDP.Checked = true;
            }

        }

        private void SaveValuesToSettings()
        {
            CoT_Simulator.Properties.Settings.Default.IP = IP_TB_config.Text;
            CoT_Simulator.Properties.Settings.Default.Port = Convert.ToInt32(Port_TB.Text);

            if (CB_loop.Checked == true)
                CoT_Simulator.Properties.Settings.Default.LoopFile = true;
            else
                CoT_Simulator.Properties.Settings.Default.LoopFile = false;

            if (rbTCP.Checked == true)
            {
                CoT_Simulator.Properties.Settings.Default.OutputTCP = true;
                CoT_Simulator.Properties.Settings.Default.OutputUDP = false;
            }
            else
            {
                CoT_Simulator.Properties.Settings.Default.OutputTCP = false;
                CoT_Simulator.Properties.Settings.Default.OutputUDP = true;
            }

            CoT_Simulator.Properties.Settings.Default.Save();

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveValuesToSettings();
            this.Close();
        }





    }
}
