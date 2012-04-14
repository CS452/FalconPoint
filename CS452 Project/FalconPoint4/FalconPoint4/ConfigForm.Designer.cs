namespace FalconPoint4
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
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioBoth = new System.Windows.Forms.RadioButton();
            this.RadioHeading = new System.Windows.Forms.RadioButton();
            this.RadioMPH = new System.Windows.Forms.RadioButton();
            this.RadioNone = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxDefaultIcon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_howLongForStale = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonLoadDefaultIcon = new System.Windows.Forms.Label();
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.clearScreen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(35, 34);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(246, 20);
            this.PortTextBox.TabIndex = 0;
            this.PortTextBox.Text = "3000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listening Port";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioBoth);
            this.groupBox1.Controls.Add(this.RadioHeading);
            this.groupBox1.Controls.Add(this.RadioMPH);
            this.groupBox1.Controls.Add(this.RadioNone);
            this.groupBox1.Location = new System.Drawing.Point(29, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 65);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Default Label";
            // 
            // RadioBoth
            // 
            this.RadioBoth.AutoSize = true;
            this.RadioBoth.Checked = true;
            this.RadioBoth.Location = new System.Drawing.Point(237, 28);
            this.RadioBoth.Name = "RadioBoth";
            this.RadioBoth.Size = new System.Drawing.Size(47, 17);
            this.RadioBoth.TabIndex = 3;
            this.RadioBoth.TabStop = true;
            this.RadioBoth.Text = "Both";
            this.RadioBoth.UseVisualStyleBackColor = true;
            // 
            // RadioHeading
            // 
            this.RadioHeading.AutoSize = true;
            this.RadioHeading.Location = new System.Drawing.Point(157, 28);
            this.RadioHeading.Name = "RadioHeading";
            this.RadioHeading.Size = new System.Drawing.Size(65, 17);
            this.RadioHeading.TabIndex = 2;
            this.RadioHeading.Text = "Heading";
            this.RadioHeading.UseVisualStyleBackColor = true;
            // 
            // RadioMPH
            // 
            this.RadioMPH.AutoSize = true;
            this.RadioMPH.Location = new System.Drawing.Point(91, 29);
            this.RadioMPH.Name = "RadioMPH";
            this.RadioMPH.Size = new System.Drawing.Size(49, 17);
            this.RadioMPH.TabIndex = 1;
            this.RadioMPH.Text = "MPH";
            this.RadioMPH.UseVisualStyleBackColor = true;
            // 
            // RadioNone
            // 
            this.RadioNone.AutoSize = true;
            this.RadioNone.Location = new System.Drawing.Point(23, 28);
            this.RadioNone.Name = "RadioNone";
            this.RadioNone.Size = new System.Drawing.Size(51, 17);
            this.RadioNone.TabIndex = 0;
            this.RadioNone.Text = "None";
            this.RadioNone.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Icon Folder Location";
            // 
            // TextBoxDefaultIcon
            // 
            this.TextBoxDefaultIcon.Location = new System.Drawing.Point(35, 85);
            this.TextBoxDefaultIcon.Name = "TextBoxDefaultIcon";
            this.TextBoxDefaultIcon.Size = new System.Drawing.Size(246, 20);
            this.TextBoxDefaultIcon.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "How long for stale data";
            // 
            // TB_howLongForStale
            // 
            this.TB_howLongForStale.Location = new System.Drawing.Point(35, 137);
            this.TB_howLongForStale.Name = "TB_howLongForStale";
            this.TB_howLongForStale.Size = new System.Drawing.Size(106, 20);
            this.TB_howLongForStale.TabIndex = 7;
            this.TB_howLongForStale.Text = "30";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(257, 273);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 9;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(176, 273);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 10;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonLoadDefaultIcon
            // 
            this.ButtonLoadDefaultIcon.AutoSize = true;
            this.ButtonLoadDefaultIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonLoadDefaultIcon.Location = new System.Drawing.Point(287, 85);
            this.ButtonLoadDefaultIcon.Name = "ButtonLoadDefaultIcon";
            this.ButtonLoadDefaultIcon.Size = new System.Drawing.Size(18, 15);
            this.ButtonLoadDefaultIcon.TabIndex = 16;
            this.ButtonLoadDefaultIcon.Text = "...";
            this.ButtonLoadDefaultIcon.Click += new System.EventHandler(this.ButtonLoadDefaultIcon_Click);
            // 
            // clearScreen
            // 
            this.clearScreen.Location = new System.Drawing.Point(29, 273);
            this.clearScreen.Name = "clearScreen";
            this.clearScreen.Size = new System.Drawing.Size(85, 23);
            this.clearScreen.TabIndex = 17;
            this.clearScreen.Text = "Clear Screen";
            this.clearScreen.UseVisualStyleBackColor = true;
            this.clearScreen.Click += new System.EventHandler(this.clearScreen_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 327);
            this.Controls.Add(this.clearScreen);
            this.Controls.Add(this.ButtonLoadDefaultIcon);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_howLongForStale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxDefaultIcon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortTextBox);
            this.MinimumSize = new System.Drawing.Size(370, 365);
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioBoth;
        private System.Windows.Forms.RadioButton RadioHeading;
        private System.Windows.Forms.RadioButton RadioMPH;
        private System.Windows.Forms.RadioButton RadioNone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxDefaultIcon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_howLongForStale;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Label ButtonLoadDefaultIcon;
        private System.Windows.Forms.OpenFileDialog OpenDialog;
        private System.Windows.Forms.Button clearScreen;
    }
}