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
        private bool themPhong;
        List<tblLoaiPhong> listLoaiPhong = Program.Context.tblLoaiPhongs.ToList();
        public frmXuLyPhong(bool themPhong)
        {
            InitializeComponent();
            this.themPhong = themPhong;
        }

        private void frmXuLyPhong_Load(object sender, EventArgs e)
        {
            LoadLoaiForm();
            LoadCBX();
        }

        private void LoadLoaiForm()
        {
            if (themPhong)
            {
                this.Text = "Thêm Phòng";
                grbXuLyPhong.Text = "Xử lý thêm phòng";
                btnXacNhan.Text = "Thêm";
            }
            else
            {
                this.Text = "Sửa Phòng";
                grbXuLyPhong.Text = "Xử lý sửa phòng";
                btnXacNhan.Text = "Sửa";
            }
        }

        private void LoadCBX()
        {
            cbxLoaiPhong.DataSource = listLoaiPhong;
            cbxLoaiPhong.DisplayMember = "TenLoaiPhong";
            cbxLoaiPhong.ValueMember = "MaLoaiPhong";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtTenPhong.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên phòng!");
                txtTenPhong.Select();
                return;
            }
            if (themPhong)
            {
                tblPhong phongMoi = new tblPhong();
                phongMoi.MaPhong = 1;
                phongMoi.TenPhong = txtTenPhong.Text;
                phongMoi.MaLoaiPhong = int.Parse(cbxLoaiPhong.SelectedValue.ToString());
                phongMoi.TinhTrang = (byte)(ckbTinhTrang.Checked?1:0);

                Program.Context.tblPhongs.Add(phongMoi);
                Program.Context.SaveChanges();

                MessageBox.Show("Thêm phòng thành công!");
            }
            else
            {

            }
        }
    }
}
