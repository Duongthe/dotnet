namespace Lab08_QLSV_SQL
{
    partial class FrmMonHoc
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
            txtTenMonHoc = new TextBox();
            txtMaMonHoc = new TextBox();
            txtSoTiet = new TextBox();
            label3 = new Label();
            dgvMonHoc = new DataGridView();
            btnXoa = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMonHoc).BeginInit();
            SuspendLayout();
            // 
            // txtTenMonHoc
            // 
            txtTenMonHoc.Location = new Point(241, 77);
            txtTenMonHoc.Name = "txtTenMonHoc";
            txtTenMonHoc.Size = new Size(257, 27);
            txtTenMonHoc.TabIndex = 7;
            // 
            // txtMaMonHoc
            // 
            txtMaMonHoc.Location = new Point(241, 31);
            txtMaMonHoc.Name = "txtMaMonHoc";
            txtMaMonHoc.Size = new Size(257, 27);
            txtMaMonHoc.TabIndex = 6;
            // 
            // txtSoTiet
            // 
            txtSoTiet.Location = new Point(241, 123);
            txtSoTiet.Name = "txtSoTiet";
            txtSoTiet.Size = new Size(257, 27);
            txtSoTiet.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(129, 130);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 8;
            label3.Text = "Số Tiết";
            // 
            // dgvMonHoc
            // 
            dgvMonHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonHoc.Location = new Point(3, 181);
            dgvMonHoc.Name = "dgvMonHoc";
            dgvMonHoc.RowHeadersWidth = 51;
            dgvMonHoc.Size = new Size(785, 257);
            dgvMonHoc.TabIndex = 10;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(580, 128);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 28;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(580, 79);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 27;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(580, 30);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 26;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(129, 84);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 29;
            label1.Text = "Tên MH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(129, 38);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 30;
            label2.Text = "Mã MH";
            // 
            // FrmMonHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThem);
            Controls.Add(dgvMonHoc);
            Controls.Add(txtSoTiet);
            Controls.Add(label3);
            Controls.Add(txtTenMonHoc);
            Controls.Add(txtMaMonHoc);
            Name = "FrmMonHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DANH MỤC MÔN HỌC";
            Load += FrmMonHoc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMonHoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenMonHoc;
        private TextBox txtMaMonHoc;
        private TextBox txtSoTiet;
        private Label label3;
        private DataGridView dgvMonHoc;
        private Button btnXoa;
        private Button btnCapNhat;
        private Button btnThem;
        private Label label1;
        private Label label2;
    }
}