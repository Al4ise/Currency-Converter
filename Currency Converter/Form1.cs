using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double val = 0;
            double oout = 0;
            try
            {
                val = Convert.ToDouble(textBox1.Text);
            }
            catch {
                label1.Text = "Invalid Input";
            }


            if (radioButton1.Checked)
            {
                oout = CurrencyConverter.ConvertToBGN(val);
            }
            else
            {
                oout = CurrencyConverter.ConvertToEUR(val);
            }

            label1.Text = Convert.ToString(oout);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
