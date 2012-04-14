namespace CoT_Simulator
{
    partial class ConfigForm
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
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.Port_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IP_TB_config = new System.Windows.Forms.TextBox();
            this.rbUDP = new System.Windows.Forms.RadioButton();
            this.rbTCP = new System.Windows.Forms.RadioButton();
            this.CB_loop = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(127, 229);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 25;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(208, 229);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 24;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Broadcast Port";
            // 
            // Port_TB
            // 
            this.Port_TB.Location = new System.Drawing.Point(12, 74);
            this.Port_TB.Name = "Port_TB";
            this.Port_TB.Size = new System.Drawing.Size(246, 20);
            this.Port_TB.TabIndex = 17;
            this.Port_TB.Text = "3000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Default IP";
            // 
            // IP_TB_config
            // 
            this.IP_TB_config.Location = new System.Drawing.Point(12, 30);
            this.IP_TB_config.Name = "IP_TB_config";
            this.IP_TB_config.Size = new System.Drawing.Size(246, 20);
            this.IP_TB_config.TabIndex = 26;
            // 
            // rbUDP
            // 
            this.rbUDP.AutoSize = true;
            this.rbUDP.Location = new System.Drawing.Point(80, 26);
            this.rbUDP.Name = "rbUDP";
            this.rbUDP.Size = new System.Drawing.Size(48, 17);
            this.rbUDP.TabIndex = 31;
            this.rbUDP.Text = "UDP";
            this.rbUDP.UseVisualStyleBackColor = true;
            // 
            // rbTCP
            // 
            this.rbTCP.AutoSize = true;
            this.rbTCP.Checked = true;
            this.rbTCP.Location = new System.Drawing.Point(13, 26);
            this.rbTCP.Name = "rbTCP";
            this.rbTCP.Size = new System.Drawing.Size(61, 17);
            this.rbTCP.TabIndex = 32;
            this.rbTCP.TabStop = true;
            this.rbTCP.Text = "TCP/IP";
            this.rbTCP.UseVisualStyleBackColor = true;
            // 
            // CB_loop
            // 
            this.CB_loop.AutoSize = true;
            this.CB_loop.Checked = true;
            this.CB_loop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_loop.Location = new System.Drawing.Point(12, 110);
            this.CB_loop.Name = "CB_loop";
            this.CB_loop.Size = new System.Drawing.Size(75, 17);
            this.CB_loop.TabIndex = 30;
            this.CB_loop.Text = "Loop File?";
            this.CB_loop.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbUDP);
            this.groupBox1.Controls.Add(this.rbTCP);
            this.groupBox1.Location = new System.Drawing.Point(11, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 52);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output Protocol";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 265);
            this.Controls.Add(this.CB_loop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IP_TB_config);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Port_TB);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigForm";
            this.Text = "Config";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.OpenFileDialog OpenDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Port_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IP_TB_config;
        private System.Windows.Forms.RadioButton rbUDP;
        private System.Windows.Forms.RadioButton rbTCP;
        private System.Windows.Forms.CheckBox CB_loop;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}