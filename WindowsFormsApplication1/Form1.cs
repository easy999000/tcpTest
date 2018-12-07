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
            this.button10.Text = "aaaa";
            this.button10.Text = "bbbb";
            this.button10.Text = "cccc";
            this.button10.Text = "dddd";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button5.Text = "eeee";
            this.button10.Text = "fff";
            this.button10.Text = "hhhh";
            this.button10.Text = "jjjj";

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
