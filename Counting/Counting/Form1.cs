using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int firstNumber = 0, lastNumber = 0;
        int divisibleTerm = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            CmbDivisibleTerm.Items.Add("2");
            CmbDivisibleTerm.Items.Add("3");
            CmbDivisibleTerm.Items.Add("4");
            CmbDivisibleTerm.Items.Add("5");
            CmbDivisibleTerm.Items.Add("6");
            CmbDivisibleTerm.Items.Add("7");
            CmbDivisibleTerm.Items.Add("8");
            CmbDivisibleTerm.Items.Add("9");
            CmbDivisibleTerm.Items.Add("10");
        }

        private void CmbDivisibleTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisibleTerm = Convert.ToInt32(CmbDivisibleTerm.SelectedItem);
        }

        int controlNumber = 1;

        private void TxtStartFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rbBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlack.Checked)
            {
                rbRed.Checked = false;
                rbBlue.Checked = false;
                rbGreen.Checked = false;
                txtDivisiblenumbers.ForeColor = Color.Black;
            }
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRed.Checked)
            {
                rbBlack.Checked = false;
                rbBlue.Checked = false;
                rbGreen.Checked = false;
                txtDivisiblenumbers.ForeColor = Color.Red;
            }
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlue.Checked)
            {
                rbRed.Checked = false;
                rbBlack.Checked = false;
                rbGreen.Checked = false;
                txtDivisiblenumbers.ForeColor = Color.Blue;
            }
        }
        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGreen.Checked)
            {
                rbRed.Checked = false;
                rbBlue.Checked = false;
                rbBlack.Checked = false;
                txtDivisiblenumbers.ForeColor = Color.Green;
            }
        }

        private void chBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chBold.Checked)
            {
                txtDivisiblenumbers.Font = new Font(txtDivisiblenumbers.Font.FontFamily, txtDivisiblenumbers.Font.Size, FontStyle.Bold);
            }
            else
            {
                txtDivisiblenumbers.Font = new Font(txtDivisiblenumbers.Font.FontFamily, txtDivisiblenumbers.Font.Size, FontStyle.Regular);
            }
        }

        private void chItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chItalic.Checked)
            {
                txtDivisiblenumbers.Font = new Font(txtDivisiblenumbers.Font.FontFamily, txtDivisiblenumbers.Font.Size, FontStyle.Italic);
            }
            else
            {
                txtDivisiblenumbers.Font = new Font(txtDivisiblenumbers.Font.FontFamily, txtDivisiblenumbers.Font.Size, FontStyle.Regular);
            }
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            string divisibleNumber = "";

            if (TxtStartFrom.Text.Trim() == "" || TxtTo.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the neccessary fields!");
            }
            else if(CmbDivisibleTerm.SelectedIndex == -1)
            {
                MessageBox.Show("Please select divisible term!");
            }

            else
            {
                firstNumber = Convert.ToInt32(TxtStartFrom.Text);
                lastNumber = Convert.ToInt32(TxtTo.Text);
                //MessageBox.Show($"Divisible {divisibleTerm} From {firstNumber} To {lastNumber}");

                for (int i = firstNumber; i < lastNumber; i++)
                {
                    if (i % divisibleTerm == 0)
                    {
                        divisibleNumber += i.ToString() + " ";
                        if (controlNumber % 10 == 0)
                        {
                            divisibleNumber += Environment.NewLine;
                        }
                        controlNumber++;
                    }
                }
                txtDivisiblenumbers.Text = divisibleNumber;
            }
        }
    }
}
