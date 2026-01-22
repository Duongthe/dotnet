namespace lab_05_SDList_QLTinhTien
{
    partial class frmThaotacso
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstHienThi = new System.Windows.Forms.ListBox();
            this.bttTang = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttXoaCuoi = new System.Windows.Forms.Button();
            this.bttXoaDau = new System.Windows.Forms.Button();
            this.bttXoaPhanTu = new System.Windows.Forms.Button();
            this.bttChonLe = new System.Windows.Forms.Button();
            this.bttChonChan = new System.Windows.Forms.Button();
            this.bttCapNhat = new System.Windows.Forms.Button();
            this.bttKetThuc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số nguyên: ";
            // 
            // lstHienThi
            // 
            this.lstHienThi.FormattingEnabled = true;
            this.lstHienThi.ItemHeight = 16;
            this.lstHienThi.Location = new System.Drawing.Point(12, 66);
            this.lstHienThi.Name = "lstHienThi";
            this.lstHienThi.Size = new System.Drawing.Size(221, 260);
            this.lstHienThi.TabIndex = 1;
            // 
            // bttTang
            // 
            this.bttTang.Location = new System.Drawing.Point(31, 21);
            this.bttTang.Name = "bttTang";
            this.bttTang.Size = new System.Drawing.Size(152, 29);
            this.bttTang.TabIndex = 2;
            this.bttTang.Text = "Tăng mỗi phần tử lên 2";
            this.bttTang.UseVisualStyleBackColor = true;
            this.bttTang.Click += new System.EventHandler(this.bttTang_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(148, 14);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(216, 22);
            this.txtNhap.TabIndex = 3;
            this.txtNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNhap_KeyDown);
            this.txtNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhap_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttXoaCuoi);
            this.groupBox1.Controls.Add(this.bttXoaDau);
            this.groupBox1.Controls.Add(this.bttXoaPhanTu);
            this.groupBox1.Controls.Add(this.bttChonLe);
            this.groupBox1.Controls.Add(this.bttChonChan);
            this.groupBox1.Controls.Add(this.bttTang);
            this.groupBox1.Location = new System.Drawing.Point(255, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 260);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // bttXoaCuoi
            // 
            this.bttXoaCuoi.Location = new System.Drawing.Point(31, 211);
            this.bttXoaCuoi.Name = "bttXoaCuoi";
            this.bttXoaCuoi.Size = new System.Drawing.Size(152, 29);
            this.bttXoaCuoi.TabIndex = 7;
            this.bttXoaCuoi.Text = "Xóa phần tử cuối";
            this.bttXoaCuoi.UseVisualStyleBackColor = true;
            this.bttXoaCuoi.Click += new System.EventHandler(this.bttXoaCuoi_Click);
            // 
            // bttXoaDau
            // 
            this.bttXoaDau.Location = new System.Drawing.Point(31, 173);
            this.bttXoaDau.Name = "bttXoaDau";
            this.bttXoaDau.Size = new System.Drawing.Size(152, 29);
            this.bttXoaDau.TabIndex = 6;
            this.bttXoaDau.Text = "Xóa phần tử đầu";
            this.bttXoaDau.UseVisualStyleBackColor = true;
            this.bttXoaDau.Click += new System.EventHandler(this.bttXoaDau_Click);
            // 
            // bttXoaPhanTu
            // 
            this.bttXoaPhanTu.Location = new System.Drawing.Point(31, 135);
            this.bttXoaPhanTu.Name = "bttXoaPhanTu";
            this.bttXoaPhanTu.Size = new System.Drawing.Size(152, 29);
            this.bttXoaPhanTu.TabIndex = 5;
            this.bttXoaPhanTu.Text = "Xóa phần tử đang chọn";
            this.bttXoaPhanTu.UseVisualStyleBackColor = true;
            this.bttXoaPhanTu.Click += new System.EventHandler(this.bttXoaPhanTu_Click);
            // 
            // bttChonLe
            // 
            this.bttChonLe.Location = new System.Drawing.Point(31, 97);
            this.bttChonLe.Name = "bttChonLe";
            this.bttChonLe.Size = new System.Drawing.Size(152, 29);
            this.bttChonLe.TabIndex = 4;
            this.bttChonLe.Text = "Chọn số lẻ cuối";
            this.bttChonLe.UseVisualStyleBackColor = true;
            this.bttChonLe.Click += new System.EventHandler(this.bttChonLe_Click);
            // 
            // bttChonChan
            // 
            this.bttChonChan.Location = new System.Drawing.Point(31, 59);
            this.bttChonChan.Name = "bttChonChan";
            this.bttChonChan.Size = new System.Drawing.Size(152, 29);
            this.bttChonChan.TabIndex = 3;
            this.bttChonChan.Text = "Chọn số chẳng đầu";
            this.bttChonChan.UseVisualStyleBackColor = true;
            this.bttChonChan.Click += new System.EventHandler(this.bttChonChan_Click);
            // 
            // bttCapNhat
            // 
            this.bttCapNhat.Location = new System.Drawing.Point(379, 14);
            this.bttCapNhat.Name = "bttCapNhat";
            this.bttCapNhat.Size = new System.Drawing.Size(90, 31);
            this.bttCapNhat.TabIndex = 3;
            this.bttCapNhat.Text = "Cập nhật";
            this.bttCapNhat.UseVisualStyleBackColor = true;
            this.bttCapNhat.Click += new System.EventHandler(this.bttCapNhat_Click);
            // 
            // bttKetThuc
            // 
            this.bttKetThuc.Location = new System.Drawing.Point(12, 335);
            this.bttKetThuc.Name = "bttKetThuc";
            this.bttKetThuc.Size = new System.Drawing.Size(457, 29);
            this.bttKetThuc.TabIndex = 8;
            this.bttKetThuc.Text = "Kết thúc";
            this.bttKetThuc.UseVisualStyleBackColor = true;
            this.bttKetThuc.Click += new System.EventHandler(this.bttKetThuc_Click);
            // 
            // frmThaotacso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 380);
            this.Controls.Add(this.bttKetThuc);
            this.Controls.Add(this.bttCapNhat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.lstHienThi);
            this.Controls.Add(this.label1);
            this.Name = "frmThaotacso";
            this.Text = "frmThaotacso";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstHienThi;
        private System.Windows.Forms.Button bttTang;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttChonChan;
        private System.Windows.Forms.Button bttCapNhat;
        private System.Windows.Forms.Button bttXoaCuoi;
        private System.Windows.Forms.Button bttXoaDau;
        private System.Windows.Forms.Button bttXoaPhanTu;
        private System.Windows.Forms.Button bttChonLe;
        private System.Windows.Forms.Button bttKetThuc;
    }
}