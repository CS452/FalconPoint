namespace CoT_Simulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransmitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TB_IP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_port = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BUT_StartTransmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_UID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Radio_heli = new System.Windows.Forms.RadioButton();
            this.Radio_air = new System.Windows.Forms.RadioButton();
            this.Radio_car = new System.Windows.Forms.RadioButton();
            this.Radio_foot = new System.Windows.Forms.RadioButton();
            this.iPsave1 = new CoT_Simulator.IPsave();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_howlongforstale = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.TransmitToolStripMenuItem,
            this.ConfigToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(302, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.openToolStripMenuItem.Text = "Open CoT File";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.Open_File_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.Close_Click);
            // 
            // TransmitToolStripMenuItem
            // 
            this.TransmitToolStripMenuItem.Name = "TransmitToolStripMenuItem";
            this.TransmitToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.TransmitToolStripMenuItem.Text = "Transmit";
            this.TransmitToolStripMenuItem.Click += new System.EventHandler(this.TransmitToolStripMenuItem_Click);
            // 
            // ConfigToolStripMenuItem
            // 
            this.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem";
            this.ConfigToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.ConfigToolStripMenuItem.Text = "Config";
            this.ConfigToolStripMenuItem.Click += new System.EventHandler(this.ConfigToolStripMenuItem_Click_1);
            // 
            // TB_IP
            // 
            this.TB_IP.Location = new System.Drawing.Point(16, 52);
            this.TB_IP.Name = "TB_IP";
            this.TB_IP.Size = new System.Drawing.Size(153, 20);
            this.TB_IP.TabIndex = 4;
            this.TB_IP.Text = "192.168.1.103";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Connect to IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port";
            // 
            // TB_port
            // 
            this.TB_port.Location = new System.Drawing.Point(206, 52);
            this.TB_port.Name = "TB_port";
            this.TB_port.Size = new System.Drawing.Size(73, 20);
            this.TB_port.TabIndex = 6;
            this.TB_port.Text = "3000";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // BUT_StartTransmit
            // 
            this.BUT_StartTransmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_StartTransmit.Location = new System.Drawing.Point(21, 251);
            this.BUT_StartTransmit.Name = "BUT_StartTransmit";
            this.BUT_StartTransmit.Size = new System.Drawing.Size(263, 77);
            this.BUT_StartTransmit.TabIndex = 9;
            this.BUT_StartTransmit.Text = "Start Transmit";
            this.BUT_StartTransmit.UseVisualStyleBackColor = true;
            this.BUT_StartTransmit.Click += new System.EventHandler(this.BUT_StartTransmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Unique ID\r\n";
            // 
            // TB_UID
            // 
            this.TB_UID.Location = new System.Drawing.Point(16, 102);
            this.TB_UID.Name = "TB_UID";
            this.TB_UID.Size = new System.Drawing.Size(153, 20);
            this.TB_UID.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(182, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "...";
            this.label4.Click += new System.EventHandler(this.random_num_button);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Radio_heli);
            this.groupBox1.Controls.Add(this.Radio_air);
            this.groupBox1.Controls.Add(this.Radio_car);
            this.groupBox1.Controls.Add(this.Radio_foot);
            this.groupBox1.Location = new System.Drawing.Point(16, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 44);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // Radio_heli
            // 
            this.Radio_heli.AutoSize = true;
            this.Radio_heli.Location = new System.Drawing.Point(176, 19);
            this.Radio_heli.Name = "Radio_heli";
            this.Radio_heli.Size = new System.Drawing.Size(43, 17);
            this.Radio_heli.TabIndex = 3;
            this.Radio_heli.Text = "Heli";
            this.Radio_heli.UseVisualStyleBackColor = true;
            this.Radio_heli.CheckedChanged += new System.EventHandler(this.Radio_heli_CheckedChanged);
            // 
            // Radio_air
            // 
            this.Radio_air.AutoSize = true;
            this.Radio_air.Location = new System.Drawing.Point(110, 19);
            this.Radio_air.Name = "Radio_air";
            this.Radio_air.Size = new System.Drawing.Size(63, 17);
            this.Radio_air.TabIndex = 2;
            this.Radio_air.Text = "Airplane";
            this.Radio_air.UseVisualStyleBackColor = true;
            this.Radio_air.CheckedChanged += new System.EventHandler(this.Radio_air_CheckedChanged);
            // 
            // Radio_car
            // 
            this.Radio_car.AutoSize = true;
            this.Radio_car.Checked = true;
            this.Radio_car.Location = new System.Drawing.Point(64, 19);
            this.Radio_car.Name = "Radio_car";
            this.Radio_car.Size = new System.Drawing.Size(41, 17);
            this.Radio_car.TabIndex = 1;
            this.Radio_car.TabStop = true;
            this.Radio_car.Text = "Car";
            this.Radio_car.UseVisualStyleBackColor = true;
            this.Radio_car.CheckedChanged += new System.EventHandler(this.Radio_car_CheckedChanged);
            // 
            // Radio_foot
            // 
            this.Radio_foot.AutoSize = true;
            this.Radio_foot.Location = new System.Drawing.Point(12, 19);
            this.Radio_foot.Name = "Radio_foot";
            this.Radio_foot.Size = new System.Drawing.Size(46, 17);
            this.Radio_foot.TabIndex = 0;
            this.Radio_foot.Text = "Foot";
            this.Radio_foot.UseVisualStyleBackColor = true;
            this.Radio_foot.CheckedChanged += new System.EventHandler(this.Radio_foot_CheckedChanged);
            // 
            // iPsave1
            // 
            this.iPsave1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iPsave1.BackgroundImage")));
            this.iPsave1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iPsave1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iPsave1.Location = new System.Drawing.Point(171, 46);
            this.iPsave1.Margin = new System.Windows.Forms.Padding(0);
            this.iPsave1.Name = "iPsave1";
            this.iPsave1.Size = new System.Drawing.Size(27, 30);
            this.iPsave1.TabIndex = 20;
            this.iPsave1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.iPsave1_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Make data this much older than send time (secs)";
            // 
            // TB_howlongforstale
            // 
            this.TB_howlongforstale.Location = new System.Drawing.Point(23, 200);
            this.TB_howlongforstale.Name = "TB_howlongforstale";
            this.TB_howlongforstale.Size = new System.Drawing.Size(91, 20);
            this.TB_howlongforstale.TabIndex = 30;
            this.TB_howlongforstale.Text = "5";
            this.TB_howlongforstale.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TB_howlongforstale_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 353);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_howlongforstale);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.iPsave1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_UID);
            this.Controls.Add(this.BUT_StartTransmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_port);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_IP);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "COT Simulator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TransmitToolStripMenuItem;
        private System.Windows.Forms.TextBox TB_IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_port;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BUT_StartTransmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_UID;
        private System.Windows.Forms.Label label4;
        private IPsave iPsave1;
        private System.Windows.Forms.ToolStripMenuItem ConfigToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Radio_heli;
        private System.Windows.Forms.RadioButton Radio_air;
        private System.Windows.Forms.RadioButton Radio_car;
        private System.Windows.Forms.RadioButton Radio_foot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_howlongforstale;

    }
}

