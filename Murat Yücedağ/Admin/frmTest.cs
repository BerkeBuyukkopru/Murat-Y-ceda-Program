using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Murat_Yücedağ.Admin
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnkare_Click(object sender, EventArgs e)
        {
            int sayi, sonuc;
            sayi =Convert.ToInt32 (textBox1.Text);
            sonuc = sayi * sayi;
            label1.Text = sonuc.ToString();
        }

        private void btnTekmiCiftmi_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32 (textBox1.Text);
            if(sayi%2==0)
            {
                label1.Text = "Çift";
            }
            else
            {
                label1.Text = "Tek";
            }
        }

        private void btnBakteri_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            int sayi
        }
    }
}
