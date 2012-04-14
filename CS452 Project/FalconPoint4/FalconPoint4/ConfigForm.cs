using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FalconPoint4
{
    public partial class ConfigForm : Form
    {
        public COTsListener CotListenerConnection; // connection to cotlistener... kinda stupid, but is used to clear the screen

        public ConfigForm()
        {
            InitializeComponent();

            this.CenterToScreen();

            PopulateGUIfromSettings();

        }

        private void PopulateGUIfromSettings()
        {

            TextBoxDefaultIcon.Text = FalconPoint4.Properties.Settings.Default.DefaultIconFolder;
            TB_howLongForStale.Text = FalconPoint4.Properties.Settings.Default.HowLongForStale.ToString();
            PortTextBox.Text = FalconPoint4.Properties.Settings.Default.Port.ToString();

            //{MPH = 0, Bearing = 1, None = 2, Both = 3};
            if (FalconPoint4.Properties.Settings.Default.DefaultLabel == 3)
                RadioBoth.Checked = true;
            if (FalconPoint4.Properties.Settings.Default.DefaultLabel == 2)
                RadioNone.Checked = true;
            if (FalconPoint4.Properties.Settings.Default.DefaultLabel == 0)
                RadioMPH.Checked = true;
            if (FalconPoint4.Properties.Settings.Default.DefaultLabel == 1)
                RadioHeading.Checked = true;
                
        }

        private void SaveValuesToSettings()
        {
            FalconPoint4.Properties.Settings.Default.DefaultIconFolder = TextBoxDefaultIcon.Text;
            FalconPoint4.Properties.Settings.Default.HowLongForStale =Convert.ToInt32(TB_howLongForStale.Text);
            FalconPoint4.Properties.Settings.Default.Port = Convert.ToInt32(PortTextBox.Text);

            if (RadioBoth.Checked == true)
                FalconPoint4.Properties.Settings.Default.DefaultLabel = 3;

            if (RadioHeading.Checked == true)
                FalconPoint4.Properties.Settings.Default.DefaultLabel = 1;

            if (RadioMPH.Checked == true)
                FalconPoint4.Properties.Settings.Default.DefaultLabel = 0;

            if (RadioNone.Checked == true)
                FalconPoint4.Properties.Settings.Default.DefaultLabel = 2;

            FalconPoint4.Properties.Settings.Default.Save();

        }

        private void ButtonLoadDefaultIcon_Click(object sender, EventArgs e)
        {
            string file = null;

            folderBrowserDialog1.SelectedPath = FalconPoint4.Properties.Settings.Default.DefaultIconFolder;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            //DialogResult result = OpenDialog.ShowDialog();


            if (result == DialogResult.OK)
            {
                file = folderBrowserDialog1.SelectedPath;
                //file = OpenDialog.FileName;
                TextBoxDefaultIcon.Text = file + "\\"; ;
                FalconPoint4.Properties.Settings.Default.DefaultIconFolder = TextBoxDefaultIcon.Text;
                FalconPoint4.Properties.Settings.Default.Save();
            }


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

        private void clearScreen_Click(object sender, EventArgs e)
        {
            CotListenerConnection.ClearScreen();
            this.Close();
        }


    }
}
