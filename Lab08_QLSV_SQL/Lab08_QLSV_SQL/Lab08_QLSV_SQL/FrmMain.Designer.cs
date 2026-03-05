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
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            giớiThiệuToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            mnuSV = new ToolStripMenuItem();
            mnuKhoa = new ToolStripMenuItem();
            mnuMH = new ToolStripMenuItem();
            mnuKetQua = new ToolStripMenuItem();
            thốngKêKhoaToolStripMenuItem = new ToolStripMenuItem();
            hỗTrợToolStripMenuItem = new ToolStripMenuItem();
            noteToolStripMenuItem = new ToolStripMenuItem();
            hướngDẫnSửDụngToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnSV = new ToolStripButton();
            btnKhoa = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, chứcNăngToolStripMenuItem, hỗTrợToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(664, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { giớiThiệuToolStripMenuItem, homeToolStripMenuItem });
            hệThốngToolStripMenuItem.Image = Properties.Resources.images__1_;
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(108, 24);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // giớiThiệuToolStripMenuItem
            // 
            giớiThiệuToolStripMenuItem.Image = Properties.Resources.istockphoto_1257415193_612x612;
            giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            giớiThiệuToolStripMenuItem.Size = new Size(224, 26);
            giớiThiệuToolStripMenuItem.Text = "Giới thiệu";
            giớiThiệuToolStripMenuItem.Click += giớiThiệuToolStripMenuItem_Click;
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Image = Properties.Resources.images__2_;
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(224, 26);
            homeToolStripMenuItem.Text = "Home";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuSV, mnuKhoa, mnuMH, mnuKetQua, thốngKêKhoaToolStripMenuItem });
            chứcNăngToolStripMenuItem.Image = Properties.Resources.clarifying_icon_1;
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(116, 24);
            chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // mnuSV
            // 
            mnuSV.Name = "mnuSV";
            mnuSV.Size = new Size(221, 26);
            mnuSV.Text = "Sinh Viên";
            mnuSV.Click += mnuSV_Click;
            // 
            // mnuKhoa
            // 
            mnuKhoa.Name = "mnuKhoa";
            mnuKhoa.Size = new Size(221, 26);
            mnuKhoa.Text = "Khoa";
            mnuKhoa.Click += mnuKhoa_Click;
            // 
            // mnuMH
            // 
            mnuMH.Name = "mnuMH";
            mnuMH.Size = new Size(221, 26);
            mnuMH.Text = "Môn Học";
            mnuMH.Click += mnuMH_Click;
            // 
            // mnuKetQua
            // 
            mnuKetQua.Name = "mnuKetQua";
            mnuKetQua.Size = new Size(221, 26);
            mnuKetQua.Text = "Xem và Nhập Điểm";
            mnuKetQua.Click += mnuKetQua_Click;
            // 
            // thốngKêKhoaToolStripMenuItem
            // 
            thốngKêKhoaToolStripMenuItem.Name = "thốngKêKhoaToolStripMenuItem";
            thốngKêKhoaToolStripMenuItem.Size = new Size(221, 26);
            thốngKêKhoaToolStripMenuItem.Text = "Thống Kê Khoa";
            // 
            // hỗTrợToolStripMenuItem
            // 
            hỗTrợToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { noteToolStripMenuItem, hướngDẫnSửDụngToolStripMenuItem });
            hỗTrợToolStripMenuItem.Image = Properties.Resources.istockphoto_1144489611_612x612;
            hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            hỗTrợToolStripMenuItem.Size = new Size(88, 24);
            hỗTrợToolStripMenuItem.Text = "Hỗ Trợ";
            // 
            // noteToolStripMenuItem
            // 
            noteToolStripMenuItem.Image = Properties.Resources.images;
            noteToolStripMenuItem.Name = "noteToolStripMenuItem";
            noteToolStripMenuItem.Size = new Size(224, 26);
            noteToolStripMenuItem.Text = "Note";
            noteToolStripMenuItem.Click += noteToolStripMenuItem_Click;
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            hướngDẫnSửDụngToolStripMenuItem.Image = Properties.Resources.pngtree_instruction_flat_icon_png_image_9137979;
            hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            hướngDẫnSửDụngToolStripMenuItem.Size = new Size(224, 26);
            hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            hướngDẫnSửDụngToolStripMenuItem.Click += hướngDẫnSửDụngToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnSV, btnKhoa, toolStripButton2, btnMH, btnKetQua, toolStripButton1 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(664, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
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
            // toolStripButton2
            // 
            toolStripButton2.Image = Properties.Resources.Button_Add_icon;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(134, 24);
            toolStripButton2.Text = "Thống Kê Khoa";
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
            ClientSize = new Size(664, 450);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sinh Viên";
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
        private ToolStrip toolStrip1;
        private ToolStripButton btnSV;
        private ToolStripButton btnKhoa;
        private ToolStripButton btnMH;
        private ToolStripButton btnKetQua;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripMenuItem thốngKêKhoaToolStripMenuItem;
        private ToolStripMenuItem noteToolStripMenuItem;
        private ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
    }
}