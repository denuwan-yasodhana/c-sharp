using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;          // Add Serial Port to system

namespace Chapter_01
{
    public partial class Form1 : Form
    {

        string data;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get ComPort values to Combo box
            string[] ports = SerialPort.GetPortNames();
            cmd_ComPort.Items.AddRange(ports);
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            
            try 
            {
                // Get Port Name & Baund Rate
                serialPort1.PortName = cmd_ComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(cmd_BaundRate.Text);

                // Open Connection
                serialPort1.Open();
                pg_bar.Value = 100;

                chbox_enter.Checked = false;
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            // Close connection
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
                pg_bar.Value = 0;
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            // Send data
            if(serialPort1.IsOpen)
            {
                data = txt_Data.Text;
                serialPort1.WriteLine(data);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Clear data
            if(txt_Data.Text != "")
            {
                txt_Data.Text = "";
            }
        }

        private void txt_Data_TextChanged(object sender, EventArgs e)
        {
            // Get data length
            int dataLength = txt_Data.TextLength;
            lbl_datalength.Text = String.Format("{0:00}", dataLength);
        }

        private void chbox_enter_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_Data_KeyDown(object sender, KeyEventArgs e)
        {
            // when "Enter" button press
            if(chbox_enter.Checked)
            {
                if(e.KeyCode == Keys.Enter)
                {
                    data = txt_Data.Text;
                    serialPort1.WriteLine(data);
                }
            }
        }
    }
}
