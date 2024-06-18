using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace super_skaičiuotuvas
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            
            //if (!char.IsDigit(txtNum1.Text.Last()))
            //{
            //    txtNum1.Text = txtNum1.Text.Remove(txtNum1.Text.Length);
            //}
            
        }
        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            //if (!char.IsDigit(txtNum2.Text.Last()))
            //{
            //    txtNum2.Text = txtNum2.Text.Remove(txtNum2.Text.Length);
            //}
        }
        private void rdbAdd_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void rdbMinus_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbMultiply_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbDivide_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbPower2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPower2.Checked)
            {
                txtNum2.Visible = false;
                lbl2.Visible = false;
                lbl1.Text = "Skaicius";
            }
            else
            {
                txtNum2.Visible = true;
                lbl2.Visible = true;
                lbl1.Text = "Pirmas skaicius";
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtNum1.Text);
            double b = Convert.ToDouble(txtNum2.Text);
            if (rdbPower2.Checked)
            {
                lblCalculator.Text = (a * a).ToString();
            }
            else if (rdbDivide.Checked)
            {
                lblCalculator.Text = (a / b).ToString();
            }
            else if (rdbMultiply.Checked)
            {
                lblCalculator.Text = (a * b).ToString();
            }
            else if (rdbMinus.Checked)
            {
                lblCalculator.Text = (a - b).ToString();
            }
            else if (rdbAdd.Checked)
            {
                lblCalculator.Text = (a + b).ToString();
            }
            else if (rdbPower3.Checked)
            {
                lblCalculator.Text = (a * a * a).ToString();
            }
            else if (rdbPowerY.Checked)
            {
                lblCalculator.Text = (Math.Pow(a, b).ToString());
            }
            else if (rdbSqrt.Checked)
            {
                lblCalculator.Text = (Math.Sqrt(a).ToString());
            }
            else if (rdbCbrt.Checked)
            {
                lblCalculator.Text = (Math.Pow(a, (1.0 / 3)).ToString());
            }
            else if (rdbRtY.Checked)
            {
                lblCalculator.Text = (Math.Pow(a, (1.0 / b)).ToString());
            }
            else if (rdbDivide1.Checked)
            {
                lblCalculator.Text = (1.0 / a).ToString();
            }
            else if (rdbPercent.Checked)
            {
                lblCalculator.Text = (a / 100 * b).ToString();
            }
        }

        private void rdbPower3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPower3.Checked)
            {
                txtNum2.Visible = false;
                lbl2.Visible = false;
                lbl1.Text = "Skaicius";
            }
            else
            {
                txtNum2.Visible = true;
                lbl2.Visible = true;
                lbl1.Text = "Pirmas skaicius";
            }
        }

        private void rdbPowerY_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbSqrt_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSqrt.Checked)
            {
                txtNum2.Visible = false;
                lbl2.Visible = false;
                lbl1.Text = "Skaicius";
            }
            else
            {
                txtNum2.Visible = true;
                lbl2.Visible = true;
                lbl1.Text = "Pirmas skaicius";
            }
        }

        private void rdbCbrt_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCbrt.Checked)
            {
                txtNum2.Visible = false;
                lbl2.Visible = false;
                lbl1.Text = "Skaicius";
            }
            else
            {
                txtNum2.Visible = true;
                lbl2.Visible = true;
                lbl1.Text = "Pirmas skaicius";
            }
        }

        private void rdbDivide1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDivide1.Checked)
            {
                txtNum2.Visible = false;
                lbl2.Visible = false;
                lbl1.Text = "Skaicius";
            }
            else
            {
                txtNum2.Visible = true;
                lbl2.Visible = true;
                lbl1.Text = "Pirmas skaicius";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblCalculator.Text = "0";
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lblCalculator.Text = "0";
            txtNum1.Text = "0";
            txtNum2.Text = "0";
        }

        private void rdbPercent_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPercent.Checked)
            {
                lbl2.Text = "Jo dalis procentais";
                lbl1.Text = "Skaicius";
            }
            else
            {
                lbl2.Text = "Antras skaicius";
                lbl1.Text = "Pirmas skaicius";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Visible = false;
            frm2.Show();
        }
    }
}
