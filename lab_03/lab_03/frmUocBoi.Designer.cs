namespace lab_03
{
    partial class frmUocBoi
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
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbUC = new System.Windows.Forms.RadioButton();
            this.rdbBC = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bttTim = new System.Windows.Forms.Button();
            this.bttBoQua = new System.Windows.Forms.Button();
            this.bttThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKetQua
            // 
            this.txtKetQua.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtKetQua.Enabled = false;
            this.txtKetQua.Location = new System.Drawing.Point(41, 30);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(246, 22);
            this.txtKetQua.TabIndex = 12;
            this.txtKetQua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(41, 59);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(246, 22);
            this.txtSoB.TabIndex = 10;
            this.txtSoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(41, 21);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(246, 22);
            this.txtSoA.TabIndex = 9;
            this.txtSoA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "B:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "A:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoA);
            this.groupBox1.Controls.Add(this.txtSoB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 103);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbBC);
            this.groupBox2.Controls.Add(this.rdbUC);
            this.groupBox2.Location = new System.Drawing.Point(324, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(94, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn tìm";
            // 
            // rdbUC
            // 
            this.rdbUC.AutoSize = true;
            this.rdbUC.Location = new System.Drawing.Point(6, 21);
            this.rdbUC.Name = "rdbUC";
            this.rdbUC.Size = new System.Drawing.Size(73, 20);
            this.rdbUC.TabIndex = 0;
            this.rdbUC.TabStop = true;
            this.rdbUC.Text = "USCLN";
            this.rdbUC.UseVisualStyleBackColor = true;
            // 
            // rdbBC
            // 
            this.rdbBC.AutoSize = true;
            this.rdbBC.Location = new System.Drawing.Point(6, 58);
            this.rdbBC.Name = "rdbBC";
            this.rdbBC.Size = new System.Drawing.Size(75, 20);
            this.rdbBC.TabIndex = 1;
            this.rdbBC.TabStop = true;
            this.rdbBC.Text = "BSCNN";
            this.rdbBC.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bttThoat);
            this.groupBox3.Controls.Add(this.bttBoQua);
            this.groupBox3.Controls.Add(this.bttTim);
            this.groupBox3.Controls.Add(this.txtKetQua);
            this.groupBox3.Location = new System.Drawing.Point(12, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 100);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // bttTim
            // 
            this.bttTim.Location = new System.Drawing.Point(41, 58);
            this.bttTim.Name = "bttTim";
            this.bttTim.Size = new System.Drawing.Size(75, 23);
            this.bttTim.TabIndex = 16;
            this.bttTim.Text = "Tìm";
            this.bttTim.UseVisualStyleBackColor = true;
            this.bttTim.Click += new System.EventHandler(this.bttTim_Click);
            // 
            // bttBoQua
            // 
            this.bttBoQua.Location = new System.Drawing.Point(126, 58);
            this.bttBoQua.Name = "bttBoQua";
            this.bttBoQua.Size = new System.Drawing.Size(75, 23);
            this.bttBoQua.TabIndex = 17;
            this.bttBoQua.Text = "Bỏ qua";
            this.bttBoQua.UseVisualStyleBackColor = true;
            this.bttBoQua.Click += new System.EventHandler(this.bttBoQua_Click);
            // 
            // bttThoat
            // 
            this.bttThoat.Location = new System.Drawing.Point(212, 58);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(75, 23);
            this.bttThoat.TabIndex = 18;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // frmUocBoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(438, 254);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUocBoi";
            this.Text = "frmUocBoi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbBC;
        private System.Windows.Forms.RadioButton rdbUC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.Button bttBoQua;
        private System.Windows.Forms.Button bttTim;
    }
}