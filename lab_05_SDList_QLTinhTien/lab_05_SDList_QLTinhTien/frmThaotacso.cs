using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_05_SDList_QLTinhTien
{
    public partial class frmThaotacso : Form
    {
        public frmThaotacso()
        {
            InitializeComponent();
        }

        private void bttKetThuc_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn có chắc chắn muốn kết thúc?", "Thông báo", MessageBoxButtons.YesNo)== DialogResult.Yes))
            {
                this.Close();
            }
        }


        private void bttCapNhat_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text != "")
            {
                lstHienThi.Items.Add(txtNhap.Text);
                txtNhap.Clear();
                txtNhap.Focus();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập số", " Thông báo", MessageBoxButtons.OK);
            }
        }

        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttCapNhat.PerformClick();
            }
        }

        private void bttTang_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstHienThi.Items.Count; i++)
            {
                int x = int.Parse(lstHienThi.Items[i].ToString());
                lstHienThi.Items[i] = (x + 2).ToString();
            }
        }

        private void bttChonChan_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstHienThi.Items.Count; i++)
            {
                int x = int.Parse(lstHienThi.Items[i].ToString());
                if (x % 2 == 0)
                {
                    lstHienThi.SelectedIndex = i;
                    return;
                }
            }
        }

        private void bttChonLe_Click(object sender, EventArgs e)
        {
            for (int i = lstHienThi.Items.Count - 1; i >= 0; i--)
            {
                int x = int.Parse(lstHienThi.Items[i].ToString());
                if (x % 2 != 0)
                {
                    lstHienThi.SelectedIndex = i;
                    return;
                }
            }
        }

        private void bttXoaPhanTu_Click(object sender, EventArgs e)
        {
            if (lstHienThi.SelectedIndex != -1)
                lstHienThi.Items.RemoveAt(lstHienThi.SelectedIndex);
        }

        private void bttXoaDau_Click(object sender, EventArgs e)
        {
            if (lstHienThi.Items.Count > 0)
                lstHienThi.Items.RemoveAt(0);
        }

        private void bttXoaCuoi_Click(object sender, EventArgs e)
        {
            if (lstHienThi.Items.Count > 0)
                lstHienThi.Items.RemoveAt(lstHienThi.Items.Count - 1);
        }


    }
}
