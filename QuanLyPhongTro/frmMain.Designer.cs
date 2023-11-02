namespace QuanLyPhongTro
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grbFormCon = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cấuHìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tácVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuêPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbFormCon
            // 
            this.grbFormCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbFormCon.Location = new System.Drawing.Point(0, 24);
            this.grbFormCon.Name = "grbFormCon";
            this.grbFormCon.Size = new System.Drawing.Size(1264, 657);
            this.grbFormCon.TabIndex = 0;
            this.grbFormCon.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.tácVụToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cấuHìnhToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // cấuHìnhToolStripMenuItem
            // 
            this.cấuHìnhToolStripMenuItem.Name = "cấuHìnhToolStripMenuItem";
            this.cấuHìnhToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cấuHìnhToolStripMenuItem.Text = "Cấu hình";
            this.cấuHìnhToolStripMenuItem.Click += new System.EventHandler(this.cấuHìnhToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phòngToolStripMenuItem,
            this.loạiPhòngToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // phòngToolStripMenuItem
            // 
            this.phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
            this.phòngToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.phòngToolStripMenuItem.Text = "Phòng";
            this.phòngToolStripMenuItem.Click += new System.EventHandler(this.phòngToolStripMenuItem_Click);
            // 
            // loạiPhòngToolStripMenuItem
            // 
            this.loạiPhòngToolStripMenuItem.Name = "loạiPhòngToolStripMenuItem";
            this.loạiPhòngToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.loạiPhòngToolStripMenuItem.Text = "Loại phòng";
            this.loạiPhòngToolStripMenuItem.Click += new System.EventHandler(this.loạiPhòngToolStripMenuItem_Click);
            // 
            // tácVụToolStripMenuItem
            // 
            this.tácVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thuêPhòngToolStripMenuItem});
            this.tácVụToolStripMenuItem.Name = "tácVụToolStripMenuItem";
            this.tácVụToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.tácVụToolStripMenuItem.Text = "Tác vụ";
            // 
            // thuêPhòngToolStripMenuItem
            // 
            this.thuêPhòngToolStripMenuItem.Name = "thuêPhòngToolStripMenuItem";
            this.thuêPhòngToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.thuêPhòngToolStripMenuItem.Text = "Thuê phòng";
            this.thuêPhòngToolStripMenuItem.Click += new System.EventHandler(this.thuêPhòngToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.grbFormCon);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phòng Trọ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFormCon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cấuHìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tácVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuêPhòngToolStripMenuItem;
    }
}

