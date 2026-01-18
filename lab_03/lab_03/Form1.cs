using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_03
{
    public partial class frmPhepTinh : Form
    {
        public frmPhepTinh()
        {
            InitializeComponent();
        }


        private void bttThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            txtSoN.Text = "";
            txtSoM.Text = "";
            txtKetQua.Text = "";
            txtSoN.Focus();
            
        }

        private void bttCong_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txtSoN.Text);
            double m = double.Parse(txtSoM.Text);

            double tong = n + m;
            txtKetQua.Text = tong.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttTru_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txtSoN.Text);
            double m = double.Parse(txtSoM.Text);

            double hieu = n - m;
            txtKetQua.Text = hieu.ToString();

        }

        private void bttNhan_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txtSoN.Text);
            double m = double.Parse(txtSoM.Text);

            double thuong = n * m;
            txtKetQua.Text = thuong.ToString();
        }

        private void bttChia_Click(object sender, EventArgs e)
        {

            double n = double.Parse(txtSoN.Text);
            double m = double.Parse(txtSoM.Text);
            if (m != 0)
            {
                double thuong = n / m;
                txtKetQua.Text = thuong.ToString();
            }
            else
            {
                txtKetQua.Text = "Không thể thực hiện phép chia cho 0!";
            }

        }
    }
}
