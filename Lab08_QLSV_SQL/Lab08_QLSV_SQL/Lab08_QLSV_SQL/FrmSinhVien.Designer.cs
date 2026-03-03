namespace Lab08_QLSV_SQL
{
    partial class FrmSinhVien
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
            label1 = new Label();
            label2 = new Label();
            txtMSSV = new TextBox();
            txtHoTen = new TextBox();
            label4 = new Label();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtpNgaySinh = new DateTimePicker();
            gbGioiTinh = new GroupBox();
            rdNu = new RadioButton();
            rdNam = new RadioButton();
            cbKhoa = new ComboBox();
            btnThem = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            dgvSinhVien = new DataGridView();
            gbGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 21);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 1;
            label1.Text = "MSSV :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 61);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = "Họ và tên :";
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(101, 14);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(219, 27);
            txtMSSV.TabIndex = 8;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(101, 54);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(219, 27);
            txtHoTen.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 101);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 10;
            label4.Text = "Ngày Sinh :";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(501, 94);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(207, 27);
            txtSDT.TabIndex = 17;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(101, 139);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(219, 27);
            txtDiaChi.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(422, 101);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 15;
            label5.Text = "SĐT :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 142);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 14;
            label6.Text = "Địa Chỉ :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(422, 142);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 18;
            label7.Text = "Mã Khoa :";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(101, 96);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(219, 27);
            dtpNgaySinh.TabIndex = 20;
            // 
            // gbGioiTinh
            // 
            gbGioiTinh.Controls.Add(rdNu);
            gbGioiTinh.Controls.Add(rdNam);
            gbGioiTinh.Location = new Point(422, 14);
            gbGioiTinh.Name = "gbGioiTinh";
            gbGioiTinh.Size = new Size(286, 67);
            gbGioiTinh.TabIndex = 21;
            gbGioiTinh.TabStop = false;
            gbGioiTinh.Text = "GioiTinh";
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(170, 26);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(50, 24);
            rdNu.TabIndex = 1;
            rdNu.TabStop = true;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            rdNu.CheckedChanged += rdNu_CheckedChanged;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Location = new Point(79, 26);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(62, 24);
            rdNam.TabIndex = 0;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            rdNam.CheckedChanged += rdNam_CheckedChanged;
            // 
            // cbKhoa
            // 
            cbKhoa.FormattingEnabled = true;
            cbKhoa.Location = new Point(501, 138);
            cbKhoa.Name = "cbKhoa";
            cbKhoa.Size = new Size(207, 28);
            cbKhoa.TabIndex = 22;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(768, 40);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 23;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(768, 92);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 24;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(768, 138);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 25;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(12, 181);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.Size = new Size(850, 257);
            dgvSinhVien.TabIndex = 0;
            // 
            // FrmSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 450);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThem);
            Controls.Add(cbKhoa);
            Controls.Add(gbGioiTinh);
            Controls.Add(dtpNgaySinh);
            Controls.Add(label7);
            Controls.Add(txtSDT);
            Controls.Add(txtDiaChi);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtHoTen);
            Controls.Add(txtMSSV);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvSinhVien);
            Name = "FrmSinhVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "THÔNG TIN SINH VIÊN";
            Load += FrmSinhVien_Load;
            gbGioiTinh.ResumeLayout(false);
            gbGioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox txtMSSV;
        private TextBox txtHoTen;
        private Label label4;
        private TextBox txtSDT;
        private TextBox txtDiaChi;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpNgaySinh;
        private GroupBox gbGioiTinh;
        private RadioButton rdNu;
        private RadioButton rdNam;
        private ComboBox cbKhoa;
        private Button btnThem;
        private Button btnCapNhat;
        private Button btnXoa;
        private DataGridView dgvSinhVien;
    }
}