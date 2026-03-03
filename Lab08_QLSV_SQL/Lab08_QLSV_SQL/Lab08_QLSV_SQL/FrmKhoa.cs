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
    public partial class FrmKhoa : Form
    {
        SqlConnection conn = new SqlConnection("Server=DESKTOP-IATPBA6;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;");
        SqlDataAdapter daKhoa;
        DataTable dtKhoa = new DataTable();
        BindingSource bsKhoa = new BindingSource();
        public FrmKhoa()
        {
            InitializeComponent();
        }

        private void FrmKhoa_Load(object sender, EventArgs e)
        {
            try
            {
                daKhoa = new SqlDataAdapter("SELECT * FROM Khoa", conn);

                // Tự sinh Insert / Update / Delete
                SqlCommandBuilder builder = new SqlCommandBuilder(daKhoa);

                daKhoa.Fill(dtKhoa);

                bsKhoa.DataSource = dtKhoa;
                dgvKhoa.DataSource = bsKhoa;

                // Binding
                txtMaKhoa.DataBindings.Clear();
                txtTenKhoa.DataBindings.Clear();

                txtMaKhoa.DataBindings.Add("Text", bsKhoa, "MaKhoa", true);
                txtTenKhoa.DataBindings.Add("Text", bsKhoa, "TenKhoa", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load Khoa: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bsKhoa.AddNew();
            bsKhoa.ResetCurrentItem();

            txtMaKhoa.Enabled = true;
            txtMaKhoa.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                bsKhoa.EndEdit();

                SqlCommandBuilder builder = new SqlCommandBuilder(daKhoa);

                daKhoa.Update(dtKhoa);

                MessageBox.Show("Đã lưu dữ liệu Khoa!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi CSDL: " + ex.Message);

                // Rollback
                dtKhoa.Clear();
                daKhoa.Fill(dtKhoa);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bsKhoa.Count == 0 || bsKhoa.Current == null)
            {
                MessageBox.Show("Không có khoa để xóa");
                return;
            }

            DataRowView currentRow = (DataRowView)bsKhoa.Current;
            string tenKhoa = currentRow["TenKhoa"].ToString();

            DialogResult rs = MessageBox.Show(
                $"Bạn có chắc muốn xóa khoa {tenKhoa}?",
                "Xác nhận",
                MessageBoxButtons.YesNo
            );

            if (rs == DialogResult.Yes)
            {
                try
                {
                    bsKhoa.RemoveCurrent();

                    SqlCommandBuilder builder = new SqlCommandBuilder(daKhoa);
                    daKhoa.Update(dtKhoa);

                    MessageBox.Show("Đã xóa khoa thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa khoa đang được sử dụng!");

                    dtKhoa.Clear();
                    daKhoa.Fill(dtKhoa);
                }
            }
        }

        
    }
}
