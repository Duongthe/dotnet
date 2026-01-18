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
    public partial class frmUocBoi : Form
    {
        public frmUocBoi()
        {
            InitializeComponent();
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }

        }


        private int timUSCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;

        }

        private int timBSCNN(int a, int b)
        {
            return (a * b) / timUSCLN(a, b);
        }
        private void bttTim_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoA.Text);
            int b = int.Parse(txtSoB.Text);
            if (rdbUC.Checked)
            {
                txtKetQua.Text = timUSCLN(a, b).ToString();
            }
            else if(rdbBC.Checked)
            {
                txtKetQua.Text = timBSCNN(a, b).ToString();
            }    

        }

        private void bttBoQua_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = "";
            txtSoA.Text = "";
            txtSoB.Text = "";
            rdbBC.Checked = false;
            rdbUC.Checked = false;
            txtSoA.Focus();
        }
    }
}
