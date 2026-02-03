using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Lab08_QLSV_SQL
{
    public partial class Form1 : Form
    {

        string connectionString =
        "Data Source=DESKTOP-IATPBA6;Initial Catalog=StudentDB;Integrated Security=True;Trust Server Certificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            string sql = "SELECT * FROM SinhVien";


            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dtgv1.DataSource = dt;
        }


        //Lấy dữ liệu của khoa
        void LoadKhoa()
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            string sql = "SELECT MaKhoa, TenKhoa FROM Khoa";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dtKhoa = new DataTable();
            da.Fill(dtKhoa);

            cboMaKhoa.DataSource = dtKhoa;
            cboMaKhoa.DisplayMember = "TenKhoa"; // hiển thị tên khoa
            cboMaKhoa.ValueMember = "MaKhoa";    // lưu mã khoa
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();

            LoadKhoa();


            dtgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dtgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv1.Rows[e.RowIndex];

                txtMaSV.Text = row.Cells["MaSo"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);

                bool gt = Convert.ToBoolean(row.Cells["GioiTinh"].Value);
                rdbNam.Checked = gt;
                rdbNu.Checked = !gt;

                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["DienThoai"].Value.ToString();
                //txtMaKhoa.Text = row.Cells["MaKhoa"].Value.ToString();
                cboMaKhoa.SelectedValue = row.Cells["MaKhoa"].Value.ToString();
            }
        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNam.Focused && dtgv1.CurrentRow != null)
            {
                DataRowView currentRow = dtgv1.CurrentRow.DataBoundItem as DataRowView;
                if (currentRow != null)
                {
                    currentRow["GioiTinh"] = rdbNam.Checked;
                }
            }
        }


        private void dtgv1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void cboMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboMaKhoa.Focused && dtgv1.CurrentRow != null)
            //{
            //    DataRowView row = dtgv1.CurrentRow.DataBoundItem as DataRowView;
            //    if (row != null)
            //    {
            //        row["MaKhoa"] = cboMaKhoa.SelectedValue;
            //    }
            //}
        }

        private bool CheckInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                return false;
            }

            if (!long.TryParse(txtSoDienThoai.Text, out _))
            {
                MessageBox.Show("Số điện thoại chỉ được nhập số!");
                return false;
            }

            if (cboMaKhoa.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khoa!");
                return false;
            }

            return true;
        }

        private void Clear()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            dtpNgaySinh.Value = DateTime.Now;

            if (cboMaKhoa.Items.Count > 0)
                cboMaKhoa.SelectedIndex = 0;

            rdbNam.Checked = true;
        }
        private void bttThem_Click(object sender, EventArgs e)
        {
            if(!CheckInput()) return;

            using SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                // Kiểm tra trùng mã
                string checkSql = "SELECT COUNT(*) FROM SinhVien WHERE MaSo = @MaSo";
                using SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                checkCmd.Parameters.Add("@MaSo", SqlDbType.NVarChar).Value = txtMaSV.Text.Trim();

                if ((int)checkCmd.ExecuteScalar() > 0)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!");
                    return;
                }

                // Thêm mới
                string sql = @"INSERT INTO SinhVien 
            (MaSo, HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai, MaKhoa)
            VALUES (@MaSo, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @DienThoai, @MaKhoa)";

                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@MaSo", SqlDbType.NVarChar).Value = txtMaSV.Text.Trim();
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = txtHoTen.Text.Trim();
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dtpNgaySinh.Value;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = rdbNam.Checked;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text.Trim();
                cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar).Value = txtSoDienThoai.Text.Trim();
                cmd.Parameters.Add("@MaKhoa", SqlDbType.NVarChar).Value = cboMaKhoa.SelectedValue;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm sinh viên thành công!");
                LoadData();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;

            using SqlConnection conn = new SqlConnection(connectionString);
            string sql = @"UPDATE SinhVien SET
            HoTen = @HoTen,
            NgaySinh = @NgaySinh,
            GioiTinh = @GioiTinh,
            DiaChi = @DiaChi,
            DienThoai = @DienThoai,
            MaKhoa = @MaKhoa
        WHERE MaSo = @MaSo";

            using SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@MaSo", SqlDbType.NVarChar).Value = txtMaSV.Text.Trim();
            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = txtHoTen.Text.Trim();
            cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dtpNgaySinh.Value;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.Bit).Value = rdbNam.Checked;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = txtDiaChi.Text.Trim();
            cmd.Parameters.Add("@DienThoai", SqlDbType.NVarChar).Value = txtSoDienThoai.Text.Trim();
            cmd.Parameters.Add("@MaKhoa", SqlDbType.NVarChar).Value = cboMaKhoa.SelectedValue;

            try
            {
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show(rows > 0 ? "Cập nhật thành công!" : "Không tìm thấy sinh viên!");

                LoadData();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn chắc muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            using SqlConnection conn = new SqlConnection(connectionString);
            string sql = "DELETE FROM SinhVien WHERE MaSo = @MaSo";

            using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@MaSo", SqlDbType.NVarChar).Value = txtMaSV.Text.Trim();

            try
            {
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show(rows > 0 ? "Xóa thành công!" : "Không tìm thấy sinh viên!");

                LoadData();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
