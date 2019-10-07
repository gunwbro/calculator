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
            for (int i = 0; i < plusSplit.Length; i++)
            {

                string[] minusSplit = plusSplit[i].Split('-');
                double minusResult = 0;
                for (int j = 0; j < minusSplit.Length; j++)
                {

                    if (j == 0)
                    {
                        if (i == 0 && plusSplit[0][0] == '-')
                            minusResult += 0;
                        else
                            minusResult += Convert.ToDouble(minusSplit[j]);
                    }
                    else
                        minusResult -= Convert.ToDouble(minusSplit[j]);
                }

                plusSplit[i] = Convert.ToString(minusResult);
                Console.WriteLine(plusSplit[i]);
                result += Convert.ToDouble(plusSplit[i]);
            }
            Result.Text = Convert.ToString(result);
        }
    }
}
