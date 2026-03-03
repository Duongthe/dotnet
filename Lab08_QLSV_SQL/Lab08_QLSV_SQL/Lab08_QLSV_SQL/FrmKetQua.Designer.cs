namespace Lab08_QLSV_SQL
{
    partial class FrmKetQua
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
            btnXoa = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            label2 = new Label();
            label1 = new Label();
            dgvKetQua = new DataGridView();
            txtDiem = new TextBox();
            label4 = new Label();
            cbSinhVien = new ComboBox();
            cbMonHoc = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).BeginInit();
            SuspendLayout();
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(607, 113);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 37;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(607, 67);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 36;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(607, 21);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 35;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 75);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 30;
            label2.Text = "Môn học :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 30);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 29;
            label1.Text = "Sinh Viên :";
            // 
            // dgvKetQua
            // 
            dgvKetQua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQua.Location = new Point(3, 162);
            dgvKetQua.Name = "dgvKetQua";
            dgvKetQua.RowHeadersWidth = 51;
            dgvKetQua.Size = new Size(785, 257);
            dgvKetQua.TabIndex = 38;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(216, 115);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(308, 27);
            txtDiem.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 118);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 39;
            label4.Text = "Điểm:";
            // 
            // cbSinhVien
            // 
            cbSinhVien.FormattingEnabled = true;
            cbSinhVien.Location = new Point(216, 21);
            cbSinhVien.Name = "cbSinhVien";
            cbSinhVien.Size = new Size(308, 28);
            cbSinhVien.TabIndex = 43;
            // 
            // cbMonHoc
            // 
            cbMonHoc.FormattingEnabled = true;
            cbMonHoc.Location = new Point(216, 68);
            cbMonHoc.Name = "cbMonHoc";
            cbMonHoc.Size = new Size(308, 28);
            cbMonHoc.TabIndex = 44;
            // 
            // FrmKetQua
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbMonHoc);
            Controls.Add(cbSinhVien);
            Controls.Add(txtDiem);
            Controls.Add(label4);
            Controls.Add(dgvKetQua);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThem);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmKetQua";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NHẬP ĐIỂM";
            Load += FrmKetQua_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKetQua).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnXoa;
        private Button btnCapNhat;
        private Button btnThem;
        private Label label2;
        private Label label1;
        private DataGridView dgvKetQua;
        private TextBox txtDiem;
        private Label label4;
        private ComboBox cbSinhVien;
        private ComboBox cbMonHoc;
    }
}