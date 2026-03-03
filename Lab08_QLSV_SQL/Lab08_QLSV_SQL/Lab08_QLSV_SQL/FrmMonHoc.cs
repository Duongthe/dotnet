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
    public partial class FrmMonHoc : Form
    {
        SqlConnection conn = new SqlConnection(
           "Server=DESKTOP-IATPBA6;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;"
       );

        SqlDataAdapter da;
        DataTable dtMonHoc = new DataTable();
        BindingSource bs = new BindingSource();
        public FrmMonHoc()
        {
            InitializeComponent();
        }

        
        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Mon", conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);

                dtMonHoc.Clear();
                da.Fill(dtMonHoc);

                bs.DataSource = dtMonHoc;
                dgvMonHoc.DataSource = bs;

                // Clear binding cũ
                txtMaMonHoc.DataBindings.Clear();
                txtTenMonHoc.DataBindings.Clear();
                txtSoTiet.DataBindings.Clear();

                // Binding mới
                txtMaMonHoc.DataBindings.Add("Text", bs, "MaMH", true);
                txtTenMonHoc.DataBindings.Add("Text", bs, "TenMH", true);
                txtSoTiet.DataBindings.Add("Text", bs, "SoTiet", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load môn học: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            txtMaMonHoc.Focus();

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                bs.EndEdit();

                da.Update(dtMonHoc);

                MessageBox.Show("Lưu thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bs.Current == null)
            {
                MessageBox.Show("Không có môn học để xóa!");
                return;
            }

            string tenMH = ((DataRowView)bs.Current)["TenMH"].ToString();

            DialogResult r = MessageBox.Show(
                $"Bạn có chắc muốn xóa môn học: {tenMH}?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
            {
                try
                {
                    bs.RemoveCurrent();
                    da.Update(dtMonHoc);

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
