namespace Lab08_QLSV_SQL
{
    partial class FrmGioiThieu
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(186, 175);
            label1.Name = "label1";
            label1.Size = new Size(443, 123);
            label1.TabIndex = 0;
            label1.Text = "Bài tập được làm với mục đích sử dụng cho học tập môn .Net";
            // 
            // FrmGioiThieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Name = "FrmGioiThieu";
            Text = "FrmGioiThieu";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
    }
}