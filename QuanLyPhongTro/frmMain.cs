using QuanLyPhongTro.ChillForm;
using QuanLyPhongTro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ChenForm(Form f)
        {
            // làm sạch grb
            grbFormCon.Controls.Clear();
            // cho phép form truyền vào bị chứa bởi form main
            f.TopLevel = false;
            // xóa Bar của form con
            f.FormBorderStyle = FormBorderStyle.None;
            // cho form fill ra đúng kích thước grb
            f.Dock = DockStyle.Fill;
            // form main lấy tên của form con
            this.Text = f.Text;
            // thêm form con vào grb
            grbFormCon.Controls.Add(f);
            // show form con lên
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmWelcome welcome = new frmWelcome();
            ChenForm(welcome);
        }

        private void loạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiPhong frmLoaiPhong = new frmLoaiPhong();
            ChenForm(frmLoaiPhong);
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhong frmPhong = new frmPhong();
            ChenForm(frmPhong);
        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThuePhong frmThuePhong = new frmThuePhong();
            ChenForm(frmThuePhong);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cấuHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCauHinh frmCauHinh = new frmCauHinh();
            frmCauHinh.ShowDialog();
        }
    }
}
