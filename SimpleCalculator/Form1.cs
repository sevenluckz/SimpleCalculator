using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string strL = textBoxL.Text, strR = textBoxR.Text;
            int intL = Convert.ToInt32(strL), intR = Convert.ToInt32(strR), intF = intL + intR;
            answerBox.Text = Convert.ToString(intF);
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            string strL = textBoxL.Text, strR = textBoxR.Text;
            int intL = Convert.ToInt32(strL), intR = Convert.ToInt32(strR), intF = intL - intR;
            answerBox.Text = Convert.ToString(intF);
        }

        private void multiBtn_Click(object sender, EventArgs e)
        {
            string strL = textBoxL.Text, strR = textBoxR.Text;
            int intL = Convert.ToInt32(strL), intR = Convert.ToInt32(strR), intF = intL * intR;
            answerBox.Text = Convert.ToString(intF);
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            string strL = textBoxL.Text, strR = textBoxR.Text;
            int intL = Convert.ToInt32(strL), intR = Convert.ToInt32(strR);
            if (intR == 0) { answerBox.Text = "Can't divide by zero!"; }
            else { int intF = intL / intR; answerBox.Text = Convert.ToString(intF); }
        }
    }
}
