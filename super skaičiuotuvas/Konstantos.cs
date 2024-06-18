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
    public partial class Konstantos : Form
    {
        public Konstantos()
        {
            InitializeComponent();
        }

        private void tsbChoose_Click(object sender, EventArgs e)
        {
            this.Close();
            Fizikinis_skaiciuotuvas frm3 = new Fizikinis_skaiciuotuvas();
            frm3.Show();
        }
    }
}
