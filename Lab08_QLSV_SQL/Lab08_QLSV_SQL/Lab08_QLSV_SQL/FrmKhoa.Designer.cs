namespace Lab08_QLSV_SQL
{
    partial class FrmKhoa
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
            txtMaKhoa = new TextBox();
            txtTenKhoa = new TextBox();
            dgvKhoa = new DataGridView();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 41);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Khoa :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 115);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên Khoa :";
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Location = new Point(110, 34);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(257, 27);
            txtMaKhoa.TabIndex = 2;
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Location = new Point(110, 108);
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new Size(257, 27);
            txtTenKhoa.TabIndex = 3;
            // 
            // dgvKhoa
            // 
            dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoa.Location = new Point(12, 178);
            dgvKhoa.Name = "dgvKhoa";
            dgvKhoa.RowHeadersWidth = 51;
            dgvKhoa.Size = new Size(480, 250);
            dgvKhoa.TabIndex = 4;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(398, 30);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 28;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(398, 73);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 27;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(398, 119);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 26;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // FrmKhoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 440);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvKhoa);
            Controls.Add(txtTenKhoa);
            Controls.Add(txtMaKhoa);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmKhoa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DANH MỤC KHOA";
            Load += FrmKhoa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMaKhoa;
        private TextBox txtTenKhoa;
        private DataGridView dgvKhoa;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}