namespace lab_05_SDList_QLTinhTien
{
    partial class Form1
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
            this.ltbDanhSach = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttLuuVaoDanhSach = new System.Windows.Forms.Button();
            this.bttThoat = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTramRang = new System.Windows.Forms.NumericUpDown();
            this.lblTramRang = new System.Windows.Forms.Label();
            this.ckbChupHinh = new System.Windows.Forms.CheckBox();
            this.ckbTayRang = new System.Windows.Forms.CheckBox();
            this.ckbCaoVoi = new System.Windows.Forms.CheckBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttLuuFile = new System.Windows.Forms.Button();
            this.bttTaiFile = new System.Windows.Forms.Button();
            this.bttTinhTien = new System.Windows.Forms.Button();
            this.bttXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTramRang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltbDanhSach
            // 
            this.ltbDanhSach.FormattingEnabled = true;
            this.ltbDanhSach.ItemHeight = 16;
            this.ltbDanhSach.Location = new System.Drawing.Point(6, 21);
            this.ltbDanhSach.Name = "ltbDanhSach";
            this.ltbDanhSach.Size = new System.Drawing.Size(288, 276);
            this.ltbDanhSach.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttTinhTien);
            this.groupBox1.Controls.Add(this.bttLuuVaoDanhSach);
            this.groupBox1.Controls.Add(this.bttThoat);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudTramRang);
            this.groupBox1.Controls.Add(this.lblTramRang);
            this.groupBox1.Controls.Add(this.ckbChupHinh);
            this.groupBox1.Controls.Add(this.ckbTayRang);
            this.groupBox1.Controls.Add(this.ckbCaoVoi);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 379);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // bttLuuVaoDanhSach
            // 
            this.bttLuuVaoDanhSach.Location = new System.Drawing.Point(202, 304);
            this.bttLuuVaoDanhSach.Name = "bttLuuVaoDanhSach";
            this.bttLuuVaoDanhSach.Size = new System.Drawing.Size(75, 23);
            this.bttLuuVaoDanhSach.TabIndex = 12;
            this.bttLuuVaoDanhSach.Text = "Lưu Vào";
            this.bttLuuVaoDanhSach.UseVisualStyleBackColor = true;
            this.bttLuuVaoDanhSach.Click += new System.EventHandler(this.bttLuuVaoDanhSach_Click);
            // 
            // bttThoat
            // 
            this.bttThoat.Location = new System.Drawing.Point(102, 335);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(75, 23);
            this.bttThoat.TabIndex = 1;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(153, 221);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(172, 22);
            this.txtTongTien.TabIndex = 11;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tổng tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "500.000đ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "200.000đ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "300.000đ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "100.000đ";
            // 
            // nudTramRang
            // 
            this.nudTramRang.Location = new System.Drawing.Point(86, 164);
            this.nudTramRang.Name = "nudTramRang";
            this.nudTramRang.Size = new System.Drawing.Size(76, 22);
            this.nudTramRang.TabIndex = 6;
            this.nudTramRang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTramRang
            // 
            this.lblTramRang.AutoSize = true;
            this.lblTramRang.Location = new System.Drawing.Point(11, 168);
            this.lblTramRang.Name = "lblTramRang";
            this.lblTramRang.Size = new System.Drawing.Size(69, 16);
            this.lblTramRang.TabIndex = 5;
            this.lblTramRang.Text = "Trám răng";
            // 
            // ckbChupHinh
            // 
            this.ckbChupHinh.AutoSize = true;
            this.ckbChupHinh.Location = new System.Drawing.Point(14, 134);
            this.ckbChupHinh.Name = "ckbChupHinh";
            this.ckbChupHinh.Size = new System.Drawing.Size(117, 20);
            this.ckbChupHinh.TabIndex = 4;
            this.ckbChupHinh.Text = "Chụp hình răng";
            this.ckbChupHinh.UseVisualStyleBackColor = true;
            // 
            // ckbTayRang
            // 
            this.ckbTayRang.AutoSize = true;
            this.ckbTayRang.Location = new System.Drawing.Point(14, 105);
            this.ckbTayRang.Name = "ckbTayRang";
            this.ckbTayRang.Size = new System.Drawing.Size(83, 20);
            this.ckbTayRang.TabIndex = 3;
            this.ckbTayRang.Text = "Tẩy răng";
            this.ckbTayRang.UseVisualStyleBackColor = true;
            // 
            // ckbCaoVoi
            // 
            this.ckbCaoVoi.AutoSize = true;
            this.ckbCaoVoi.Location = new System.Drawing.Point(14, 76);
            this.ckbCaoVoi.Name = "ckbCaoVoi";
            this.ckbCaoVoi.Size = new System.Drawing.Size(75, 20);
            this.ckbCaoVoi.TabIndex = 2;
            this.ckbCaoVoi.Text = "Cạo vôi";
            this.ckbCaoVoi.UseVisualStyleBackColor = true;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(116, 32);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(209, 22);
            this.txtTen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttXoa);
            this.groupBox2.Controls.Add(this.bttTaiFile);
            this.groupBox2.Controls.Add(this.bttLuuFile);
            this.groupBox2.Controls.Add(this.ltbDanhSach);
            this.groupBox2.Location = new System.Drawing.Point(348, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 379);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đã thanh toán";
            // 
            // bttLuuFile
            // 
            this.bttLuuFile.Location = new System.Drawing.Point(59, 304);
            this.bttLuuFile.Name = "bttLuuFile";
            this.bttLuuFile.Size = new System.Drawing.Size(75, 23);
            this.bttLuuFile.TabIndex = 1;
            this.bttLuuFile.Text = "Lưu FIle";
            this.bttLuuFile.UseVisualStyleBackColor = true;
            this.bttLuuFile.Click += new System.EventHandler(this.bttLuuFile_Click);
            // 
            // bttTaiFile
            // 
            this.bttTaiFile.Location = new System.Drawing.Point(176, 304);
            this.bttTaiFile.Name = "bttTaiFile";
            this.bttTaiFile.Size = new System.Drawing.Size(75, 23);
            this.bttTaiFile.TabIndex = 2;
            this.bttTaiFile.Text = "Tải File";
            this.bttTaiFile.UseVisualStyleBackColor = true;
            this.bttTaiFile.Click += new System.EventHandler(this.bttTaiFile_Click);
            // 
            // bttTinhTien
            // 
            this.bttTinhTien.Location = new System.Drawing.Point(22, 304);
            this.bttTinhTien.Name = "bttTinhTien";
            this.bttTinhTien.Size = new System.Drawing.Size(75, 23);
            this.bttTinhTien.TabIndex = 13;
            this.bttTinhTien.Text = "Tính";
            this.bttTinhTien.UseVisualStyleBackColor = true;
            this.bttTinhTien.Click += new System.EventHandler(this.bttTinhTien_Click);
            // 
            // bttXoa
            // 
            this.bttXoa.Location = new System.Drawing.Point(104, 335);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(104, 23);
            this.bttXoa.TabIndex = 3;
            this.bttXoa.Text = "Xóa Khách";
            this.bttXoa.UseVisualStyleBackColor = true;
            this.bttXoa.Click += new System.EventHandler(this.bttXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 398);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTramRang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ltbDanhSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbChupHinh;
        private System.Windows.Forms.CheckBox ckbTayRang;
        private System.Windows.Forms.CheckBox ckbCaoVoi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTramRang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTramRang;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttLuuVaoDanhSach;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.Button bttLuuFile;
        private System.Windows.Forms.Button bttTaiFile;
        private System.Windows.Forms.Button bttTinhTien;
        private System.Windows.Forms.Button bttXoa;
    }
}

