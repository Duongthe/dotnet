namespace lab_04_SuDungCCTreeView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbt1 = new System.Windows.Forms.ToolStripButton();
            this.tsbt2 = new System.Windows.Forms.ToolStripButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imgLAnh = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbt1,
            this.tsbt2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(449, 27);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbt1
            // 
            this.tsbt1.Image = ((System.Drawing.Image)(resources.GetObject("tsbt1.Image")));
            this.tsbt1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbt1.Name = "tsbt1";
            this.tsbt1.Size = new System.Drawing.Size(90, 24);
            this.tsbt1.Text = "Mở rộng";
            // 
            // tsbt2
            // 
            this.tsbt2.Image = ((System.Drawing.Image)(resources.GetObject("tsbt2.Image")));
            this.tsbt2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbt2.Name = "tsbt2";
            this.tsbt2.Size = new System.Drawing.Size(70, 24);
            this.tsbt2.Text = "Đóng";
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imgLAnh;
            this.treeView1.Location = new System.Drawing.Point(12, 30);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(405, 408);
            this.treeView1.TabIndex = 2;
            // 
            // imgLAnh
            // 
            this.imgLAnh.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLAnh.ImageStream")));
            this.imgLAnh.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLAnh.Images.SetKeyName(0, "1.png");
            this.imgLAnh.Images.SetKeyName(1, "2.png");
            this.imgLAnh.Images.SetKeyName(2, "3.png");
            this.imgLAnh.Images.SetKeyName(3, "7.png");
            this.imgLAnh.Images.SetKeyName(4, "6.png");
            this.imgLAnh.Images.SetKeyName(5, "5.png");
            this.imgLAnh.Images.SetKeyName(6, "4.png");
            this.imgLAnh.Images.SetKeyName(7, "Button-Close-icon.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbt1;
        private System.Windows.Forms.ToolStripButton tsbt2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imgLAnh;
    }
}

