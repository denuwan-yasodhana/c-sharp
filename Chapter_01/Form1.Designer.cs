namespace Chapter_01
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_BaundRate = new System.Windows.Forms.ComboBox();
            this.cmd_ComPort = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.pg_bar = new System.Windows.Forms.ProgressBar();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.txt_Data = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_datalength = new System.Windows.Forms.Label();
            this.chbox_enter = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmd_BaundRate);
            this.groupBox1.Controls.Add(this.cmd_ComPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Control";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "BAUND RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM PORT";
            // 
            // cmd_BaundRate
            // 
            this.cmd_BaundRate.FormattingEnabled = true;
            this.cmd_BaundRate.Items.AddRange(new object[] {
            "Select Baund Rate",
            "2400",
            "4800",
            "9600"});
            this.cmd_BaundRate.Location = new System.Drawing.Point(109, 54);
            this.cmd_BaundRate.Name = "cmd_BaundRate";
            this.cmd_BaundRate.Size = new System.Drawing.Size(160, 21);
            this.cmd_BaundRate.TabIndex = 1;
            this.cmd_BaundRate.Text = "Select Baund Rate";
            // 
            // cmd_ComPort
            // 
            this.cmd_ComPort.FormattingEnabled = true;
            this.cmd_ComPort.Location = new System.Drawing.Point(109, 25);
            this.cmd_ComPort.Name = "cmd_ComPort";
            this.cmd_ComPort.Size = new System.Drawing.Size(160, 21);
            this.cmd_ComPort.TabIndex = 0;
            this.cmd_ComPort.Text = "Select Com Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_clear);
            this.groupBox2.Controls.Add(this.btn_Send);
            this.groupBox2.Controls.Add(this.pg_bar);
            this.groupBox2.Controls.Add(this.btn_Close);
            this.groupBox2.Controls.Add(this.btn_Open);
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(183, 53);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(86, 34);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear Data";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(183, 15);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(86, 32);
            this.btn_Send.TabIndex = 3;
            this.btn_Send.Text = "Send Data";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // pg_bar
            // 
            this.pg_bar.Location = new System.Drawing.Point(5, 67);
            this.pg_bar.Name = "pg_bar";
            this.pg_bar.Size = new System.Drawing.Size(172, 20);
            this.pg_bar.TabIndex = 2;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(89, 15);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 32);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "CLOSE";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(8, 15);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(75, 32);
            this.btn_Open.TabIndex = 0;
            this.btn_Open.Text = "OPEN";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // txt_Data
            // 
            this.txt_Data.Location = new System.Drawing.Point(323, 12);
            this.txt_Data.Multiline = true;
            this.txt_Data.Name = "txt_Data";
            this.txt_Data.Size = new System.Drawing.Size(229, 188);
            this.txt_Data.TabIndex = 2;
            this.txt_Data.TextChanged += new System.EventHandler(this.txt_Data_TextChanged);
            this.txt_Data.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Data_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Length :";
            // 
            // lbl_datalength
            // 
            this.lbl_datalength.AutoSize = true;
            this.lbl_datalength.Location = new System.Drawing.Point(533, 215);
            this.lbl_datalength.Name = "lbl_datalength";
            this.lbl_datalength.Size = new System.Drawing.Size(19, 13);
            this.lbl_datalength.TabIndex = 4;
            this.lbl_datalength.Text = "00";
            // 
            // chbox_enter
            // 
            this.chbox_enter.AutoSize = true;
            this.chbox_enter.Location = new System.Drawing.Point(346, 210);
            this.chbox_enter.Name = "chbox_enter";
            this.chbox_enter.Size = new System.Drawing.Size(79, 17);
            this.chbox_enter.TabIndex = 5;
            this.chbox_enter.Text = "using Enter";
            this.chbox_enter.UseVisualStyleBackColor = true;
            this.chbox_enter.CheckedChanged += new System.EventHandler(this.chbox_enter_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 254);
            this.Controls.Add(this.chbox_enter);
            this.Controls.Add(this.lbl_datalength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Data);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmd_BaundRate;
        private System.Windows.Forms.ComboBox cmd_ComPort;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar pg_bar;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txt_Data;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_datalength;
        private System.Windows.Forms.CheckBox chbox_enter;
    }
}

