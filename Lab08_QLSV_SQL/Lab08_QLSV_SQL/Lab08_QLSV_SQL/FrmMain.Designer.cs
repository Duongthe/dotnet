namespace Lab08_QLSV_SQL
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            mnuSV = new ToolStripMenuItem();
            mnuKhoa = new ToolStripMenuItem();
            mnuMH = new ToolStripMenuItem();
            mnuKetQua = new ToolStripMenuItem();
            hỗTrợToolStripMenuItem = new ToolStripMenuItem();
            giớiThiệuToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnSV = new ToolStripButton();
            btnKhoa = new ToolStripButton();
            btnMH = new ToolStripButton();
            btnKetQua = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcNăngToolStripMenuItem, hỗTrợToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuSV, mnuKhoa, mnuMH, mnuKetQua });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(96, 24);
            chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // mnuSV
            // 
            mnuSV.Name = "mnuSV";
            mnuSV.Size = new Size(224, 26);
            mnuSV.Text = "Sinh Viên";
            mnuSV.Click += mnuSV_Click;
            // 
            // mnuKhoa
            // 
            mnuKhoa.Name = "mnuKhoa";
            mnuKhoa.Size = new Size(224, 26);
            mnuKhoa.Text = "Khoa";
            mnuKhoa.Click += mnuKhoa_Click;
            // 
            // mnuMH
            // 
            mnuMH.Name = "mnuMH";
            mnuMH.Size = new Size(224, 26);
            mnuMH.Text = "Môn Học";
            mnuMH.Click += mnuMH_Click;
            // 
            // mnuKetQua
            // 
            mnuKetQua.Name = "mnuKetQua";
            mnuKetQua.Size = new Size(224, 26);
            mnuKetQua.Text = "Xem và Nhập Điểm";
            mnuKetQua.Click += mnuKetQua_Click;
            // 
            // hỗTrợToolStripMenuItem
            // 
            hỗTrợToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { giớiThiệuToolStripMenuItem });
            hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            hỗTrợToolStripMenuItem.Size = new Size(68, 24);
            hỗTrợToolStripMenuItem.Text = "Hỗ Trợ";
            // 
            // giớiThiệuToolStripMenuItem
            // 
            giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            giớiThiệuToolStripMenuItem.Size = new Size(156, 26);
            giớiThiệuToolStripMenuItem.Text = "Giới thiệu";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnSV, btnKhoa, btnMH, btnKetQua, toolStripButton1 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnSV
            // 
            btnSV.Image = Properties.Resources.group;
            btnSV.ImageTransparentColor = Color.Magenta;
            btnSV.Name = "btnSV";
            btnSV.Size = new Size(94, 24);
            btnSV.Text = "Sinh Viên";
            btnSV.Click += btnSV_Click;
            // 
            // btnKhoa
            // 
            btnKhoa.Image = Properties.Resources._3d_select_edge_icon;
            btnKhoa.ImageTransparentColor = Color.Magenta;
            btnKhoa.Name = "btnKhoa";
            btnKhoa.Size = new Size(67, 24);
            btnKhoa.Text = "Khoa";
            btnKhoa.Click += btnKhoa_Click;
            // 
            // btnMH
            // 
            btnMH.Image = Properties.Resources.pngtree_an_icon_of_an_open_book_with_colors_vector_png_image_6923530;
            btnMH.ImageTransparentColor = Color.Magenta;
            btnMH.Name = "btnMH";
            btnMH.Size = new Size(94, 24);
            btnMH.Text = "Môn Học";
            btnMH.Click += btnMH_Click;
            // 
            // btnKetQua
            // 
            btnKetQua.Image = Properties.Resources.pngtree_experiment_result_line_icon_png_image_9064954;
            btnKetQua.ImageTransparentColor = Color.Magenta;
            btnKetQua.Name = "btnKetQua";
            btnKetQua.Size = new Size(162, 24);
            btnKetQua.Text = "Xem và Nhập Điểm";
            btnKetQua.Click += btnKetQua_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.Button_Close_icon;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(71, 24);
            toolStripButton1.Text = "Thoát";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sinh Viên";
            WindowState = FormWindowState.Maximized;
            Load += FrmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem mnuSV;
        private ToolStripMenuItem mnuKhoa;
        private ToolStripMenuItem mnuMH;
        private ToolStripMenuItem mnuKetQua;
        private ToolStripMenuItem hỗTrợToolStripMenuItem;
        private ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btnSV;
        private ToolStripButton btnKhoa;
        private ToolStripButton btnMH;
        private ToolStripButton btnKetQua;
        private ToolStripButton toolStripButton1;
    }
}