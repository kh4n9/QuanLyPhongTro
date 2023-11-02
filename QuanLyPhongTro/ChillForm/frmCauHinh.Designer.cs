namespace QuanLyPhongTro.ChillForm
{
    partial class frmCauHinh
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
            this.txtDienCu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNuocCu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDienMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNuocMoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDienCu
            // 
            this.txtDienCu.Location = new System.Drawing.Point(99, 47);
            this.txtDienCu.Name = "txtDienCu";
            this.txtDienCu.ReadOnly = true;
            this.txtDienCu.Size = new System.Drawing.Size(100, 20);
            this.txtDienCu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiền điện cũ";
            // 
            // txtNuocCu
            // 
            this.txtNuocCu.Location = new System.Drawing.Point(99, 109);
            this.txtNuocCu.Name = "txtNuocCu";
            this.txtNuocCu.ReadOnly = true;
            this.txtNuocCu.Size = new System.Drawing.Size(100, 20);
            this.txtNuocCu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiền nước cũ";
            // 
            // txtDienMoi
            // 
            this.txtDienMoi.Location = new System.Drawing.Point(310, 47);
            this.txtDienMoi.Name = "txtDienMoi";
            this.txtDienMoi.Size = new System.Drawing.Size(100, 20);
            this.txtDienMoi.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tiền điện mới";
            // 
            // txtNuocMoi
            // 
            this.txtNuocMoi.Location = new System.Drawing.Point(310, 109);
            this.txtNuocMoi.Name = "txtNuocMoi";
            this.txtNuocMoi.Size = new System.Drawing.Size(100, 20);
            this.txtNuocMoi.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tiền nước mới";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(179, 193);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyPhongTro.Properties.Resources.bg_bggenerator_com;
            this.ClientSize = new System.Drawing.Size(449, 280);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNuocMoi);
            this.Controls.Add(this.txtNuocCu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDienMoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDienCu);
            this.Name = "frmCauHinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài đặt cấu hình";
            this.Load += new System.EventHandler(this.frmCauHinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDienCu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNuocCu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDienMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNuocMoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSua;
    }
}