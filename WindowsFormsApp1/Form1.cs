using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Number1_Click(object sender, EventArgs e)
        {
            Button btnTmp = (Button)sender;
            textBox1.Text += btnTmp.Text;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("I Love you Sohee♡");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I Love you Sohee♡");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("I Love you Sohee♡");
        }
    }
}
