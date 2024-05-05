using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPT
{
    public partial class Form1 : Form

    {
        SerialPort port;
        public Form1()
        {
            
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);

            {
                //Change the portname according to your computer
                port = new SerialPort("COM4", 9600);
                port.Open();
            }

        }

        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (port != null && port.IsOpen)
            {
                port.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PortWrite("1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
        private void PortWrite(string message)
        {
            if (port != null && port.IsOpen)
            {
                port.Write(message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PortWrite("0");
        }
    }
}
