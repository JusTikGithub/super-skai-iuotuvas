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
    public partial class Plotai : Form
    {
        public Plotai()
        {
            InitializeComponent();
        }
        int x = 0;
        private void btnEquals_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtNum1.Text);
            double b = Convert.ToDouble(txtNum2.Text);
            double c = Convert.ToDouble(txtNum3.Text);
            double d = Convert.ToDouble(txtNum4.Text);
            double E = Convert.ToDouble(txtNum5.Text);
            double f = Convert.ToDouble(txtNum6.Text);
            if (rbSquare.Checked)
            {
                lblCalculator.Text = (a * a).ToString();
            }
            else if (rbTriangle.Checked && x == 1)
            {
                lblCalculator.Text = (b * a / 2).ToString();
            }
            else if (rbTriangle.Checked && x == 2)
            {
                lblCalculator.Text = (b * a * Math.Sin(c) / 2).ToString();
            }
            else if (rbTriangle.Checked && x == 3)
            {
                lblCalculator.Text = (b * a).ToString();
            }
            else if (rbTriangle.Checked && x == 4)
            {
                lblCalculator.Text = (b * a * c / (4 * d)).ToString();
            }
            else if (rbTriangle.Checked && x == 5)
            {
                double z = (a + b + c) / 2;
                double y = z * (z - a) * (z - b) * (z - c);
                lblCalculator.Text = (Math.Sqrt(y)).ToString();
            }
            else if (rbLygiagretainis.Checked && x == 1)
            {
                lblCalculator.Text = (b * a).ToString();
            }
            else if (rbLygiagretainis.Checked && x == 2)
            {
                lblCalculator.Text = ((0.5 * a * b * Math.Sin(c * Math.PI/180))).ToString();
            }
            else if (rbLygiagretainis.Checked && x == 3)
            {
                lblCalculator.Text = (a * b * Math.Sin(c * Math.PI / 180)).ToString();
            }
            else if (rbKeturkampis.Checked)
            {
                double s = (a + b + c + d) / 2;
                double t = (s - a) * (s - b) * (s - c) * (s - d);
                double u = Math.Pow(Math.Cos((E + f) / 2), 2) * a * b * c * d;
                lblCalculator.Text = (Math.Sqrt(t - u)).ToString();
            }
            else if (rbRectangle.Checked)
            {
                lblCalculator.Text = (a * b).ToString();
            }
            else if (rbSquare.Checked)
            {
                lblCalculator.Text = (Math.Pow(a, 2) * Math.PI).ToString();
            }
            else if (rbTrapezoid.Checked)
            {
                lblCalculator.Text = ((a + b) / 2 * c).ToString();
            }
            else if (rbOval.Checked)
            {
                lblCalculator.Text = (a * b * Math.PI).ToString();
            }
            else if (rbCube.Checked)
            {
                lblCalculator.Text = (6 * Math.Pow(a, 2)).ToString();
            }
            else if (rbRectPrism.Checked)
            {
                lblCalculator.Text = (a * b * 2 + a * c * 2 + b * c * 2).ToString();
            }
            else if (rbCylinder.Checked)
            {
                lblCalculator.Text = (2 * Math.PI * a * b + 2 * Math.PI * Math.Pow(a, 2)).ToString();
            }
            else if (rbCone.Checked)
            {
                lblCalculator.Text = (Math.PI * a * (a + Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)))).ToString();
            }
            else if (rbPrism.Checked)
            {
                lblCalculator.Text = (2 * a + b * c).ToString();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "0";
            txtNum2.Text = "0";
            txtNum3.Text = "0";
            txtNum4.Text = "0";
            txtNum5.Text = "0";
            txtNum6.Text = "0";
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lblCalculator.Text = "0";
            txtNum1.Text = "0";
            txtNum2.Text = "0";
            txtNum3.Text = "0";
            txtNum4.Text = "0";
            txtNum5.Text = "0";
            txtNum6.Text = "0";
        }

        private void rbSquare_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSquare.Checked)
            {
                lbl1.Text = "Kraštinės ilgis";
                a();
            }
        }

        private void rbTriangle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTriangle.Checked)
            {
                btn1.Text = "S = 0,5 * a * h";
                btn2.Text = "S = 0,5 * a * b * sin c";
                btn3.Text = "S = r * p";
                btn4.Text = "S = a * b * c / (4 * R)";
                btn5.Text = "S = Herono formulė";
            }
        }

        private void rbLygiagretainis_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLygiagretainis.Checked)
            {
                btn1.Text = "S = a * h";
                btn2.Text = "S = 0,5 * d₁ * d₂ * sin φ";
                btn3.Text = "S = a * b * sin α";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            x = 1;
            if (rbLygiagretainis.Checked)
            {  
                lbl1.Text = "aukštinė";
                lbl2.Text = "pagrindo ilgis";
                b();
            }
            if (rbTriangle.Checked)
            {
                lbl1.Text = "Aukštinė";
                lbl2.Text = "Pagrindo ilgis";
                b();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            x = 2;
            if (rbLygiagretainis.Checked)
            { 
                lbl1.Text = "1 ižambinės ilgis";
                lbl2.Text = "2 ižambinės ilgis";
                lbl3.Text = "Kampas tarp įžambinių";
                c();
            }
            if (rbTriangle.Checked)
            {
                lbl1.Text = "Vienos kraštinės ilgis";
                lbl2.Text = "Kitos kraštinės ilgis";
                lbl3.Text = "Kampas tarp kraštinių";
                c();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            x = 3;
            if (rbLygiagretainis.Checked)
            {
                lbl1.Text = "pagrindo ilgis";
                lbl2.Text = "šoninės kraštinės ilgis";
                lbl3.Text = "kampo dydis tarp a ir b kraštinių";
                c();
            }
            if (rbTriangle.Checked)
            {
                lbl1.Text = "Spindulio ilgis";
                lbl2.Text = "Perimetro ilgis";
                b();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            x = 4;
            if (rbTriangle.Checked)
            {
                lbl1.Text = "Pirmos kraštinės ilgis";
                lbl2.Text = "Antros kraštinės ilgis";
                lbl3.Text = "Trečios kraštinės ilgis";
                lbl4.Text = "Spindulio ilgis";
                d();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            x = 5;
            if (rbTriangle.Checked)
            {
                lbl1.Text = "Pirmos kraštinės ilgis";
                lbl2.Text = "Antros kraštinės ilgis";
                lbl3.Text = "Trečios kraštinės ilgis";
                c();
            }
        }
        private void tsbChoose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void rbKeturkampis_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Text = "Pirma kraštinė";
            lbl2.Text = "Antra kraštinė";
            lbl3.Text = "Trečia kraštinė";
            lbl4.Text = "Ketvirta kraštinė";
            lbl5.Text = "Kampas α";
            lbl6.Text = "Kampas priešingas a(γ)";
            f();
        }

        private void rbRectangle_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Text = "Plotis";
            lbl2.Text = "ilgis";
            b();
        }

        private void rbCircle_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Text = "spindulys";
            a();
        }
        private void a()
        {
            txtNum1.Visible = true;
            txtNum2.Visible = false;
            txtNum3.Visible = false;
            txtNum4.Visible = false;
            txtNum5.Visible = false;
            txtNum6.Visible = false;
            lbl1.Visible = true;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
            lbl6.Visible = false;

        }
        private void b()
        {
            txtNum1.Visible = true;
            txtNum2.Visible = true;
            txtNum3.Visible = false;
            txtNum4.Visible = false;
            txtNum5.Visible = false;
            txtNum6.Visible = false;
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
            lbl6.Visible = false;
        }
        private void c()
        {
            txtNum1.Visible = true;
            txtNum2.Visible = true;
            txtNum3.Visible = true;
            txtNum4.Visible = false;
            txtNum5.Visible = false;
            txtNum6.Visible = false;
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = false;
            lbl5.Visible = false;
            lbl6.Visible = false;
        }
        private void d()
        {
            txtNum1.Visible = true;
            txtNum2.Visible = true;
            txtNum3.Visible = true;
            txtNum4.Visible = true;
            txtNum5.Visible = false;
            txtNum6.Visible = false;
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            lbl5.Visible = false;
            lbl6.Visible = false;
        }
        private void E()
        {
            txtNum1.Visible = true;
            txtNum2.Visible = true;
            txtNum3.Visible = true;
            txtNum4.Visible = true;
            txtNum5.Visible = true;
            txtNum6.Visible = false;
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            lbl5.Visible = true;
            lbl6.Visible = false;
        }
        private void f()
        {
            txtNum1.Visible = true;
            txtNum2.Visible = true;
            txtNum3.Visible = true;
            txtNum4.Visible = true;
            txtNum5.Visible = true;
            txtNum6.Visible = true;
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            lbl5.Visible = true;
            lbl6.Visible = true;
        }

        private void rbTrapezoid_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTrapezoid.Checked)
            {
                c();
                lbl1.Text = "pirmo pagrindo ilgis";
                lbl2.Text = "antro pagrindo ilgis";
                lbl3.Text = "aukštinės ilgis";
            }
        }

        private void rbOval_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOval.Checked)
            {
                b();
                lbl1.Text = "pirmos pusašies ilgis";
                lbl2.Text = "antros pusašies ilgis";
            }
        }

        private void rbCube_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCube.Checked)
            {
                a();
                lbl1.Text = "Kraštinės ilgis";
            }
        }
        private void rbRectPrism_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRectPrism.Checked)
            {
                c();
                lbl1.Text = "ilgis";
                lbl3.Text = "aukštis";
                lbl2.Text = "plotis";
            }
        }

        private void rbCylinder_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCylinder.Checked)
            {
                b();
                lbl1.Text = "pagrindo spindulio ilgis";
                lbl2.Text = "Aukštis";
            }
        }

        private void rbCone_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCone.Checked)
            {
                b();
                lbl1.Text = "Pagrindo spindulio ilgis";
                lbl2.Text = "aukštis";
            }
        }

        private void rbPrism_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPrism.Checked)
            {
                c();
                lbl1.Text = "pagrindo plotas";
                lbl2.Text = "pagrindo perimetras";
                lbl3.Text = "aukštis";
            }
        }


    }
}
