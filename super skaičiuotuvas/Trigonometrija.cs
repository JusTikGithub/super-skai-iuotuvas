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
    public partial class Trigonometrija : Form
    {
        int x = 0;  
        public Trigonometrija()
        {
            InitializeComponent();
        }
        private void A()
        {
            lbl1.Visible = true;
            lbl2.Visible = false;
            lbl3.Visible = false;
            txtNum1.Visible = true;
            txtNum2.Visible = false;
            txtNum3.Visible = false;
        }
        private void B()
        {
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = false;
            txtNum1.Visible = true;
            txtNum2.Visible = true;
            txtNum3.Visible = false;
        }
        private void C()
        {
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            txtNum1.Visible = true;
            txtNum2.Visible = true;
            txtNum3.Visible = true;
        }
        private void Daugyba()
        {
            double a = Convert.ToDouble(txtNum1.Text);
            double b = Convert.ToDouble(txtNum2.Text);
            lblCalculator.Text = (a * b).ToString();
        }
        private void Dalyba()
        {
            double a = Convert.ToDouble(txtNum1.Text);
            double b = Convert.ToDouble(txtNum2.Text);
            lblCalculator.Text = (a / b).ToString();
        }
        private void tsbChoose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            x = 1;
            if (rbSin.Checked)
            {
                lbl1.Text = "Statinė";
                lbl2.Text = "Įžambinė";
                B();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            x = 2;
            if (rbSin.Checked)
            {
                lbl1.Text = "Tan";
                lbl2.Text = "Cos";
                B();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            x = 3;
            if (rbSin.Checked)
            {
                lbl1.Text = "Cos";
                A();
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            x = 4;
            if (rbSin.Checked)
            {
                lbl1.Text = "kampas α";
                lbl2.Text = "A kraštinė";
                lbl3.Text = "B kraštinė";
                C();
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtNum1.Text);
            double b = Convert.ToDouble(txtNum2.Text);
            double c = Convert.ToDouble(txtNum3.Text);
            if (rbSin.Checked && x == 1)
            {
                Dalyba();
            }
            if (rbSin.Checked && x == 2)
            {
                Daugyba();
            }
            if (rbSin.Checked && x == 3)
            {
                lblCalculator.Text = (Math.Sqrt(1 - Math.Pow(a, 2))).ToString();
            }
            if (rbSin.Checked && x == 4)
            {
                // kampui apskaičiuoti tiks lblCalculator.Text = (Math.Asin(c * a / b) * (180 / Math.PI)).ToString();
                lblCalculator.Text = (c * Math.Sin(a * (Math.PI / 180)) / b).ToString();
            }
        }
        private void rbSin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSin.Checked)
            {
                btn1.Text = "Su kraštinėmis";
                btn2.Text = "su tan ir cos";
                btn3.Text = "Tik cos";
                btn4.Text = "Sinusų teorema";
            }
        }


    }
}
