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
    public partial class Tūriai : Form
    {
        public Tūriai()
        {
            InitializeComponent();
        }

        private void tsbChoose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void rbCube_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCube.Checked)
            {
                lbl1.Text = "kraštinė";
                a();
            }

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
        private void e()
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

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtNum1.Text);
            double b = Convert.ToDouble(txtNum2.Text);
            double c = Convert.ToDouble(txtNum3.Text);
            double d = Convert.ToDouble(txtNum4.Text);
            double E = Convert.ToDouble(txtNum5.Text);
            double f = Convert.ToDouble(txtNum6.Text);
            if (rbCube.Checked)
            {
                lblCalculator.Text = (Math.Pow(a, 3)).ToString();
            }
            if (rbRectangle.Checked)
            {
                lblCalculator.Text = (a * b * c).ToString();
            }
            if (rbPiramid.Checked)
            {
                lblCalculator.Text = (a * b / 3).ToString();
            }
            if (rbSphere.Checked)
            {
                lblCalculator.Text = (Math.Pow(a, 3) * Math.PI * (4/3)).ToString();
            }
            if (rbCone.Checked)
            {
                lblCalculator.Text = (Math.Pow(a, 2) * Math.PI * b / 3).ToString();
            }
            if (rbCylinder.Checked)
            {
                lblCalculator.Text = (Math.Pow(a, 2) * Math.PI * b).ToString();
            }
            if (rbPrism.Checked)
            {
                lblCalculator.Text = (a * b).ToString();
            }
        }

        private void rbRectangle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRectangle.Checked)
            {
                lbl1.Text = "Plotis";
                lbl2.Text = "Ilgis";
                lbl3.Text = "Aukštis";
                c();
            }
        }

        private void rbPiramid_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPiramid.Checked)
            {
                lbl1.Text = "pagrindo plotas";
                lbl2.Text = "piramidės aukštis";
                b();
            }
        }

        private void rbSphere_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSphere.Checked)
            {
                lbl1.Text = "Spindulys";
                a();
            }
        }

        private void rbCone_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCone.Checked)
            {
                lbl1.Text = "pagrindo spindulys";
                lbl2.Text = "aukštis";
                b();
            }
        }

        private void rbCylinder_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCylinder.Checked)
            {
                lbl1.Text = "Pagrindo spindulys";
                lbl2.Text = "Aukštis";
                b();
            }
        }

        private void rbPrism_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPrism.Checked)
            {
                lbl1.Text = "Pagrindo plotas";
                lbl2.Text = "Aukštis";
                b();
            }
        }
    }
}
