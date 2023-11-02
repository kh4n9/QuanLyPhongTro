namespace QuanLyPhongTro.ChillForm
{
    partial class frmKetThucHopDong
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
            this.lblNo = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblCoc = new System.Windows.Forms.Label();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiền cọc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tiền nợ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số tiền cần thanh toán";
            // 
            // lblNo
            // 
            this.lblNo.Location = new System.Drawing.Point(174, 60);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(97, 13);
            this.lblNo.TabIndex = 0;
            this.lblNo.Text = "0";
            this.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(117, 277);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 23);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lblCoc
            // 
            this.lblCoc.Location = new System.Drawing.Point(174, 112);
            this.lblCoc.Name = "lblCoc";
            this.lblCoc.Size = new System.Drawing.Size(97, 13);
            this.lblCoc.TabIndex = 0;
            this.lblCoc.Text = "0";
            this.lblCoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.Location = new System.Drawing.Point(174, 173);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(97, 13);
            this.lblThanhToan.TabIndex = 0;
            this.lblThanhToan.Text = "0";
            this.lblThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmKetThucHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyPhongTro.Properties.Resources.bg_bggenerator_com;
            this.ClientSize = new System.Drawing.Size(336, 350);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.lblThanhToan);
            this.Controls.Add(this.lblCoc);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmKetThucHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết Thúc Hợp Đồng";
            this.Load += new System.EventHandler(this.frmKetThucHopDong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblCoc;
        private System.Windows.Forms.Label lblThanhToan;
    }
}