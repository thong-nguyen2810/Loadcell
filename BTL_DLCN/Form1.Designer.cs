namespace BTL_DLCN
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
            this.RS232 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbStop = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbLength = new System.Windows.Forms.ComboBox();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalib = new System.Windows.Forms.Button();
            this.btnTare = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCalibInput = new System.Windows.Forms.TextBox();
            this.btnSetCalib = new System.Windows.Forms.Button();
            this.RS232.SuspendLayout();
            this.SuspendLayout();
            // 
            // RS232
            // 
            this.RS232.Controls.Add(this.btnConnect);
            this.RS232.Controls.Add(this.label6);
            this.RS232.Controls.Add(this.label7);
            this.RS232.Controls.Add(this.label8);
            this.RS232.Controls.Add(this.label9);
            this.RS232.Controls.Add(this.label10);
            this.RS232.Controls.Add(this.cbStop);
            this.RS232.Controls.Add(this.cbParity);
            this.RS232.Controls.Add(this.cbLength);
            this.RS232.Controls.Add(this.cbBaud);
            this.RS232.Controls.Add(this.cbPort);
            this.RS232.Location = new System.Drawing.Point(28, 12);
            this.RS232.Name = "RS232";
            this.RS232.Size = new System.Drawing.Size(264, 269);
            this.RS232.TabIndex = 11;
            this.RS232.TabStop = false;
            this.RS232.Text = "RS232";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Lime;
            this.btnConnect.Location = new System.Drawing.Point(16, 217);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(104, 37);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Stopbit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Parity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Length";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Baudrate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Port";
            // 
            // cbStop
            // 
            this.cbStop.FormattingEnabled = true;
            this.cbStop.Location = new System.Drawing.Point(128, 182);
            this.cbStop.Name = "cbStop";
            this.cbStop.Size = new System.Drawing.Size(121, 24);
            this.cbStop.TabIndex = 4;
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(128, 142);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 24);
            this.cbParity.TabIndex = 3;
            // 
            // cbLength
            // 
            this.cbLength.FormattingEnabled = true;
            this.cbLength.Location = new System.Drawing.Point(128, 101);
            this.cbLength.Name = "cbLength";
            this.cbLength.Size = new System.Drawing.Size(121, 24);
            this.cbLength.TabIndex = 2;
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Location = new System.Drawing.Point(128, 60);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(121, 24);
            this.cbBaud.TabIndex = 1;
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(128, 21);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(121, 24);
            this.cbPort.TabIndex = 0;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(423, 12);
            this.txtWeight.Multiline = true;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(178, 71);
            this.txtWeight.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(349, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Weight";
            // 
            // btnCalib
            // 
            this.btnCalib.BackColor = System.Drawing.Color.Yellow;
            this.btnCalib.Location = new System.Drawing.Point(352, 292);
            this.btnCalib.Name = "btnCalib";
            this.btnCalib.Size = new System.Drawing.Size(135, 73);
            this.btnCalib.TabIndex = 14;
            this.btnCalib.Text = "Calibrate";
            this.btnCalib.UseVisualStyleBackColor = false;
            this.btnCalib.Click += new System.EventHandler(this.btnCalib_Click);
            // 
            // btnTare
            // 
            this.btnTare.BackColor = System.Drawing.Color.Fuchsia;
            this.btnTare.Location = new System.Drawing.Point(545, 292);
            this.btnTare.Name = "btnTare";
            this.btnTare.Size = new System.Drawing.Size(136, 73);
            this.btnTare.TabIndex = 15;
            this.btnTare.Text = "Tare";
            this.btnTare.UseVisualStyleBackColor = false;
            this.btnTare.Click += new System.EventHandler(this.btnTare_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(423, 102);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(340, 164);
            this.txtLog.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Log";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(41, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Set Calib Weight";
            // 
            // txtCalibInput
            // 
            this.txtCalibInput.Location = new System.Drawing.Point(158, 292);
            this.txtCalibInput.Multiline = true;
            this.txtCalibInput.Name = "txtCalibInput";
            this.txtCalibInput.Size = new System.Drawing.Size(119, 33);
            this.txtCalibInput.TabIndex = 19;
            // 
            // btnSetCalib
            // 
            this.btnSetCalib.BackColor = System.Drawing.Color.Yellow;
            this.btnSetCalib.Location = new System.Drawing.Point(99, 331);
            this.btnSetCalib.Name = "btnSetCalib";
            this.btnSetCalib.Size = new System.Drawing.Size(102, 39);
            this.btnSetCalib.TabIndex = 20;
            this.btnSetCalib.Text = "Send";
            this.btnSetCalib.UseVisualStyleBackColor = false;
            this.btnSetCalib.Click += new System.EventHandler(this.btnSetCalib_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSetCalib);
            this.Controls.Add(this.txtCalibInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnTare);
            this.Controls.Add(this.btnCalib);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.RS232);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.RS232.ResumeLayout(false);
            this.RS232.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox RS232;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbStop;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbLength;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalib;
        private System.Windows.Forms.Button btnTare;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCalibInput;
        private System.Windows.Forms.Button btnSetCalib;
    }
}

