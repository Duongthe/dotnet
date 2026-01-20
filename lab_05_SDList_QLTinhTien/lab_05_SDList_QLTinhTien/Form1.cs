using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace lab_05_SDList_QLTinhTien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) 
                == DialogResult.Yes))
                {
                this.Close();
            }
        }


        private void GetPay()
        {
            //Kiểm tra đã có tên chưa
            if(string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông Báo");
                return;
            }

            double total = 0;
            if (ckbCaoVoi.Checked) total += 100000;
            if (ckbTayRang.Checked) total += 300000;
            if (ckbChupHinh.Checked) total += 200000;

            total += ((int)nudTramRang.Value * 500000);

            txtTongTien.Text = total.ToString("N0") + "đ";

        }
        private void bttTinhTien_Click(object sender, EventArgs e)
        {
            GetPay();
        }

        private void bttLuuVaoDanhSach_Click(object sender, EventArgs e)
        {
            string info = txtTen.Text + " - " + txtTongTien.Text;
            ltbDanhSach.Items.Add(info);
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            if(ltbDanhSach.SelectedIndex != -1)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa khách hàng đã chọn hay không", "yes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    ltbDanhSach.Items.RemoveAt(ltbDanhSach.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng từ danh sách để xóa!", "Thông báo");
            }
        }
        string filePath = @"D:\dotnet\lab_05_SDList_QLTinhTien\database.txt";
        private void bttLuuFile_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra nếu thư mục chưa tồn tại thì tạo mới
                string directory = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // 2. Mở StreamWriter để ghi file (ghi đè nội dung cũ)
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (var item in ltbDanhSach.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }

                MessageBox.Show("Đã lưu danh sách vào file thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu file: " + ex.Message, "Lỗi");
            }
        }

        private void bttTaiFile_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra file có tồn tại hay không
                if (File.Exists(filePath))
                {
                    // 2. Xóa danh sách hiện tại trên ListBox để nạp mới
                    ltbDanhSach.Items.Clear();

                    // 3. Đọc từng dòng từ file và nạp vào ListBox
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            ltbDanhSach.Items.Add(line);
                        }
                    }

                    MessageBox.Show("Đã tải dữ liệu từ file lên danh sách!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy file dữ liệu tại đường dẫn chỉ định.", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải file: " + ex.Message, "Lỗi");
            }

        }
    }
}
