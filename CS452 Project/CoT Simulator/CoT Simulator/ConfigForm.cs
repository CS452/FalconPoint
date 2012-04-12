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
        }

        private void SaveValuesToSettings()
        {
            CoT_Simulator.Properties.Settings.Default.IP = IP_TB_config.Text;
            CoT_Simulator.Properties.Settings.Default.Port = Convert.ToInt16(Port_TB.Text);

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
