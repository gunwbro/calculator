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
            textbox.Text += btnTmp.Text;
        }

        private void C_Click(object sender, EventArgs e)
        {
            textbox.Text = "";
        }

        private void DEL_Click(object sender, EventArgs e)
        {
            
        }

        private void resul_Click(object sender, EventArgs e)
        {
            string[] plusSplit = textbox.Text.Split('+');
            double result = 0;

            for(int i = 0; i < plusSplit.Length; i++)
            {
                Console.WriteLine(plusSplit[i]);
                result += Convert.ToDouble(plusSplit[i]);
            }
            Result.Text = Convert.ToString(result);
        }
    }
}
