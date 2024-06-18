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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fizikinis_skaiciuotuvas frm3 = new Fizikinis_skaiciuotuvas();
            frm3.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Plotai frm4 = new Plotai();
            frm4.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tūriai frm5 = new Tūriai();
            frm5.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
