namespace QuanLyPhongTro.ChillForm
{
    partial class frmXuLyPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuLyPhong));
            this.grbXuLyPhong = new System.Windows.Forms.GroupBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.cbxLoaiPhong = new System.Windows.Forms.ComboBox();
            this.ckbTinhTrang = new System.Windows.Forms.CheckBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.grbXuLyPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbXuLyPhong
            // 
            this.grbXuLyPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbXuLyPhong.BackColor = System.Drawing.Color.Transparent;
            this.grbXuLyPhong.Controls.Add(this.btnHuy);
            this.grbXuLyPhong.Controls.Add(this.btnXacNhan);
            this.grbXuLyPhong.Controls.Add(this.cbxLoaiPhong);
            this.grbXuLyPhong.Controls.Add(this.ckbTinhTrang);
            this.grbXuLyPhong.Controls.Add(this.txtTenPhong);
            this.grbXuLyPhong.Controls.Add(this.label2);
            this.grbXuLyPhong.Controls.Add(this.label1);
            this.grbXuLyPhong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbXuLyPhong.Location = new System.Drawing.Point(12, 12);
            this.grbXuLyPhong.Name = "grbXuLyPhong";
            this.grbXuLyPhong.Size = new System.Drawing.Size(460, 337);
            this.grbXuLyPhong.TabIndex = 0;
            this.grbXuLyPhong.TabStop = false;
            this.grbXuLyPhong.Text = "Xử Lý Phòng";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXacNhan.Location = new System.Drawing.Point(323, 223);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(77, 38);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "Xác nhận xử lý phòng";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // cbxLoaiPhong
            // 
            this.cbxLoaiPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxLoaiPhong.FormattingEnabled = true;
            this.cbxLoaiPhong.Location = new System.Drawing.Point(96, 100);
            this.cbxLoaiPhong.Name = "cbxLoaiPhong";
            this.cbxLoaiPhong.Size = new System.Drawing.Size(304, 21);
            this.cbxLoaiPhong.TabIndex = 3;
            // 
            // ckbTinhTrang
            // 
            this.ckbTinhTrang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbTinhTrang.AutoSize = true;
            this.ckbTinhTrang.Location = new System.Drawing.Point(96, 157);
            this.ckbTinhTrang.Name = "ckbTinhTrang";
            this.ckbTinhTrang.Size = new System.Drawing.Size(104, 17);
            this.ckbTinhTrang.TabIndex = 2;
            this.ckbTinhTrang.Text = "Đang được thuê";
            this.ckbTinhTrang.UseVisualStyleBackColor = true;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenPhong.Location = new System.Drawing.Point(96, 38);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(304, 20);
            this.txtTenPhong.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại phòng";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên phòng";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHuy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHuy.Location = new System.Drawing.Point(240, 223);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(77, 38);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // frmXuLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyPhongTro.Properties.Resources.bg_bggenerator_com;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.grbXuLyPhong);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmXuLyPhong";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xử Lý Phòng";
            this.Load += new System.EventHandler(this.frmXuLyPhong_Load);
            this.grbXuLyPhong.ResumeLayout(false);
            this.grbXuLyPhong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbXuLyPhong;
        private System.Windows.Forms.ComboBox cbxLoaiPhong;
        private System.Windows.Forms.CheckBox ckbTinhTrang;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
    }
}