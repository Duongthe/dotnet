namespace Lab08_QLSV_SQL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgv1 = new DataGridView();
            label1 = new Label();
            txtMaSV = new TextBox();
            txtDiaChi = new TextBox();
            label2 = new Label();
            txtHoTen = new TextBox();
            lblHoTen = new Label();
            txtSoDienThoai = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtpNgaySinh = new DateTimePicker();
            groupBox1 = new GroupBox();
            rdbNu = new RadioButton();
            rdbNam = new RadioButton();
            cboMaKhoa = new ComboBox();
            bttThem = new Button();
            bttXoa = new Button();
            bttLuu = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgv1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgv1
            // 
            dtgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv1.Location = new Point(12, 206);
            dtgv1.Name = "dtgv1";
            dtgv1.RowHeadersWidth = 51;
            dtgv1.Size = new Size(817, 306);
            dtgv1.TabIndex = 0;
            dtgv1.CellContentClick += dtgv1_CellContentClick;
            dtgv1.CellFormatting += dtgv1_CellFormatting;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã Số SV";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(96, 6);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(267, 27);
            txtMaSV.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(550, 9);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(279, 27);
            txtDiaChi.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(466, 12);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 3;
            label2.Text = "Địa Chỉ";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(96, 56);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(267, 27);
            txtHoTen.TabIndex = 6;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(12, 59);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(56, 20);
            lblHoTen.TabIndex = 5;
            lblHoTen.Text = "Họ Tên";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(569, 59);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(260, 27);
            txtSoDienThoai.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(466, 62);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 7;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 102);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 9;
            label5.Text = "Ngày Sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(466, 108);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 11;
            label6.Text = "Mã khoa";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(96, 100);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(267, 27);
            dtpNgaySinh.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbNu);
            groupBox1.Controls.Add(rdbNam);
            groupBox1.Location = new Point(12, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(193, 67);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giới Tính";
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Location = new Point(111, 26);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(50, 24);
            rdbNu.TabIndex = 18;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Location = new Point(6, 26);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(62, 24);
            rdbNam.TabIndex = 17;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            rdbNam.CheckedChanged += rdbNam_CheckedChanged;
            // 
            // cboMaKhoa
            // 
            cboMaKhoa.FormattingEnabled = true;
            cboMaKhoa.Location = new Point(550, 100);
            cboMaKhoa.Name = "cboMaKhoa";
            cboMaKhoa.Size = new Size(279, 28);
            cboMaKhoa.TabIndex = 17;
            cboMaKhoa.SelectedIndexChanged += cboMaKhoa_SelectedIndexChanged;
            // 
            // bttThem
            // 
            bttThem.Location = new Point(468, 154);
            bttThem.Name = "bttThem";
            bttThem.Size = new Size(94, 29);
            bttThem.TabIndex = 18;
            bttThem.Text = "Thêm";
            bttThem.UseVisualStyleBackColor = true;
            bttThem.Click += bttThem_Click;
            // 
            // bttXoa
            // 
            bttXoa.Location = new Point(601, 154);
            bttXoa.Name = "bttXoa";
            bttXoa.Size = new Size(94, 29);
            bttXoa.TabIndex = 19;
            bttXoa.Text = "Xóa";
            bttXoa.UseVisualStyleBackColor = true;
            bttXoa.Click += bttXoa_Click;
            // 
            // bttLuu
            // 
            bttLuu.Location = new Point(729, 154);
            bttLuu.Name = "bttLuu";
            bttLuu.Size = new Size(94, 29);
            bttLuu.TabIndex = 20;
            bttLuu.Text = "Lưu";
            bttLuu.UseVisualStyleBackColor = true;
            bttLuu.Click += bttLuu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 521);
            Controls.Add(bttLuu);
            Controls.Add(bttXoa);
            Controls.Add(bttThem);
            Controls.Add(cboMaKhoa);
            Controls.Add(groupBox1);
            Controls.Add(dtpNgaySinh);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtSoDienThoai);
            Controls.Add(label4);
            Controls.Add(txtHoTen);
            Controls.Add(lblHoTen);
            Controls.Add(txtDiaChi);
            Controls.Add(label2);
            Controls.Add(txtMaSV);
            Controls.Add(label1);
            Controls.Add(dtgv1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgv1;
        private Label label1;
        private TextBox txtMaSV;
        private TextBox txtDiaChi;
        private Label label2;
        private TextBox txtHoTen;
        private Label lblHoTen;
        private TextBox txtSoDienThoai;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpNgaySinh;
        private GroupBox groupBox1;
        private RadioButton rdbNu;
        private RadioButton rdbNam;
        private ComboBox cboMaKhoa;
        private Button bttThem;
        private Button bttXoa;
        private Button bttLuu;
    }
}
