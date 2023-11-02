namespace QuanLyPhongTro.ChillForm
{
    partial class frmThuePhong
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
            this.grbThuePhong = new System.Windows.Forms.GroupBox();
            this.btnThueMoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.Column20 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbThuePhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThuePhong
            // 
            this.grbThuePhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbThuePhong.BackColor = System.Drawing.Color.Transparent;
            this.grbThuePhong.Controls.Add(this.btnThueMoi);
            this.grbThuePhong.Controls.Add(this.label1);
            this.grbThuePhong.Controls.Add(this.txtTim);
            this.grbThuePhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThuePhong.Location = new System.Drawing.Point(12, 12);
            this.grbThuePhong.Name = "grbThuePhong";
            this.grbThuePhong.Size = new System.Drawing.Size(1224, 81);
            this.grbThuePhong.TabIndex = 6;
            this.grbThuePhong.TabStop = false;
            this.grbThuePhong.Text = "Quản Lý Khách Thuê Phòng";
            // 
            // btnThueMoi
            // 
            this.btnThueMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThueMoi.BackColor = System.Drawing.Color.PaleGreen;
            this.btnThueMoi.Location = new System.Drawing.Point(728, 34);
            this.btnThueMoi.Name = "btnThueMoi";
            this.btnThueMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThueMoi.TabIndex = 3;
            this.btnThueMoi.Text = "Thuê mới";
            this.btnThueMoi.UseVisualStyleBackColor = false;
            this.btnThueMoi.Click += new System.EventHandler(this.btnThueMoi_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // txtTim
            // 
            this.txtTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(385, 34);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(337, 22);
            this.txtTim.TabIndex = 2;
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToDeleteRows = false;
            this.dgvShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShow.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column20,
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9,
            this.Column10,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column23});
            this.dgvShow.GridColor = System.Drawing.Color.LawnGreen;
            this.dgvShow.Location = new System.Drawing.Point(12, 99);
            this.dgvShow.MultiSelect = false;
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(1224, 507);
            this.dgvShow.TabIndex = 5;
            this.dgvShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShow_CellClick);
            this.dgvShow.DoubleClick += new System.EventHandler(this.dgvShow_DoubleClick);
            // 
            // Column20
            // 
            this.Column20.HeaderText = "Thanh Toán";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Text = "Thanh toán";
            this.Column20.UseColumnTextForButtonValue = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên Phòng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên Loại Phòng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Giá phòng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đặt cọc";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngày thuê";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ngày trả";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Số điện cũ";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Giá điện";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Số nước cũ";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Giá nước";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Số điện";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Số nước";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Tiền vệ sinh";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Tiền mạng";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Còn Nợ";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            // 
            // Column23
            // 
            this.Column23.HeaderText = "Mã hợp đồng";
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            this.Column23.Visible = false;
            // 
            // frmThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyPhongTro.Properties.Resources.bg_bggenerator_com;
            this.ClientSize = new System.Drawing.Size(1248, 618);
            this.Controls.Add(this.grbThuePhong);
            this.Controls.Add(this.dgvShow);
            this.Name = "frmThuePhong";
            this.Text = "Quản Lý Khách Thuê Phòng";
            this.Load += new System.EventHandler(this.frmThuePhong_Load);
            this.grbThuePhong.ResumeLayout(false);
            this.grbThuePhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThuePhong;
        private System.Windows.Forms.Button btnThueMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.DataGridViewButtonColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
    }
}