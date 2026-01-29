using System;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ListView A
            lvA.View = View.Details;
            lvA.FullRowSelect = true;
            lvA.GridLines = true;
            lvA.Columns.Add("STT", 50);
            lvA.Columns.Add("Mã SV", 100);
            lvA.Columns.Add("Họ tên", 200);

            // ListView B
            lvB.View = View.Details;
            lvB.FullRowSelect = true;
            lvB.GridLines = true;
            lvB.Columns.Add("STT", 50);
            lvB.Columns.Add("Mã SV", 100);
            lvB.Columns.Add("Họ tên", 200);
        }

        private bool KiemTraTrungMSV(string msv)
        {
            // Kiểm tra trong lvA
            foreach (ListViewItem item in lvA.Items)
            {
                if (item.SubItems[1].Text == msv)
                    return true;
            }

            // Kiểm tra trong lvB
            foreach (ListViewItem item in lvB.Items)
            {
                if (item.SubItems[1].Text == msv)
                    return true;
            }

            return false;
        }


        private void txtMSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        private void CapNhatSTT(ListView lv)
        {
            for (int i = 0; i < lv.Items.Count; i++)
            {
                lv.Items[i].SubItems[0].Text = (i + 1).ToString();
            }
        }


        private void bttCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMSV.Text == "" || txtHoTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ Mã SV và Họ tên!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- KIỂM TRA TRÙNG ---
            if (KiemTraTrungMSV(txtMSV.Text))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int stt = lvA.Items.Count + 1;

            ListViewItem item = new ListViewItem(stt.ToString());
            item.SubItems.Add(txtMSV.Text);
            item.SubItems.Add(txtHoTen.Text);

            lvA.Items.Add(item);

            txtMSV.Clear();
            txtHoTen.Clear();
            txtMSV.Focus();
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            if (lvA.SelectedItems.Count > 0)
            {
                lvA.Items.Remove(lvA.SelectedItems[0]);
                CapNhatSTT(lvA);
                return;
            }

            if (lvB.SelectedItems.Count > 0)
            {
                lvB.Items.Remove(lvB.SelectedItems[0]);
                CapNhatSTT(lvB);
                return;
            }

            MessageBox.Show("Bạn chưa chọn sinh viên để xóa!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bttTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text.ToLower();

            if (key == "")
            {
                MessageBox.Show("Hãy nhập từ khóa để tìm!", "Thông báo");
                return;
            }

            foreach (ListViewItem it in lvA.Items)
            {
                if (it.SubItems[2].Text.ToLower().Contains(key))
                {
                    it.Selected = true;
                    it.Focused = true;
                    it.EnsureVisible();
                    return;
                }
            }

            MessageBox.Show("Không tìm thấy sinh viên!", "Thông báo");
        }

        private void bttQua_Click(object sender, EventArgs e)
        {
            if (lvA.SelectedItems.Count == 0) return;

            ListViewItem old = lvA.SelectedItems[0];

            ListViewItem newItem = new ListViewItem((lvB.Items.Count + 1).ToString());
            newItem.SubItems.Add(old.SubItems[1].Text);
            newItem.SubItems.Add(old.SubItems[2].Text);

            lvB.Items.Add(newItem);
            lvA.Items.Remove(old);

            CapNhatSTT(lvA);
        }

        private void bttLai_Click(object sender, EventArgs e)
        {
            if (lvB.SelectedItems.Count == 0) return;

            ListViewItem old = lvB.SelectedItems[0];

            ListViewItem newItem = new ListViewItem((lvA.Items.Count + 1).ToString());
            newItem.SubItems.Add(old.SubItems[1].Text);
            newItem.SubItems.Add(old.SubItems[2].Text);

            lvA.Items.Add(newItem);
            lvB.Items.Remove(old);

            CapNhatSTT(lvB);
        }

        private void bttQuaHet_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem it in lvA.Items)
            {
                ListViewItem newItem = new ListViewItem((lvB.Items.Count + 1).ToString());
                newItem.SubItems.Add(it.SubItems[1].Text);
                newItem.SubItems.Add(it.SubItems[2].Text);
                lvB.Items.Add(newItem);
            }

            lvA.Items.Clear();
        }

        private void bttLaiHet_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem it in lvB.Items)
            {
                ListViewItem newItem = new ListViewItem((lvA.Items.Count + 1).ToString());
                newItem.SubItems.Add(it.SubItems[1].Text);
                newItem.SubItems.Add(it.SubItems[2].Text);
                lvA.Items.Add(newItem);
            }

            lvB.Items.Clear();
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
