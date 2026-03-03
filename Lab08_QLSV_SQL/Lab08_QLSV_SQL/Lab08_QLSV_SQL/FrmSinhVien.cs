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
    public partial class FrmSinhVien : Form
    {

        // Thêm TrustServerCertificate=True; và Encrypt=False;
        SqlConnection conn = new SqlConnection("Server=DESKTOP-IATPBA6;" + "Database=StudentDB;" + "Trusted_Connection=True;" + "TrustServerCertificate=True;");
        SqlDataAdapter da;
        DataTable dtSinhVien = new DataTable();
        DataTable dtKhoa = new DataTable();
        BindingSource bs = new BindingSource();
        public FrmSinhVien()
        {
            InitializeComponent();
        }

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            try
            {
                // --- BƯỚC 1: Lấy dữ liệu Khoa đổ vào ComboBox ---
                SqlDataAdapter daKhoa = new SqlDataAdapter("SELECT MaKhoa, TenKhoa FROM Khoa", conn);
                daKhoa.Fill(dtKhoa);

                cbKhoa.DataSource = dtKhoa;
                cbKhoa.DisplayMember = "TenKhoa";
                cbKhoa.ValueMember = "MaKhoa";

                // --- BƯỚC 2: Lấy dữ liệu Sinh Viên ---
                da = new SqlDataAdapter("SELECT * FROM SinhVien", conn);

                // QUAN TRỌNG: Dòng này tự động tạo lệnh INSERT, UPDATE, DELETE
                SqlCommandBuilder builder = new SqlCommandBuilder(da);

                da.Fill(dtSinhVien);

                // --- BƯỚC 3: Thiết lập BindingSource ---
                bs.DataSource = dtSinhVien;
                dgvSinhVien.DataSource = bs;

                // --- BƯỚC 4: Binding dữ liệu vào các ô TextBox/Date/Combo ---
                // Xóa binding cũ để tránh lỗi nếu hàm Load chạy lại (ít khi xảy ra nhưng an toàn)
                txtMSSV.DataBindings.Clear();
                txtHoTen.DataBindings.Clear();
                dtpNgaySinh.DataBindings.Clear();
                txtDiaChi.DataBindings.Clear();
                txtSDT.DataBindings.Clear();
                cbKhoa.DataBindings.Clear();
                rdNam.DataBindings.Clear();

                // Tham số: "Thuộc tính control", nguồn dữ liệu, "Tên cột trong SQL", format, update mode
                txtMSSV.DataBindings.Add("Text", bs, "MaSo", true);
                txtHoTen.DataBindings.Add("Text", bs, "HoTen", true);
                dtpNgaySinh.DataBindings.Add("Value", bs, "NgaySinh", true);
                txtDiaChi.DataBindings.Add("Text", bs, "DiaChi", true);
                txtSDT.DataBindings.Add("Text", bs, "DienThoai", true);

                // Binding ComboBox: Khi chọn grid, combo tự nhảy theo MaKhoa
                cbKhoa.DataBindings.Add("SelectedValue", bs, "MaKhoa", true, DataSourceUpdateMode.OnPropertyChanged);

                // Binding RadioButton:
                // Giả sử cột GioiTinh trong SQL là bit (True=Nam, False=Nữ)
                // Ta chỉ cần bind cho nút Nam, nút Nữ sẽ tự đảo ngược bằng code sự kiện bên dưới
                rdNam.DataBindings.Add("Checked", bs, "GioiTinh", true, DataSourceUpdateMode.OnPropertyChanged);

                // Logic hiển thị: Khi nút Nam thay đổi, nút Nữ sẽ ngược lại
                rdNam.CheckedChanged += (s, args) => { rdNu.Checked = !rdNam.Checked; };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        
        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNam.Focused)
            {
                DataRowView currentView = (DataRowView)bs.Current;
                currentView["GioiTinh"] = rdNam.Checked;
            }
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNu.Focused)
            {
                DataRowView currentView = (DataRowView)bs.Current;
                currentView["GioiTinh"] = rdNu.Checked;
            }
        }

        // 1. Tạo dòng mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            // BindingSource hỗ trợ thêm mới cực nhanh
            bs.AddNew();

            // Thiết lập giá trị mặc định cho dòng mới (nếu cần)
            if (bs.Current != null)
            {
                DataRowView currentRow = (DataRowView)bs.Current;
                currentRow["GioiTinh"] = true; // Mặc định là Nam
                currentRow["NgaySinh"] = DateTime.Now;
                // Mặc định chọn khoa đầu tiên
                if (dtKhoa.Rows.Count > 0)
                    currentRow["MaKhoa"] = dtKhoa.Rows[0]["MaKhoa"];
            }

            // Đưa con trỏ về ô nhập liệu đầu tiên
            bs.ResetCurrentItem();
            txtMSSV.Focus();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                // Xác nhận dữ liệu từ các TextBox đã nạp vào dòng hiện tại của DataTable
                this.Validate();
                bs.EndEdit();

                // Tự động sinh lệnh INSERT/UPDATE
                SqlCommandBuilder builder = new SqlCommandBuilder(da);

                // Đẩy dữ liệu xuống SQL
                da.Update(dtSinhVien);

                MessageBox.Show("Đã lưu dữ liệu thành công!", "Thông báo");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi CSDL: " + ex.Message);

                // Nạp lại dữ liệu để xóa các dòng lỗi trên giao diện
                dtSinhVien.Clear();
                da.Fill(dtSinhVien);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 0. Kiểm tra có sinh viên hay không
            if (bs.Count == 0 || bs.Current == null)
            {
                MessageBox.Show("Không có sinh viên nào để xóa.");
                return;
            }

            // 1. Lấy thông tin sinh viên hiện tại đang chọn
            DataRowView currentRow = (DataRowView)bs.Current;
            string tenSV = currentRow["HoTen"].ToString();

            // 2. Hiển thị hộp thoại xác nhận (Confirm)
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên {tenSV} không?",
                                                 "Xác nhận xóa",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // 3. Xóa dòng khỏi BindingSource
                    bs.RemoveCurrent();

                    // 4. Cập nhật ngay lập tức xuống CSDL
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    da.Update(dtSinhVien);

                    MessageBox.Show("Đã xóa sinh viên thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi");
                    // Nếu lỗi (vướng khóa ngoại), nạp lại dữ liệu để đồng bộ grid
                    dtSinhVien.Clear();
                    da.Fill(dtSinhVien);
                }

            }
        }
    }
}
