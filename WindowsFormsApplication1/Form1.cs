using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Text = "1111";
            this.button1.Text = "2222";
            this.button1.Text = "3333";
            this.button1.Text = "4444";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.button2.Text = "5555";
            this.button2.Text = "6666";
            this.button2.Text = "7777";
            this.button2.Text = "8888";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.button1.Text = "t1111";
        }
    }
}
