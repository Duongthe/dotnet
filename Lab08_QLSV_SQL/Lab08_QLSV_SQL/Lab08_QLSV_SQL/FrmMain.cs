using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08_QLSV_SQL
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void OpenChildForm(Form child)
        {
            // Đóng tất cả các form con đang mở
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }

            // Mở form mới
            child.MdiParent = this;
            child.Show();
        }


        private void mnuSV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSinhVien());
        }

        private void mnuKhoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmKhoa());
        }

        private void mnuMH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmMonHoc());
        }

        private void mnuKetQua_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmKetQua());
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnSV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSinhVien());
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmKhoa());
        }

        private void btnMH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmMonHoc());
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmKetQua());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
