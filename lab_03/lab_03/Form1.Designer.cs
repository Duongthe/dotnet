namespace lab_03
{
    partial class frmPhepTinh
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.txtSoM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.bttCong = new System.Windows.Forms.Button();
            this.bttTru = new System.Windows.Forms.Button();
            this.bttNhan = new System.Windows.Forms.Button();
            this.bttChia = new System.Windows.Forms.Button();
            this.bttXoa = new System.Windows.Forms.Button();
            this.bttThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thực hiện các phép tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số n:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập số m:";
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(163, 94);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(262, 22);
            this.txtSoN.TabIndex = 3;
            this.txtSoN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSoM
            // 
            this.txtSoM.Location = new System.Drawing.Point(163, 164);
            this.txtSoM.Name = "txtSoM";
            this.txtSoM.Size = new System.Drawing.Size(262, 22);
            this.txtSoM.TabIndex = 4;
            this.txtSoM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            this.txtKetQua.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtKetQua.Enabled = false;
            this.txtKetQua.Location = new System.Drawing.Point(163, 233);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(262, 22);
            this.txtKetQua.TabIndex = 6;
            this.txtKetQua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bttCong
            // 
            this.bttCong.Location = new System.Drawing.Point(77, 292);
            this.bttCong.Name = "bttCong";
            this.bttCong.Size = new System.Drawing.Size(51, 23);
            this.bttCong.TabIndex = 7;
            this.bttCong.Text = "+";
            this.bttCong.UseVisualStyleBackColor = true;
            this.bttCong.Click += new System.EventHandler(this.bttCong_Click);
            // 
            // bttTru
            // 
            this.bttTru.Location = new System.Drawing.Point(158, 292);
            this.bttTru.Name = "bttTru";
            this.bttTru.Size = new System.Drawing.Size(51, 23);
            this.bttTru.TabIndex = 8;
            this.bttTru.Text = "-";
            this.bttTru.UseVisualStyleBackColor = true;
            this.bttTru.Click += new System.EventHandler(this.bttTru_Click);
            // 
            // bttNhan
            // 
            this.bttNhan.Location = new System.Drawing.Point(239, 292);
            this.bttNhan.Name = "bttNhan";
            this.bttNhan.Size = new System.Drawing.Size(51, 23);
            this.bttNhan.TabIndex = 9;
            this.bttNhan.Text = "x";
            this.bttNhan.UseVisualStyleBackColor = true;
            this.bttNhan.Click += new System.EventHandler(this.bttNhan_Click);
            // 
            // bttChia
            // 
            this.bttChia.Location = new System.Drawing.Point(320, 292);
            this.bttChia.Name = "bttChia";
            this.bttChia.Size = new System.Drawing.Size(51, 23);
            this.bttChia.TabIndex = 11;
            this.bttChia.Text = "\\";
            this.bttChia.UseVisualStyleBackColor = true;
            this.bttChia.Click += new System.EventHandler(this.bttChia_Click);
            // 
            // bttXoa
            // 
            this.bttXoa.Location = new System.Drawing.Point(158, 332);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(51, 23);
            this.bttXoa.TabIndex = 12;
            this.bttXoa.Text = "xóa";
            this.bttXoa.UseVisualStyleBackColor = true;
            this.bttXoa.Click += new System.EventHandler(this.bttXoa_Click);
            // 
            // bttThoat
            // 
            this.bttThoat.Location = new System.Drawing.Point(239, 332);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(51, 23);
            this.bttThoat.TabIndex = 13;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // frmPhepTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 408);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.bttChia);
            this.Controls.Add(this.bttNhan);
            this.Controls.Add(this.bttTru);
            this.Controls.Add(this.bttCong);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoM);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPhepTinh";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.TextBox txtSoM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button bttCong;
        private System.Windows.Forms.Button bttTru;
        private System.Windows.Forms.Button bttNhan;
        private System.Windows.Forms.Button bttChia;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.Button bttThoat;
    }
}

