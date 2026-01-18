using System;
using System.IO;
using System.Windows.Forms;

namespace lab_03
{
    public partial class SecurityPanel : Form
    {
        public SecurityPanel()
        {
            InitializeComponent();
        }

        private void SecurityPanel_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;   // Cho phép form bắt phím
        }

        private void WriteLogToFile(string text)
        {
            string path = Application.StartupPath + "\\AccessLog.txt";
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(text);
            }
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            txtketQua.Text = "";
            bttThang.Focus();
        }

        private void btt0_Click(object sender, EventArgs e) 
        {
            txtketQua.Text += "0"; 
        }
        private void bbt1_Click(object sender, EventArgs e) 
        { 
            txtketQua.Text += "1"; 
        }
        private void btt2_Click(object sender, EventArgs e) 
        { 
            txtketQua.Text += "2"; 
        }
        private void btt3_Click(object sender, EventArgs e) 
        { 
            txtketQua.Text += "3"; 
        }
        private void btt4_Click(object sender, EventArgs e) 
        { 
            txtketQua.Text += "4"; 
        }
        private void btt5_Click(object sender, EventArgs e) 
        { 
            txtketQua.Text += "5"; 
        }
        private void btt6_Click(object sender, EventArgs e) 
        { 
            txtketQua.Text += "6"; 
        }
        private void btt7_Click(object sender, EventArgs e) 
        { 
            txtketQua.Text += "7"; 
        }
        private void btt8_Click(object sender, EventArgs e) 
        { 
            txtketQua.Text += "8"; 
        }
        private void btt9_Click(object sender, EventArgs e) 
        { 
            txtketQua.Text += "9"; 
        }

        private void bttThang_Click(object sender, EventArgs e)
        {
            string code = txtketQua.Text;
            string time = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            string logText = "";

            // 1. Restricted Access (chỉ 1 ký tự)
            if (code.Length == 1)
            {
                logText = $"{time}   Restricted Access!";
                lstHienThi.Items.Add(logText);
                WriteLogToFile(logText);
                txtketQua.Text = "";
                return;
            }

            // 2. Technicians
            if (code == "1645" || code == "1689")
            {
                logText = $"{time}   Technicians";
                lstHienThi.Items.Add(logText);
                WriteLogToFile(logText);
                txtketQua.Text = "";
                return;
            }

            // 3. Custodians
            if (code == "8345")
            {
                logText = $"{time}   Custodians";
                lstHienThi.Items.Add(logText);
                WriteLogToFile(logText);
                txtketQua.Text = "";
                return;
            }

            // 4. Scientists
            if (code == "9998" || code == "1006" || code == "1007" || code == "1008")
            {
                logText = $"{time}   Scientists";
                lstHienThi.Items.Add(logText);
                WriteLogToFile(logText);
                txtketQua.Text = "";
                return;
            }

            // 5. Access Denied
            logText = $"{time}   Access denied";
            lstHienThi.Items.Add(logText);
            WriteLogToFile(logText);
            txtketQua.Text = "";
        }
        private void SecurityPanel_KeyDown(object sender, KeyEventArgs e)
        {
            // Nhấn số hàng trên bàn phím (0-9)
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                txtketQua.Text += (e.KeyCode - Keys.D0).ToString();
            }

            // Nhấn số trên NumPad
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                txtketQua.Text += (e.KeyCode - Keys.NumPad0).ToString();
            }

            // Enter = nút #
            if (e.KeyCode == Keys.Enter)
            {
                bttThang_Click(sender, e);
            }

            // Backspace = Clear
            if (e.KeyCode == Keys.C)
            {
                txtketQua.Text = "";
                bttThang.Focus();
            }
        }
    }
}
