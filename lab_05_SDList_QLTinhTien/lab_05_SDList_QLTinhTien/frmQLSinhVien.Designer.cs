namespace lab_05_SDList_QLTinhTien
{
    partial class frmQLSinhVien
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
            this.label2 = new System.Windows.Forms.Label();
            this.bttCapNhat = new System.Windows.Forms.Button();
            this.lstA = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstB = new System.Windows.Forms.ListBox();
            this.bttXoa = new System.Windows.Forms.Button();
            this.bttKetThuc = new System.Windows.Forms.Button();
            this.bttQua = new System.Windows.Forms.Button();
            this.bttLai = new System.Windows.Forms.Button();
            this.bttLaiHet = new System.Windows.Forms.Button();
            this.bttQuaHet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SACH SINH VIEN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên: ";
            // 
            // bttCapNhat
            // 
            this.bttCapNhat.Location = new System.Drawing.Point(451, 85);
            this.bttCapNhat.Name = "bttCapNhat";
            this.bttCapNhat.Size = new System.Drawing.Size(87, 23);
            this.bttCapNhat.TabIndex = 2;
            this.bttCapNhat.Text = "Cập Nhật";
            this.bttCapNhat.UseVisualStyleBackColor = true;
            this.bttCapNhat.Click += new System.EventHandler(this.bttCapNhat_Click);
            // 
            // lstA
            // 
            this.lstA.FormattingEnabled = true;
            this.lstA.ItemHeight = 16;
            this.lstA.Location = new System.Drawing.Point(6, 27);
            this.lstA.Name = "lstA";
            this.lstA.Size = new System.Drawing.Size(244, 244);
            this.lstA.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstA);
            this.groupBox1.Location = new System.Drawing.Point(12, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 277);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(222, 86);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(213, 22);
            this.txtNhap.TabIndex = 5;
            this.txtNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNhap_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstB);
            this.groupBox2.Location = new System.Drawing.Point(410, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 277);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B";
            // 
            // lstB
            // 
            this.lstB.FormattingEnabled = true;
            this.lstB.ItemHeight = 16;
            this.lstB.Location = new System.Drawing.Point(6, 27);
            this.lstB.Name = "lstB";
            this.lstB.Size = new System.Drawing.Size(244, 244);
            this.lstB.TabIndex = 4;
            // 
            // bttXoa
            // 
            this.bttXoa.Location = new System.Drawing.Point(89, 416);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(87, 23);
            this.bttXoa.TabIndex = 6;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.UseVisualStyleBackColor = true;
            this.bttXoa.Click += new System.EventHandler(this.bttXoa_Click);
            // 
            // bttKetThuc
            // 
            this.bttKetThuc.Location = new System.Drawing.Point(482, 416);
            this.bttKetThuc.Name = "bttKetThuc";
            this.bttKetThuc.Size = new System.Drawing.Size(87, 23);
            this.bttKetThuc.TabIndex = 7;
            this.bttKetThuc.Text = "Kết thúc";
            this.bttKetThuc.UseVisualStyleBackColor = true;
            this.bttKetThuc.Click += new System.EventHandler(this.bttKetThuc_Click);
            // 
            // bttQua
            // 
            this.bttQua.Location = new System.Drawing.Point(274, 198);
            this.bttQua.Name = "bttQua";
            this.bttQua.Size = new System.Drawing.Size(58, 23);
            this.bttQua.TabIndex = 8;
            this.bttQua.Text = ">";
            this.bttQua.UseVisualStyleBackColor = true;
            this.bttQua.Click += new System.EventHandler(this.bttQua_Click);
            // 
            // bttLai
            // 
            this.bttLai.Location = new System.Drawing.Point(346, 198);
            this.bttLai.Name = "bttLai";
            this.bttLai.Size = new System.Drawing.Size(58, 23);
            this.bttLai.TabIndex = 9;
            this.bttLai.Text = "<";
            this.bttLai.UseVisualStyleBackColor = true;
            this.bttLai.Click += new System.EventHandler(this.bttLai_Click);
            // 
            // bttLaiHet
            // 
            this.bttLaiHet.Location = new System.Drawing.Point(346, 288);
            this.bttLaiHet.Name = "bttLaiHet";
            this.bttLaiHet.Size = new System.Drawing.Size(58, 23);
            this.bttLaiHet.TabIndex = 11;
            this.bttLaiHet.Text = "<<";
            this.bttLaiHet.UseVisualStyleBackColor = true;
            this.bttLaiHet.Click += new System.EventHandler(this.bttLaiHet_Click);
            // 
            // bttQuaHet
            // 
            this.bttQuaHet.Location = new System.Drawing.Point(274, 288);
            this.bttQuaHet.Name = "bttQuaHet";
            this.bttQuaHet.Size = new System.Drawing.Size(58, 23);
            this.bttQuaHet.TabIndex = 10;
            this.bttQuaHet.Text = ">>";
            this.bttQuaHet.UseVisualStyleBackColor = true;
            this.bttQuaHet.Click += new System.EventHandler(this.bttQuaHet_Click);
            // 
            // frmQLSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 459);
            this.Controls.Add(this.bttLaiHet);
            this.Controls.Add(this.bttQuaHet);
            this.Controls.Add(this.bttLai);
            this.Controls.Add(this.bttQua);
            this.Controls.Add(this.bttKetThuc);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bttCapNhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLSinhVien";
            this.Text = "frmQLSinhVien";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttCapNhat;
        private System.Windows.Forms.ListBox lstA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstB;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.Button bttKetThuc;
        private System.Windows.Forms.Button bttQua;
        private System.Windows.Forms.Button bttLai;
        private System.Windows.Forms.Button bttLaiHet;
        private System.Windows.Forms.Button bttQuaHet;
    }
}