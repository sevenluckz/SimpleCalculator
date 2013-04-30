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
            try
            {
                double dblL = Convert.ToDouble(strL), dblR = Convert.ToDouble(strR), dblF = dblL + dblR;
                answerBox.Text = Convert.ToString(dblF);
            }
            catch (Exception ex) { answerBox.Text = "Please enter two NUMBERS!"; }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string strL = textBoxL.Text, strR = textBoxR.Text;
                double dblL = Convert.ToDouble(strL), dblR = Convert.ToDouble(strR), dblF = dblL - dblR;
                answerBox.Text = Convert.ToString(dblF);
            }
            catch (Exception ex) { answerBox.Text = "Please enter two NUMBERS!"; }
        }

        private void multiBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string strL = textBoxL.Text, strR = textBoxR.Text;
                double dblL = Convert.ToDouble(strL), dblR = Convert.ToDouble(strR), dblF = dblL * dblR;
                answerBox.Text = Convert.ToString(dblF);
            }
            catch (Exception ex) { answerBox.Text = "Please enter two NUMBERS!"; }
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string strL = textBoxL.Text, strR = textBoxR.Text;
                double dblL = Convert.ToDouble(strL), dblR = Convert.ToDouble(strR);
                if (dblR == 0) { answerBox.Text = "Can't divide by zero!"; }
                else { double dblF = dblL / dblR; answerBox.Text = Convert.ToString(dblF); }
            }
            catch (Exception ex) { answerBox.Text = "Please enter two NUMBERS!"; }
        }
    }
}
