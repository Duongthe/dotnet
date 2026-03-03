using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace Lab08_QLSV_SQL
{
    public partial class FrmKetQua : Form
    {
        SqlConnection conn = new SqlConnection(
             "Server=DESKTOP-IATPBA6;" +
             "Database=StudentDB;" +
             "Trusted_Connection=True;" +
             "TrustServerCertificate=True;"
         );

        SqlDataAdapter da;
        DataTable dtKetQua = new DataTable();
        DataTable dtSinhVien = new DataTable();
        DataTable dtMonHoc = new DataTable();
        BindingSource bs = new BindingSource();
        public FrmKetQua()
        {
            InitializeComponent();
        }

        private void FrmKetQua_Load(object sender, EventArgs e)
        {
            try
            {
                // ===== Load SinhVien =====
                SqlDataAdapter daSV = new SqlDataAdapter(
                    "SELECT MaSo, HoTen FROM SinhVien", conn);
                daSV.Fill(dtSinhVien);

                cbSinhVien.DataSource = dtSinhVien;
                cbSinhVien.DisplayMember = "HoTen";
                cbSinhVien.ValueMember = "MaSo";

                // ===== Load MonHoc =====
                SqlDataAdapter daMH = new SqlDataAdapter(
                    "SELECT MaMH, TenMH FROM Mon", conn);
                daMH.Fill(dtMonHoc);

                cbMonHoc.DataSource = dtMonHoc;
                cbMonHoc.DisplayMember = "TenMH";
                cbMonHoc.ValueMember = "MaMH";

                // ===== Load KetQua =====
                da = new SqlDataAdapter("SELECT * FROM KetQua", conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);

                da.Fill(dtKetQua);

                bs.DataSource = dtKetQua;
                dgvKetQua.DataSource = bs;

                // ===== Binding =====
                cbSinhVien.DataBindings.Clear();
                cbMonHoc.DataBindings.Clear();
                txtDiem.DataBindings.Clear();

                cbSinhVien.DataBindings.Add(
                    "SelectedValue", bs, "MaSo", true, DataSourceUpdateMode.OnPropertyChanged);

                cbMonHoc.DataBindings.Add(
                    "SelectedValue", bs, "MaMH", true, DataSourceUpdateMode.OnPropertyChanged);

                txtDiem.DataBindings.Add(
                    "Text", bs, "Diem", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load kết quả: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bs.AddNew();

            if (bs.Current != null)
            {
                DataRowView row = (DataRowView)bs.Current;
                row["Diem"] = 0;
            }

            txtDiem.Focus();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                bs.EndEdit();

                da.Update(dtKetQua);

                MessageBox.Show("Lưu điểm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu điểm: " + ex.Message);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bs.Current == null)
            {
                MessageBox.Show("Không có dòng để xóa!");
                return;
            }

            DialogResult r = MessageBox.Show(
                "Bạn có chắc muốn xóa điểm này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
            {
                try
                {
                    bs.RemoveCurrent();
                    da.Update(dtKetQua);
                    MessageBox.Show("Xóa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message);
                }
            }
        }
    }
}
