using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace CoT_Simulator
{
    public partial class Form1 : Form
    {
        private string file;
        private string current_line;
        private string one_event_line;
        private List<string> event_list;
        private int sleep_length = 1000;
        private bool loaded_cot_flag = false;
        private int timeOut = 1000;

        /* SAMPLE COTS INPUT
            <event version="2.0" uid="****" how="m-r" time="2012-01-29T00:07:06Z" stale="2012-01-29T00:47:06Z" type="a-f-G" start="2012-01-29T00:07:06Z">
                <detail></detail>
                <point hae="0" lat="34.717305" lon="-86.676109" ce="25" le="10" />
            </event>
         */

        public Form1()
        {
            InitializeComponent();

            BUT_StartTransmit.Text = "Load File";

            event_list = new List<string>();
            get_random_id();

            TB_IP.Text = CoT_Simulator.Properties.Settings.Default.IP;
            TB_port.Text = CoT_Simulator.Properties.Settings.Default.Port.ToString();

            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        public void Open_File_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                file = openFileDialog1.FileName;
            }

            if (file != null)
            {
                TrackOptionsED(false); // turn off track option radio buttons
                BUT_StartTransmit.Text = "Transmit";
                loaded_cot_flag = true;

                CoT_Simulator.Properties.Settings.Default.LastFile = file;
                CoT_Simulator.Properties.Settings.Default.Save();

                try
                {
                    using (StreamReader read_line = new StreamReader(file))
                    {
                        while ((current_line = read_line.ReadLine()) != null)
                        {
                            parse_txt();
                        }
                    }
                }
                catch (IOException)
                {
                }

            }

        }

        private void TransmitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void parse_txt()
        {
            if (current_line.StartsWith("<?xml") == true)
                combine_line();
            else if (current_line.StartsWith("<event") == true)
            {
                assign_id();
                combine_line();
            }
            else if (current_line.StartsWith("<detail>") == true)
                combine_line();
            else if (current_line.StartsWith("<point") == true)
                combine_line();
            else if (current_line.StartsWith("</event>") == true)
            {
                combine_line();
                add_line_ToList();
            }
            else
                ;// MessageBox.Show("unknown line " + current_line.ToString());
        }

        // Updates stale time
        private string UpdateStaleTime(string _text)
        {
            string current_lineMod = _text;
            string _time = null;

            if(current_lineMod.Contains("stale=") == true && current_lineMod.Contains("time=") == true) // be sure that we are on a line that has a line called stale & time
            {
                DateTime staleTime;
                string tempJustTime = null;
                int howlongforstale = 0;
                try
                {
                    if (TB_howlongforstale.Text != null)
                    {
                        howlongforstale = Convert.ToInt32(TB_howlongforstale.Text);
                    }
                }
                catch 
                {
                    MessageBox.Show("error - enter a number");
                }

                _time = current_lineMod.Remove(0, current_lineMod.IndexOf("time")); // remove everything to the left of time field
                _time = _time.Remove(0, _time.IndexOf("\"")+1); // remove "time=" from string
                _time = _time.Remove(_time.IndexOf("\"")); // remove everything after the quote at the end of time
                

                int wheresStale = current_lineMod.IndexOf("stale");

                current_lineMod = current_lineMod.Remove(wheresStale + 6, 22); // remove stale time stamp

                staleTime = Convert.ToDateTime(_time); // convert _time string to actual DateTime
                staleTime = staleTime.AddSeconds(howlongforstale); // add how long for stale seconds to our new time
                tempJustTime = staleTime.ToLongTimeString().ToString(); // assign tempJustTime our new time as a string
                tempJustTime = tempJustTime.Remove(0, tempJustTime.IndexOf(':')+1); // remove everythign up to the :
                tempJustTime = tempJustTime.Remove(tempJustTime.Length - 3, 3); // remove last 3 digit "07:16 PM" -> 07:16
                _time = _time.Remove(_time.Length - 6, 6); // remove last 6 digits from _time "2012-01-29T00:07:01Z" -> "2012-01-29T00:"
                _time += tempJustTime + "Z"; // add the two together to get "2012-01-29T00:07:15Z"

                 // convert the updated time back to a string "2012-01-29T00:07:01Z"
                _time = "\"" + _time + "\"";

                current_lineMod = current_lineMod.Insert(wheresStale + 6, _time); // insert _time where stale used to be
            }

            return current_lineMod;

        }

        private void combine_line()
        {
            one_event_line = one_event_line + current_line;
        }


        private void add_line_ToList()
        {
            event_list.Add(one_event_line);
            one_event_line = "";
        }


        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (CoT_Simulator.Properties.Settings.Default.OutputTCP == true)
            {
                TCP();
            }
            else
            {
                UDP();
            }


        } // End backgroundworker1_DoWork

        private void TCP()
        {
            int port = Convert.ToInt32(TB_port.Text);
            IPAddress serverAddr = IPAddress.Parse(TB_IP.Text);

            TcpClient client = new TcpClient();

            IPEndPoint serverEndPoint = new IPEndPoint(serverAddr, port);

            client.SendTimeout = timeOut;
            try
            {
                client.Connect(serverEndPoint);

                NetworkStream clientStream = client.GetStream();

                ASCIIEncoding encoder = new ASCIIEncoding();
                bool restart = CoT_Simulator.Properties.Settings.Default.LoopFile;
                do
                {
                  
                    foreach (string text in event_list)
                    {
                        string outputTxt = text;

                        //if (staleData.Checked == true) // this means that we need to change the stale data time to equal the current time, so that it appears to be stale
                           outputTxt = UpdateStaleTime(text);

                        byte[] buffer = encoder.GetBytes(outputTxt);
                        clientStream.Write(buffer, 0, buffer.Length);
                        System.Threading.Thread.Sleep(sleep_length);
                    }

                } while (restart == true);
            }
            catch
            {
                MessageBox.Show("Server error... be sure that FalconPoint is running on destination computer.");
            }
        }

        private void UDP()
        {
             try
             {
                 int port = Convert.ToInt32(TB_port.Text);

                 Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                 IPAddress serverAddr = IPAddress.Parse(TB_IP.Text);
                 IPEndPoint endPoint = new IPEndPoint(serverAddr, port);

                 bool restart = CoT_Simulator.Properties.Settings.Default.LoopFile;
                 do
                 {
                     foreach (string text in event_list)
                     {
                         byte[] send_buffer = Encoding.ASCII.GetBytes(text);

                         sock.SendTo(send_buffer, endPoint);

                         System.Threading.Thread.Sleep(sleep_length);
                     }
                 } while (restart == true);
             }
             catch (IOException)
             {
             }
        }

        private void random_num_button(object sender, EventArgs e)
        {
            get_random_id();

        }

        private void get_random_id()
        {

            string UID = string.Format("{0:d}", DateTime.Now.Millisecond);
            
            if(Radio_air.Checked == true)
                TB_UID.Text = "A" + UID;

            if (Radio_car.Checked == true)
                TB_UID.Text = "C" + UID;

            if (Radio_foot.Checked == true)
                TB_UID.Text = "F" + UID;

            if (Radio_heli.Checked == true)
                TB_UID.Text = "H" + UID;
        }

        private void assign_id()
        {
            string UID = TB_UID.Text;
            int wheres_star = current_line.IndexOf("*");
            current_line = current_line.Remove(wheres_star, 4);
            current_line = current_line.Insert(wheres_star, UID);

        }

        private void BUT_StartTransmit_Click(object sender, EventArgs e)
        {   
            // if we have never loaded a file
            if (loaded_cot_flag == false)
            {
                Open_File_Click(sender, e);
            }
            else if (backgroundWorker1.IsBusy == true)
                backgroundWorker1.CancelAsync();
            else
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void iPsave1_MouseClick(object sender, MouseEventArgs e)
        {
            CoT_Simulator.Properties.Settings.Default.IP = TB_IP.Text;
            CoT_Simulator.Properties.Settings.Default.Save();
        }

        private void ConfigToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ConfigForm config = new ConfigForm();
            config.Show();
        }

        private void Radio_foot_CheckedChanged(object sender, EventArgs e)
        {
            get_random_id();
        }

        private void Radio_car_CheckedChanged(object sender, EventArgs e)
        {
            get_random_id();
        }

        private void Radio_air_CheckedChanged(object sender, EventArgs e)
        {
            get_random_id();
        }

        private void Radio_heli_CheckedChanged(object sender, EventArgs e)
        {
            get_random_id();
        }

        private void TrackOptionsED(bool _value)
        {

                Radio_air.Enabled = _value;
                Radio_car.Enabled = _value;
                Radio_foot.Enabled = _value;
                Radio_heli.Enabled = _value;

        }


        private void TB_howlongforstale_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }



    }
}
