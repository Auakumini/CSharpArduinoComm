using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void button1_Click(object sender, EventArgs e) //ON BUTTON
        {
            // send command to arduino to turn pin 13 (ex.) on
            serialPort1.Write("A");
        }

        private void offButton_Click(object sender, EventArgs e) //OFF BUTTON
        {
            // send command to arduino to turn pin 13 (ex.) off
            serialPort1.Write("a");
        }
    }
}
