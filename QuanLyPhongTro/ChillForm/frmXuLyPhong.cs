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

namespace QuanLyPhongTro.ChillForm
{
    public partial class frmXuLyPhong : Form
    {
        private bool them;
        private string maPhong;
        List<tblPhong> listPhong = Program.Context.tblPhongs.ToList();
        List<tblLoaiPhong> listLoaiPhong = Program.Context.tblLoaiPhongs.ToList();
        public frmXuLyPhong(bool them, string maPhong)
        {
            InitializeComponent();
            this.them = them;
            this.maPhong = maPhong;
        }

        private void frmXuLyPhong_Load(object sender, EventArgs e)
        {
            if (them)
            {
                this.Text = "Thêm Phòng";
                grbXuLyPhong.Text = "Thêm phòng";
                btnXacNhan.Text = "Thêm";
            }
            else
            {
                this.Text = "Sửa Phòng";
                grbXuLyPhong.Text = "Sửa phòng";
                btnXacNhan.Text = "Sửa";
            }

            cbxLoaiPhong.DataSource = listLoaiPhong;
            cbxLoaiPhong.DisplayMember = "TenLoaiPhong";
            cbxLoaiPhong.ValueMember = "MaLoaiPhong";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (them)
            {
                tblPhong phong = new tblPhong();
                phong.MaPhong = 1;
                phong.TenPhong = txtTenPhong.Text;
                phong.MaLoaiPhong = int.Parse(cbxLoaiPhong.SelectedValue.ToString());
                Program.Context.tblPhongs.Add(phong);
                Program.Context.SaveChanges();
                listPhong = Program.Context.tblPhongs.ToList();
                MessageBox.Show("Thêm thành công!");
                this.Close();
            }
            else
            {
                tblPhong phong = Program.Context.tblPhongs.FirstOrDefault(p => p.MaPhong.ToString() == maPhong);
                phong.TenPhong = txtTenPhong.Text;
                phong.MaLoaiPhong = int.Parse(cbxLoaiPhong.SelectedValue.ToString());
                Program.Context.SaveChanges();
                listPhong = Program.Context.tblPhongs.ToList();
                MessageBox.Show("Sửa thành công!");
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
