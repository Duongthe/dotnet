namespace QLSinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.bttCapNhat = new System.Windows.Forms.Button();
            this.txtMSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttXoa = new System.Windows.Forms.Button();
            this.bttThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bttTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bttQua = new System.Windows.Forms.Button();
            this.bttLai = new System.Windows.Forms.Button();
            this.bttQuaHet = new System.Windows.Forms.Button();
            this.bttLaiHet = new System.Windows.Forms.Button();
            this.lvA = new System.Windows.Forms.ListView();
            this.lvB = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV";
            // 
            // bttCapNhat
            // 
            this.bttCapNhat.Location = new System.Drawing.Point(382, 25);
            this.bttCapNhat.Name = "bttCapNhat";
            this.bttCapNhat.Size = new System.Drawing.Size(83, 23);
            this.bttCapNhat.TabIndex = 1;
            this.bttCapNhat.Text = "Cập nhật";
            this.bttCapNhat.UseVisualStyleBackColor = true;
            this.bttCapNhat.Click += new System.EventHandler(this.bttCapNhat_Click);
            // 
            // txtMSV
            // 
            this.txtMSV.Location = new System.Drawing.Point(15, 25);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.Size = new System.Drawing.Size(100, 22);
            this.txtMSV.TabIndex = 3;
            this.txtMSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMSV_KeyPress);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(148, 25);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(168, 22);
            this.txtHoTen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Họ và tên";
            // 
            // bttXoa
            // 
            this.bttXoa.Location = new System.Drawing.Point(474, 24);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(75, 23);
            this.bttXoa.TabIndex = 6;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.UseVisualStyleBackColor = true;
            this.bttXoa.Click += new System.EventHandler(this.bttXoa_Click);
            // 
            // bttThoat
            // 
            this.bttThoat.Location = new System.Drawing.Point(558, 25);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(75, 23);
            this.bttThoat.TabIndex = 7;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Danh sách sinh viên";
            // 
            // bttTimKiem
            // 
            this.bttTimKiem.Location = new System.Drawing.Point(147, 83);
            this.bttTimKiem.Name = "bttTimKiem";
            this.bttTimKiem.Size = new System.Drawing.Size(84, 23);
            this.bttTimKiem.TabIndex = 9;
            this.bttTimKiem.Text = "Tìm kiếm";
            this.bttTimKiem.UseVisualStyleBackColor = true;
            this.bttTimKiem.Click += new System.EventHandler(this.bttTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(248, 83);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(217, 22);
            this.txtTimKiem.TabIndex = 10;
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiem_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Danh sách đã chọn";
            // 
            // bttQua
            // 
            this.bttQua.Location = new System.Drawing.Point(287, 199);
            this.bttQua.Name = "bttQua";
            this.bttQua.Size = new System.Drawing.Size(75, 23);
            this.bttQua.TabIndex = 13;
            this.bttQua.Text = ">";
            this.bttQua.UseVisualStyleBackColor = true;
            this.bttQua.Click += new System.EventHandler(this.bttQua_Click);
            // 
            // bttLai
            // 
            this.bttLai.Location = new System.Drawing.Point(287, 235);
            this.bttLai.Name = "bttLai";
            this.bttLai.Size = new System.Drawing.Size(75, 23);
            this.bttLai.TabIndex = 14;
            this.bttLai.Text = "<";
            this.bttLai.UseVisualStyleBackColor = true;
            this.bttLai.Click += new System.EventHandler(this.bttLai_Click);
            // 
            // bttQuaHet
            // 
            this.bttQuaHet.Location = new System.Drawing.Point(287, 270);
            this.bttQuaHet.Name = "bttQuaHet";
            this.bttQuaHet.Size = new System.Drawing.Size(75, 23);
            this.bttQuaHet.TabIndex = 15;
            this.bttQuaHet.Text = ">>";
            this.bttQuaHet.UseVisualStyleBackColor = true;
            this.bttQuaHet.Click += new System.EventHandler(this.bttQuaHet_Click);
            // 
            // bttLaiHet
            // 
            this.bttLaiHet.Location = new System.Drawing.Point(287, 306);
            this.bttLaiHet.Name = "bttLaiHet";
            this.bttLaiHet.Size = new System.Drawing.Size(75, 23);
            this.bttLaiHet.TabIndex = 16;
            this.bttLaiHet.Text = "<<";
            this.bttLaiHet.UseVisualStyleBackColor = true;
            this.bttLaiHet.Click += new System.EventHandler(this.bttLaiHet_Click);
            // 
            // lvA
            // 
            this.lvA.HideSelection = false;
            this.lvA.Location = new System.Drawing.Point(15, 117);
            this.lvA.Name = "lvA";
            this.lvA.Size = new System.Drawing.Size(260, 321);
            this.lvA.TabIndex = 17;
            this.lvA.UseCompatibleStateImageBehavior = false;
            // 
            // lvB
            // 
            this.lvB.HideSelection = false;
            this.lvB.Location = new System.Drawing.Point(373, 117);
            this.lvB.Name = "lvB";
            this.lvB.Size = new System.Drawing.Size(260, 321);
            this.lvB.TabIndex = 18;
            this.lvB.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.lvB);
            this.Controls.Add(this.lvA);
            this.Controls.Add(this.bttLaiHet);
            this.Controls.Add(this.bttQuaHet);
            this.Controls.Add(this.bttLai);
            this.Controls.Add(this.bttQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.bttTimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMSV);
            this.Controls.Add(this.bttCapNhat);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttCapNhat;
        private System.Windows.Forms.TextBox txtMSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttQua;
        private System.Windows.Forms.Button bttLai;
        private System.Windows.Forms.Button bttQuaHet;
        private System.Windows.Forms.Button bttLaiHet;
        private System.Windows.Forms.ListView lvA;
        private System.Windows.Forms.ListView lvB;
    }
}

