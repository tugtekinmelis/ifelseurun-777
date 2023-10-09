using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ürün_indirimi1_777
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

        }

        private void lblİndirimlifiyat_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click_1(object sender, EventArgs e)
        {
            double tutar = Convert.ToDouble(txtTutar.Text);
            if (rb5.Checked)
            {
                tutar=tutar * 0.95; // yüzde 5 indirim
            }
            else if (rb10.Checked)
            {
                tutar = tutar * 0.90;
            }
            else if (rb15.Checked)
            {
                tutar = tutar * 0.85;
            }
            else if (rb25.Checked)
            {
                tutar = tutar * 0.75;
            }
        }
    }
}
