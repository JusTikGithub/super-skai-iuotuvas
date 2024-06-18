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
    public partial class Fizikinis_skaiciuotuvas : Form
    {
        int x = 0;

        public Fizikinis_skaiciuotuvas()
        {
            InitializeComponent();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lblCalculator.Text = "0";
            txtNum1.Text = "0";
            txtNum2.Text = "0";
            txtNum3.Text = "0";
            txtNum4.Text = "0";
            lbl1.Text = "Primas skaičius";
            lbl2.Text = "Antras skaičius";
            lbl3.Text = "Trečias skaičius";
            lbl4.Text = "Ketvirtas skaičius";
            groupBox2.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblCalculator.Text = "0";
        }

        private void Fizikinis_skaiciuotuvas_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            a();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtNum1.Text);
            double b = Convert.ToDouble(txtNum2.Text);
            double c = Convert.ToDouble(txtNum3.Text);
            double d = Convert.ToDouble(txtNum4.Text);
            if (rdbV.Checked)
            {
                if (x == 1)
                {
                    Daugyba();
                }
                if (x == 2)
                {
                    lblCalculator.Text = (a / b / c).ToString();
                }
                if (x == 3)
                {
                    Daugyba();
                }
            }
            if (rdbλ.Checked)
            {
                if (x == 1 || x == 2)
                {
                    Dalyba();
                }
                if (x == 3)
                {
                    lblCalculator.Text = (299792458 / a).ToString();
                }
            }
            if (rdbT.Checked)
            {
                if (x == 1)
                {
                    lblCalculator.Text = (1 / a).ToString();
                }
                if (x == 2)
                {
                    Dalyba();
                }
                if (x == 3 || x == 4)
                {
                    lblCalculator.Text = (2 * Math.PI * Math.Sqrt(a / b)).ToString();
                }
            }
            if (rdbN.Checked)
            {
                if (x == 1 || x == 2)
                {
                    Daugyba();
                }
            }
            if (rdbQ.Checked)
            {
                if (x == 1)
                {
                    lblCalculator.Text = (a * b * (d - c)).ToString();
                }
                if (x == 2 || x == 3 || x == 4)
                {
                    Daugyba();
                }
            }
            if (rdbf.Checked)
            {
                if (x == 1)
                {
                    lblCalculator.Text = (1 / a).ToString();
                }
                if (x == 2)
                {
                    Dalyba();
                }
                if (x == 3)
                {
                    lblCalculator.Text = (299792458 / a).ToString();
                }
            }
            if (rdbP.Checked)
            {
                if (x == 1)
                {
                    lblCalculator.Text = (a * b * c).ToString();
                }
                if (x == 2)
                {
                    Dalyba();
                }
            }
            if (rdbFs.Checked)
            {
                Daugyba();
            }
            if (rdbEk.Checked)
            {
                lblCalculator.Text = ((Math.Pow(a, 2) * b) / 2).ToString();
            }
            if (rdbMass.Checked)
            {
                if (x == 1)
                {
                    Daugyba();
                }
                if (x == 2 || x == 3)
                {
                    Dalyba();
                }
                if (x == 4)
                {
                    lblCalculator.Text = (a / b / c).ToString();
                }
                if (x == 5)
                {
                    lblCalculator.Text = ((a * 2) / Math.Pow(b, 2)).ToString();
                }
            }
            if (rdbA.Checked)
            {
                if (x == 1)
                {
                    Daugyba();
                }
                if (x == 2)
                {
                    Dalyba();
                }
                if (x == 3)
                {
                    lblCalculator.Text = (a * Math.Cos(b * Math.PI / 180) * c).ToString();
                }
                if (x == 4)
                {
                    lblCalculator.Text = (a * b * c).ToString();
                }
            }
            if (rdbEp.Checked)
            {
                lblCalculator.Text = (a * b * c).ToString();
            }
            if (rdbM.Checked)
            {
                Daugyba();
            }
            if (rdbFtampr.Checked)
            {
                Daugyba();
            }
            if (rdbvCircle.Checked)
            {
                Daugyba();
            }
            if (rdbη.Checked)
            {
                Dalyba();
            }
            if (rdbPagreitis.Checked)
            {
                lblCalculator.Text = ((a - b) / c).ToString();
            }
            if (rdbRo.Checked)
            {
                Dalyba();
            }
            if (rdbFArchimedo.Checked)
            {
                if (x == 1)
                {
                    lblCalculator.Text = (a * b * c).ToString();
                }
                if (x == 2)
                {
                    lblCalculator.Text = (a - b).ToString();
                }
            }
            if (rdbФ.Checked)
            {
                lblCalculator.Text = (a / b * 100).ToString();
            }
        }

        private void rdbλ_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbλ.Checked)
            {
                groupBox2.Visible = true;
                rb1.Text = "Q ir m";
                rb2.Text = "v ir ƒ";
                rb3.Text = "c ir ƒ";
                c();
                cc();
            }
        }

        private void rdbT_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbT.Checked)
            {
                rb1.Text = "ƒ";
                rb2.Text = "t ir N";
                rb3.Text = "l ir g";
                rb4.Text = "m ir k";
                d();
                dd();
            }
        }

        private void rdbN_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbN.Checked)
            {
                rb1.Text = "A ir t";
                rb2.Text = "U ir I";
                b();
                bb();
            }
        }

        private void Konstantos_Click(object sender, EventArgs e)
        {
            Konstantos frm6 = new Konstantos();
            this.Close();
            frm6.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            X();
            if (rdbV.Checked && rb1.Checked)
            {
                lbl1.Text = "m(kg)";
                lbl2.Text = "ρ(kg/m³)";
                B();
            }
            if (rb1.Checked && rdbMass.Checked)
            {
                lbl1.Text = "ρ(kg/m³)";
                lbl2.Text = "V(m³)";
                B();
            }
            if (rb1.Checked && rdbλ.Checked)
            {
                lbl1.Text = "Q(J)";
                lbl2.Text = "m(kg)";
                B();
            }
            if (rb1.Checked && rdbA.Checked)
            {
                lbl1.Text = "F(N)";
                lbl2.Text = "s(m)";
                B();
            }
            if (rb1.Checked && rdbT.Checked)
            {
                lbl1.Text = "ƒ(Hz)";
                A();
            }
            if (rb1.Checked && rdbN.Checked)
            {
                lbl1.Text = "A(J)";
                lbl2.Text = "t(s)";
                B();
            }
            if (rb1.Checked && rdbFArchimedo.Checked)
            {
                lbl1.Text = "ρ(kg/m³)";
                lbl2.Text = "V(m³)";
                lbl3.Text = "g(m/s²)";
                C();
            }
            if (rb1.Checked && rdbQ.Checked)
            {
                lbl1.Text = "c(J/(kg*°C))";
                lbl2.Text = "m(kg)";
                lbl3.Text = "t1(°C)";
                lbl4.Text = "t2(°C)";
                D();
            }
            if (rb1.Checked && rdbP.Checked)
            {
                lbl1.Text = "ρ(kg/m³)";
                lbl2.Text = "g(m/s²)";
                lbl3.Text = "h(m)";
                C();
            }
            if (rb1.Checked && rdbf.Checked)
            {
                lbl1.Text = "T(s)";
                A();
            }
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            X();
            if (rdbV.Checked && rb2.Checked)
            {
                lbl1.Text = "F(N)";
                lbl2.Text = "ρ(kg/m³)";
                lbl3.Text = "g(m/s²)";
                C();
            }
            if (rb2.Checked && rdbMass.Checked)
            {
                lbl1.Text = "F(N)";
                lbl2.Text = "g(m/s²)";
                B();
            }
            if (rb2.Checked && rdbλ.Checked)
            {
                lbl1.Text = "v(m/s)";
                lbl2.Text = "ƒ(Hz)";
                B();
            }
            if (rb2.Checked && rdbA.Checked)
            {
                lbl1.Text = "t(s)";
                lbl2.Text = "N(W)";
                B();
            }
            if (rb2.Checked && rdbT.Checked)
            {
                lbl1.Text = "N(W)";
                lbl2.Text = "t(s)";
                B();
            }
            if (rb2.Checked && rdbN.Checked)
            {
                lbl1.Text = "U(V)";
                lbl2.Text = "I(A)";
                B();
            }
            if (rb2.Checked && rdbFArchimedo.Checked)
            {
                lbl1.Text = "F ore(N)";
                lbl2.Text = "F skystyje(N)";
                B();
            }
            if (rb2.Checked && rdbP.Checked)
            {
                lbl1.Text = "F(N)";
                lbl2.Text = "S(m²)";
                B();
            }
            if (rb2.Checked && rdbf.Checked)
            {
                lbl1.Text = "v(m/s)";
                lbl2.Text = "λ(m)";
                B();
            }
            if (rdbQ.Checked && rb2.Checked)
            {
                lbl1.Text = "λ(J/kg)";
                lbl2.Text = "m(kg)";
                B();
            }
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            X();
            if (rdbV.Checked && rb3.Checked)
            {
                lbl1.Text = "n(m^-3)";
                lbl2.Text = "N(kiekis)";
                B();
            }
            if (rb3.Checked && rdbMass.Checked)
            {
                lbl1.Text = "F(N)";
                lbl2.Text = "a(m/s²)";
                B();
            }
            if (rb3.Checked && rdbλ.Checked)
            {
                lbl1.Text = "ƒ(Hz)";
                A();
            }
            if (rb3.Checked && rdbA.Checked)
            {
                lbl1.Text = "F(N)";
                lbl3.Text = "°";
                lbl2.Text = "s(m)";
                C();
            }
            if (rb3.Checked && rdbT.Checked)
            {
                lbl1.Text = "l(m)";
                lbl2.Text = "g(m/s²)";
                B();
            }
            //if (rb3.Checked && rdbP.Checked)
            //{
            //  lbl1.Text = "T(s)";
            //  lbl2.Text = "n(mol)";
            //  lbl3.Text = "V(m³)";
            //}
            if (rb3.Checked && rdbf.Checked)
            {
                lbl1.Text = "λ(m)";
                A();
            }
            if (rdbQ.Checked && rb3.Checked)
            {
                lbl1.Text = "L(J/kg)";
                lbl2.Text = "m(kg)";
                B();
            }
        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            X();
            if (rb4.Checked && rdbMass.Checked)
            {
                lbl1.Text = "Ep(J)";
                lbl2.Text = "g(m/s²)";
                lbl3.Text = "h(m)";
                C();
            }
            if (rb4.Checked && rdbA.Checked)
            {
                lbl1.Text = "U(V)";
                lbl2.Text = "I(A)";
                lbl3.Text = "t(s)";
                C();
            }
            if (rb4.Checked && rdbT.Checked)
            {
                lbl1.Text = "m(kg)";
                lbl2.Text = "k(N/m)";
                B();
            }
            if (rdbQ.Checked && rb4.Checked)
            {
                lbl1.Text = "q(J/kg)";
                lbl2.Text = "m(kg)";
                B();
            }
        }

        private void rb5_CheckedChanged(object sender, EventArgs e)
        {
            X();
            if (rb5.Checked && rdbMass.Checked)
            {
                lbl1.Text = "Ek(N)";
                lbl2.Text = "v(m/s)";
                B();
            }
        }

        private void rb6_CheckedChanged(object sender, EventArgs e)
        {
            X();
        }

        private void rb7_CheckedChanged(object sender, EventArgs e)
        {
            X();
        }

        private void rb8_CheckedChanged(object sender, EventArgs e)
        {
            X();
        }

        private void rdbQ_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbQ.Checked)
            {
                rb1.Text = "c, m, t1 ir t2";
                rb2.Text = "λ ir m";
                rb3.Text = "L ir m";
                rb4.Text = "q ir m";
                d();
                dd();
            }
        }

        private void rdbf_CheckedChanged(object sender, EventArgs e)
        {
            rb1.Text = "T";
            rb2.Text = "λ ir v";
            rb3.Text = "λ ir c";
            c();
            cc();
        }

        private void rdbP_CheckedChanged(object sender, EventArgs e)
        {
            rb1.Text = "ρ, g ir h";
            rb2.Text = "F ir S";
            b();
            bb();
        }

        private void rdbFs_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Text = "m(kg)";
            lbl2.Text = "g(m/s²)";
            a();
            aa();
            B();

        }

        private void rdbEk_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEk.Checked)
            {
                lbl1.Text = "v(m/s)";
                lbl2.Text = "m(kg)";
                a();
                aa();
                B();
            }
        }

        private void rdbV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbV.Checked)
            {
                groupBox2.Visible = true;
                rb1.Text = "m ir ρ";
                rb2.Text = "F, ρ(skysčio) ir g";
                rb3.Text = "n ir N";
                c();
                cc();
            }
        }

        private void rdbMass_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMass.Checked)
            {
                groupBox2.Visible = true;
                rb1.Text = "ρ ir V";
                rb2.Text = "Fs ir g";
                rb3.Text = "F ir a";
                rb4.Text = "Ep, g, h";
                rb5.Text = "Ek ir v";
                E();
                ee();
            }
        }

        private void rdbA_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbA.Checked)
            {
                groupBox2.Visible = true;
                rb1.Text = "F ir s"; //darbas
                rb2.Text = "N ir t"; //darbas
                rb3.Text = "F, s, cos 𝜃"; //darbas
                rb4.Text = "U, I, t"; //elektros darbas
                d();
                dd();
            }
        }

        private void rdbEp_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEp.Checked)
            {
                lbl1.Text = "m(kg)";
                lbl2.Text = "g(m/s²)";
                lbl3.Text = "h(m)";
                a();
                aa();
                C();
            }
        }

        private void rdbM_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbM.Checked)
            {
                lbl1.Text = "F(N)";
                lbl2.Text = "l(m)";
                a();
                aa();
                B();
            }
        }

        private void rdbFtampr_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFtampr.Checked)
            {
                lbl1.Text = "x(m)";
                lbl2.Text = "K(N/m)";
                a();
                aa();
                B();
            }
        }

        private void rdbvCircle_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbvCircle.Checked)
            {
                lbl1.Text = "r(m)";
                lbl2.Text = "t(s)";
                a();
                aa();
                B();
            }
        }

        private void rdbη_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbη.Checked)
            {
                lbl1.Text = "Naudingas darbas";
                lbl2.Text = "Visas darbas";
                a();
                aa();
                B();
            }
        }

        private void rdbPagreitis_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPagreitis.Checked)
            {
                lbl1.Text = "v1(m/s)";
                lbl2.Text = "v0(m/s)";
                lbl3.Text = "t(s)";
                a();
                aa();
                C();
            }
        }

        private void rdbRo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRo.Checked)
            {
                lbl1.Text = "m(kg)";
                lbl2.Text = "V(m³)";
                a();
                aa();
                B();
            }
        }

        private void rdbFArchimedo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFArchimedo.Checked)
            {
                rb1.Text = "ρ(skysčio), V ir g";
                rb2.Text = "F(ore) ir F(skystyje)";
                b();
                bb();
            }
        }

        private void rdbФ_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Text = "P";
            lbl2.Text = "P0";
            a();
            aa();
            B();
        }

        private void tsbChoose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 frm2 = new Form2();
            frm2.Show();
        }
        private void b()
        {
            rb1.Visible = true;
            rb2.Visible = true;
            rb3.Visible = false;
            rb4.Visible = false;
            rb5.Visible = false;
            rb6.Visible = false;
            rb7.Visible = false;
            rb8.Visible = false;
        }
        private void c()
        {
            rb1.Visible = true;
            rb2.Visible = true;
            rb3.Visible = true;
            rb4.Visible = false;
            rb5.Visible = false;
            rb6.Visible = false;
            rb7.Visible = false;
            rb8.Visible = false;
        }
        private void d()
        {
            rb1.Visible = true;
            rb2.Visible = true;
            rb3.Visible = true;
            rb4.Visible = true;
            rb5.Visible = false;
            rb6.Visible = false;
            rb7.Visible = false;
            rb8.Visible = false;
        }
        private void E()
        {
            rb1.Visible = true;
            rb2.Visible = true;
            rb3.Visible = true;
            rb4.Visible = true;
            rb5.Visible = true;
            rb6.Visible = false;
            rb7.Visible = false;
            rb8.Visible = false;
        }
        private void f()
        {
            rb1.Visible = true;
            rb2.Visible = true;
            rb3.Visible = true;
            rb4.Visible = true;
            rb5.Visible = true;
            rb6.Visible = true;
            rb7.Visible = false;
            rb8.Visible = false;
        }
        private void g()
        {
            rb1.Visible = true;
            rb2.Visible = true;
            rb3.Visible = true;
            rb4.Visible = true;
            rb5.Visible = true;
            rb6.Visible = true;
            rb7.Visible = true;
            rb8.Visible = false;
        }
        private void a()
        {
            rb1.Visible = false;
            rb2.Visible = false;
            rb3.Visible = false;
            rb4.Visible = false;
            rb5.Visible = false;
            rb6.Visible = false;
            rb7.Visible = false;
            rb8.Visible = false;
        }
        private void h()
        {
            rb1.Visible = true;
            rb2.Visible = true;
            rb3.Visible = true;
            rb4.Visible = true;
            rb5.Visible = true;
            rb6.Visible = true;
            rb7.Visible = true;
            rb8.Visible = true;
        }
        private void X()
        {
            if (rb1.Checked)
            {
                x = 1;
            }
            if (rb2.Checked)
            {
                x = 2;
            }
            if (rb3.Checked)
            {
                x = 3;
            }
            if (rb4.Checked)
            {
                x = 4;
            }
            if (rb5.Checked)
            {
                x = 5;
            }
            if (rb6.Checked)
            {
                x = 6;
            }
            if (rb7.Checked)
            {
                x = 7;
            }
            if (rb8.Checked)
            {
                x = 8;
            }
        }
        private void Daugyba() {
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
        private void aa() {
            groupBox2.Visible = false;
        }
        private void bb()
        {
            rb1.Visible = true;
            rb2.Visible = true;
            rb3.Visible = false;
            rb4.Visible = false;
            rb5.Visible = false;
            rb6.Visible = false;
            rb7.Visible = false;
            rb8.Visible = false;
        }
        private void cc()
        {
            rb1.Visible = true;
            rb2.Visible = true;
            rb3.Visible = true;
            rb4.Visible = false;
            rb5.Visible = false;
            rb6.Visible = false;
            rb7.Visible = false;
            rb8.Visible = false;
        }
        private void dd()
        {
            rb1.Visible = true;
            rb2.Visible = true;
            rb3.Visible = true;
            rb4.Visible = true;
            rb5.Visible = false;
            rb6.Visible = false;
            rb7.Visible = false;
            rb8.Visible = false;
        }
        private void ee() 
        {
            rb1.Visible = true;
            rb2.Visible = true;
            rb3.Visible = true;
            rb4.Visible = true;
            rb5.Visible = true;
            rb6.Visible = false;
            rb7.Visible = false;
            rb8.Visible = false;
        }
        private void ff()
        {
            rb1.Visible = true;
            rb2.Visible = true;
            rb3.Visible = true;
            rb4.Visible = true;
            rb5.Visible = true;
            rb6.Visible = true;
            rb7.Visible = false;
            rb8.Visible = false;
        }
        private void gg()
        {
            rb1.Visible = true;
            rb2.Visible = true;
            rb3.Visible = true;
            rb4.Visible = true;
            rb5.Visible = true;
            rb6.Visible = true;
            rb7.Visible = true;
            rb8.Visible = false;
        }
        private void hh()
        {
            rb1.Visible = true;
            rb2.Visible = true;
            rb3.Visible = true;
            rb4.Visible = true;
            rb5.Visible = true;
            rb6.Visible = true;
            rb7.Visible = true;
            rb8.Visible = true;
        }
        private void A()
        {
            lbl1.Visible = true;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            txtNum1.Visible = true;
            txtNum2.Visible = false;
            txtNum3.Visible = false;
            txtNum4.Visible = false;
        }
        private void B()
        {
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = false;
            lbl4.Visible = false;
            txtNum1.Visible = true;
            txtNum2.Visible = true;
            txtNum3.Visible = false;
            txtNum4.Visible = false;
        }
        private void C()
        {
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = false;
            txtNum1.Visible = true;
            txtNum2.Visible = true;
            txtNum3.Visible = true;
            txtNum4.Visible = false;
        }
        private void D()
        {
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            txtNum1.Visible = true;
            txtNum2.Visible = true;
            txtNum3.Visible = true;
            txtNum4.Visible = true;
        }
    }
}