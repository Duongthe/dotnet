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
    public partial class frmQLSinhVien : Form
    {
        public frmQLSinhVien()
        {
            InitializeComponent();
        }

        private void bttCapNhat_Click(object sender, EventArgs e)
        {
            if(txtNhap.Text != "")
            {
                lstA.Items.Add(txtNhap.Text);
                txtNhap.Clear();
                txtNhap.Focus();
            }    
        }

        private void bttKetThuc_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn có chắc chắn muốn kết thúc?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                this.Close();
            }
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            if (lstA.SelectedIndex != -1)
            {
                lstA.Items.RemoveAt(lstA.SelectedIndex);
                return;
            }

            if (lstB.SelectedIndex != -1)
            {
                lstB.Items.RemoveAt(lstB.SelectedIndex);
                return;
            }
            MessageBox.Show("Bạn chưa chọn sinh viên để xóa!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void bttQua_Click(object sender, EventArgs e)
        {
            if(lstA.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn sinh viên", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                int n = lstA.SelectedItems.Count;
                for (int i = 0; i <= n - 1; i++)
                    lstB.Items.Add(lstA.SelectedItems[i].ToString());
                for (int j = n - 1; j >= 0; j--)
                    lstA.Items.RemoveAt(j);
            }    

        }

        private void bttLai_Click(object sender, EventArgs e)
        {
           /* if (lstA.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn sinh viên", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {*/
                int n = lstB.SelectedItems.Count;
                for (int i = 0; i <= n - 1; i++)
                    lstA.Items.Add(lstB.SelectedItems[i].ToString());
                for (int j = n - 1; j >= 0; j--)
                    lstB.Items.RemoveAt(j);
            //}    

        }

        private void bttQuaHet_Click(object sender, EventArgs e)
        {
            int n = lstA.Items.Count;
            for (int i = 0; i <= n - 1; i++)
                lstB.Items.Add(lstA.Items[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                lstA.Items.RemoveAt(j);
        }

        private void bttLaiHet_Click(object sender, EventArgs e)
        {
            int n = lstB.Items.Count;
            for (int i = 0; i <= n - 1; i++)
                lstA.Items.Add(lstB.Items[i].ToString());
            for (int j = n - 1; j >= 0; j--)
                lstB.Items.RemoveAt(j);
        }

        private void txtNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttCapNhat.PerformClick();
            }
        }
    }
}
