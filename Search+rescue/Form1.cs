using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search_rescue
{
    public partial class Form1 : Form
    { string Data_rec;      //declares Data receieved as a global variable
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            s_port.Open();      //this automatically opens a new serial port everytime the form is loaded
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            s_port.Close();   //automatically closes the opened serial port everytime the form closes
        }

        private void s_port_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Data_rec = s_port.ReadExisting(); // stores recieved data from serieal port as a string
            this.Invoke(new EventHandler(disp_data));
            
        }

        private void disp_data(object sender, EventArgs e)  // defines the method for Disp_data in textbox.
        {
           tbx.Text = Data_rec;
        }
    }
}
