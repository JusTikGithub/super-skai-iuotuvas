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
        private void AA()
        {
            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;
            btn4.Visible = false;
        }
        private void BB()
        {
            btn1.Visible = true;
            btn2.Visible = false;
            btn3.Visible = false;
            btn4.Visible = false;
        }
        private void CC()
        {
            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = false;
            btn4.Visible = false;
        }
        private void DD()
        {
            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
        }
        private void EE()
        {
            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
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
                lbl1.Text = "Statinė prieš kampą";
                lbl2.Text = "Įžambinė";
                B();
            }
            if (rbCos.Checked)
            {
                lbl1.Text = "Statinė prie kampo";
                lbl2.Text = "Įžambinė";
                B();
            }
            if (rbTan.Checked)
            {
                lbl1.Text = "Statinė prieš kampą";
                lbl2.Text = "Statinė prie kampo";
                B();
            }
            if (rbLength.Checked)
            {
                lbl1.Text = "A kraštinė";
                lbl2.Text = "sin α";
                lbl3.Text = "sin ß";
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
            if (rbCos.Checked)
            {
                lbl1.Text = "Sin";
                lbl2.Text = "Tan";
                B();
            }
            if (rbTan.Checked)
            {
                lbl1.Text = "Sin";
                lbl2.Text = "Cos";
                B();
            }
            if (rbLength.Checked)
            {
                lbl1.Text = "A kraštinė";
                lbl2.Text = "B kraštinė";
                lbl3.Text = "sin C";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            x = 3;
            if (rbSin.Checked)
            {
                lbl1.Text = "Sin";
                A();
            }
            if (rbCos.Checked)
            {
                lbl1.Text = "Cos";
                A();
            }
            if (rbLength.Checked)
            {
                lbl1.Text = "A arba B kraštinė";
                lbl2.Text = "C kraštinė";
                lbl3.Text = "sin B arba sin A";
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
            if (rbCos.Checked)
            {
                lbl1.Text = "A kraštinė";
                lbl2.Text = "B kraštinė";
                lbl3.Text = "C kraštinė";
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
            if (rbCos.Checked && x == 1)
            {
                Dalyba();
            }
            if (rbCos.Checked && x == 2)
            {
                Dalyba();
            }
            if (rbCos.Checked && x == 3)
            {
                lblCalculator.Text = (Math.Sqrt(1 - Math.Pow(a, 2))).ToString();
            }
            if (rbCos.Checked && x == 4)
            {
                lblCalculator.Text = ((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b)).ToString();
            }
            if (rbTan.Checked && x == 1)
            {
                Dalyba();
            }
            if (rbTan.Checked && x == 2)
            {
                Dalyba();
            }
            if (rbLength.Checked && x == 1)
            {
                lblCalculator.Text = (a * c / b).ToString();
            }
            if (rbLength.Checked && x == 2)
            {

            }
            if (rbLength.Checked && x == 3)
            {

            }
        }
        private void rbSin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSin.Checked)
            {
                btn1.Text = "Su kraštinėmis";
                btn2.Text = "Su tan ir cos";
                btn3.Text = "Tik cos";
                btn4.Text = "Sinusų teorema";
                EE();
            }
        }

        private void rbCos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCos.Checked)
            {
                btn1.Text = "Su kraštinėmis";
                btn2.Text = "Su tan ir sin";
                btn3.Text = "Tik sin";
                btn4.Text = "Kosinusų teorema";
                EE();
            }
        }

        private void rbTan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTan.Checked)
            {
                btn1.Text = "Su kraštinėmis";
                btn2.Text = "Su sin ir cos";
                CC();
            }
        }

        private void rbLength_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLength.Checked)
            {
                btn1.Text = "Sinusų teorema";
                btn2.Text = "Kosinusų teorema (standartinis variantas)";
                btn3.Text = "kosinusų teorema (b ar c kraštinės)";
                DD();
            }
        }
    }
}
