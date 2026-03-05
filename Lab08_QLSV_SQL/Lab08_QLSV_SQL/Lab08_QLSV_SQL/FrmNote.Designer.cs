namespace Lab08_QLSV_SQL
{
    partial class FrmNote
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
            groupBox1 = new GroupBox();
            bttLuu = new Button();
            bttMo = new Button();
            rtbNote = new RichTextBox();
            bttTaoMoi = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rtbNote);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(579, 364);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ghi Chú";
            // 
            // bttLuu
            // 
            bttLuu.Location = new Point(113, 382);
            bttLuu.Name = "bttLuu";
            bttLuu.Size = new Size(94, 29);
            bttLuu.TabIndex = 1;
            bttLuu.Text = "Lưu";
            bttLuu.UseVisualStyleBackColor = true;
            bttLuu.Click += bttLuu_Click;
            // 
            // bttMo
            // 
            bttMo.Location = new Point(365, 382);
            bttMo.Name = "bttMo";
            bttMo.Size = new Size(94, 29);
            bttMo.TabIndex = 2;
            bttMo.Text = "Mở";
            bttMo.UseVisualStyleBackColor = true;
            bttMo.Click += bttMo_Click;
            // 
            // rtbNote
            // 
            rtbNote.Location = new Point(6, 26);
            rtbNote.Name = "rtbNote";
            rtbNote.Size = new Size(567, 332);
            rtbNote.TabIndex = 0;
            rtbNote.Text = "";
            // 
            // bttTaoMoi
            // 
            bttTaoMoi.Location = new Point(243, 382);
            bttTaoMoi.Name = "bttTaoMoi";
            bttTaoMoi.Size = new Size(94, 29);
            bttTaoMoi.TabIndex = 3;
            bttTaoMoi.Text = "Tạo mới";
            bttTaoMoi.UseVisualStyleBackColor = true;
            bttTaoMoi.Click += bttTaoMoi_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmNote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 450);
            Controls.Add(bttTaoMoi);
            Controls.Add(bttMo);
            Controls.Add(bttLuu);
            Controls.Add(groupBox1);
            Name = "FrmNote";
            Text = "FrmNote";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RichTextBox rtbNote;
        private Button bttLuu;
        private Button bttMo;
        private Button bttTaoMoi;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}