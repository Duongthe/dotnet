using System;
using System.IO;
using System.Windows.Forms;

namespace Lab08_QLSV_SQL
{
    public partial class FrmNote : Form
    {
        string folderPath = @"D:\dotnet\Lab08_QLSV_SQL\Lab08_QLSV_SQL\note";

        public FrmNote()
        {
            InitializeComponent();
        }

        private void FrmNote_Load(object sender, EventArgs e)
        {
            // tạo thư mục nếu chưa có
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // chèn ngày giờ vào note
            rtbNote.Text = "Ngày: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + Environment.NewLine;
        }

        // LƯU NOTE
        private void bttLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = "Note_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
                string fullPath = Path.Combine(folderPath, fileName);

                File.WriteAllText(fullPath, rtbNote.Text);

                MessageBox.Show("Đã lưu note vào:\n" + fullPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        // TẠO NOTE MỚI 
        private void bttTaoMoi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn lưu ghi chú hiện tại không?",
                "Thông báo",
                MessageBoxButtons.YesNoCancel
            );

            if (result == DialogResult.Yes)
            {
                bttLuu_Click(sender, e);
            }

            if (result != DialogResult.Cancel)
            {
                rtbNote.Clear();
                rtbNote.Text = "Ngày: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + Environment.NewLine;
            }
        }

        //MỞ NOTE
        private void bttMo_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.InitialDirectory = folderPath;
            open.Filter = "Text File (*.txt)|*.txt";

            if (open.ShowDialog() == DialogResult.OK)
            {
                rtbNote.Text = File.ReadAllText(open.FileName);
            }
        }
    }
}