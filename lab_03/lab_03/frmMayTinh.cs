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
    
    public partial class frmMayTinh : Form
    {
        

        double so1 = 0, so2 = 0;
        double ketqua = 0;
        char pt;
        char error = 'E';
        public frmMayTinh()
        {
            InitializeComponent();
        }

        private void frmMayTinh_Load(object sender, EventArgs e)
        {


        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            txtketQua.Text = "";
        }

        private void btt0_Click(object sender, EventArgs e)
        {
            txtketQua.Text += "0";
        }

        private void bbt1_Click(object sender, EventArgs e)
        {
            txtketQua.Text += "1";
        }

        private void btt2_Click(object sender, EventArgs e)
        {
            txtketQua.Text += "2";
        }

        private void btt3_Click(object sender, EventArgs e)
        {
            txtketQua.Text += "3";
        }

        private void btt4_Click(object sender, EventArgs e)
        {
            txtketQua.Text += "4";
        }

        private void btt5_Click(object sender, EventArgs e)
        {
            txtketQua.Text += "5";
        }

        private void btt6_Click(object sender, EventArgs e)
        {
            txtketQua.Text += "6";
        }

        private void btt7_Click(object sender, EventArgs e)
        {
            txtketQua.Text += "7";
        }

        private void btt8_Click(object sender, EventArgs e)
        {
            txtketQua.Text += "8";
        }

        private void btt9_Click(object sender, EventArgs e)
        {
            txtketQua.Text += "9";
        }

        private void bttCong_Click(object sender, EventArgs e)
        {
            pt = '+';
            so1 = double.Parse(txtketQua.Text);
            txtketQua.Text = "";
        }

        private void bttTru_Click(object sender, EventArgs e)
        {
            pt = '-';
            so1 = double.Parse(txtketQua.Text);
            txtketQua.Text = "";
        }

        private void bttNhan_Click(object sender, EventArgs e)
        {
            pt = '*';
            so1 = double.Parse(txtketQua.Text);
            txtketQua.Text = "";
        }

        private void bttChia_Click(object sender, EventArgs e)
        {
            pt = '/';
            so1 = double.Parse(txtketQua.Text);
            txtketQua.Text = "";
        }

        public void Tinh(double n1, double n2, char pt)
        {
            double kq = 0;
            switch (pt) 
            {
                case '+':
                    kq = n1 + n2;
                    break;
                case '-':
                    kq = n1 - n2;
                    break;
                case '*':
                    kq = n1 * n2;
                    break;
                case '/':
                    if(n2 == 0)
                    {
                        MessageBox.Show("Phép tính không thể thực hiện....");
                    }
                    else
                    {
                        kq = n1 / n2;
                    }
                    break;
            }
            txtketQua.Text = kq.ToString();
        }
        private void bttBang_Click(object sender, EventArgs e)
        {
            so2 = double.Parse(txtketQua.Text);
            Tinh(so1, so2, pt);
    
        }

        private void bttAmDuong_Click(object sender, EventArgs e)
        {

            so1 = double.Parse (txtketQua.Text);
            so1 *= -1;
            txtketQua.Text = so1.ToString();

        }
    }
}
