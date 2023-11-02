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
    public partial class frmThanhToan : Form
    {
        private object maHopDong;
        public frmThanhToan(object maHopDong)
        {
            InitializeComponent();
            this.maHopDong = maHopDong;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtThanhToan.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền để thanh toán!");
                return;
            }
            tblHopDong hopDong = Program.Context.tblHopDongs.FirstOrDefault(h => h.MaHopDong.ToString() == maHopDong.ToString());
            Program.Context.tblChiTietHopDongs.Where(c => c.MaHopDong == hopDong.MaHopDong).OrderByDescending(c => c.MaCTHopDong).FirstOrDefault().DaThanhToan =
                Program.Context.tblChiTietHopDongs.Where(c => c.MaHopDong == hopDong.MaHopDong).OrderByDescending(c => c.MaCTHopDong).FirstOrDefault().DaThanhToan == null ? 0 : Program.Context.tblChiTietHopDongs.Where(c => c.MaHopDong == hopDong.MaHopDong).OrderByDescending(c => c.MaCTHopDong).FirstOrDefault().DaThanhToan;
            Program.Context.SaveChanges();
            Program.Context.tblChiTietHopDongs.Where(c => c.MaHopDong == hopDong.MaHopDong).OrderByDescending(c => c.MaCTHopDong).FirstOrDefault().DaThanhToan  += int.Parse(txtThanhToan.Text);
            Program.Context.SaveChanges();


            List<tblChiTietHopDong> listChiTiet = Program.Context.tblChiTietHopDongs.Where(c => c.MaHopDong == hopDong.MaHopDong).ToList();
            tblChiTietHopDong chiTietHopDongCuoi = listChiTiet.OrderByDescending(c => c.MaCTHopDong).FirstOrDefault();

            Program.Context.tblChiTietHopDongs.Add(new tblChiTietHopDong()
            {
                MaHopDong = hopDong.MaHopDong,
                NgayBatDau = chiTietHopDongCuoi.NgayKetThuc,
                NgayKetThuc = chiTietHopDongCuoi.NgayKetThuc.Value.AddDays(chiTietHopDongCuoi.NgayKetThuc.Value.Subtract(chiTietHopDongCuoi.NgayBatDau.Value).TotalDays),
                CSD_Cu = chiTietHopDongCuoi.CSD_Moi,
                CSD_Moi = chiTietHopDongCuoi.CSD_Moi,
                CSN_Cu = chiTietHopDongCuoi.CSN_Moi,
                CSN_Moi = chiTietHopDongCuoi.CSN_Moi,
                TienVeSinh = chiTietHopDongCuoi.TienVeSinh,
                TienMang = chiTietHopDongCuoi.TienMang,
                DaThanhToan = 0
            });
            Program.Context.SaveChanges();

            MessageBox.Show("Thanh toán và gia hạn thành công!");
            this.Close();

        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            tblHopDong hopDong = Program.Context.tblHopDongs.FirstOrDefault(h => h.MaHopDong.ToString() == maHopDong.ToString());
            lblPhong.Text = hopDong.tblPhong.TenPhong;
            lblTienPhong.Text = hopDong.tblPhong.tblLoaiPhong.DonGia.ToString();
            List<tblChiTietHopDong> listChiTiet = Program.Context.tblChiTietHopDongs.Where(c => c.MaHopDong == hopDong.MaHopDong).ToList();
            lblTienDien.Text = ((int.Parse(listChiTiet.OrderByDescending(c => c.MaCTHopDong).FirstOrDefault().CSD_Moi.ToString()) - int.Parse(listChiTiet.OrderByDescending(c => c.MaCTHopDong).FirstOrDefault().CSD_Cu.ToString())) * Program.Context.tblCauHinhs.FirstOrDefault().DonGiaDien).ToString();
            lblTienNuoc.Text = ((int.Parse(listChiTiet.OrderByDescending(c => c.MaCTHopDong).FirstOrDefault().CSN_Moi.ToString()) - int.Parse(listChiTiet.OrderByDescending(c => c.MaCTHopDong).FirstOrDefault().CSN_Cu.ToString())) * Program.Context.tblCauHinhs.FirstOrDefault().DonGiaNuoc).ToString();
            lblTienVeSinh.Text = listChiTiet.OrderByDescending(c => c.MaCTHopDong).FirstOrDefault().TienVeSinh.ToString();
            lblTienMang.Text = listChiTiet.OrderByDescending(c => c.MaCTHopDong).FirstOrDefault().TienMang.ToString();
            lblTongTienCuaThang.Text = (int.Parse(lblTienDien.Text) + int.Parse(lblTienNuoc.Text) + int.Parse(lblTienVeSinh.Text) + int.Parse(lblTienMang.Text) + int.Parse(lblTienPhong.Text)).ToString();
            int noConThieu = 0;
            foreach (var item in  listChiTiet)
            {
                int tienMang = (int)item.TienMang;
                int tienVeSinh = (int)item.TienVeSinh;
                int tienDien = (int)((item.CSD_Moi - item.CSD_Cu) * Program.Context.tblCauHinhs.FirstOrDefault().DonGiaDien);
                int tienNuoc = (int)((item.CSN_Moi - item.CSN_Cu) * Program.Context.tblCauHinhs.FirstOrDefault().DonGiaNuoc);
                int tienPhong = (int)item.tblHopDong.tblPhong.tblLoaiPhong.DonGia;
                int tienDaThanhToan = (int)(item.DaThanhToan==null?0:item.DaThanhToan);
                noConThieu += (tienMang + tienVeSinh + tienPhong + tienDien + tienNuoc) - tienDaThanhToan;
            }
            lblSoNoConThieu.Text = noConThieu.ToString();
        }

        private void btnThanhToanVaTraPhong_Click(object sender, EventArgs e)
        {
            frmKetThucHopDong frmKetThucHopDong = new frmKetThucHopDong(Program.Context.tblHopDongs.FirstOrDefault(h => h.MaHopDong.ToString() == maHopDong.ToString()));
            frmKetThucHopDong.ShowDialog();
            this.Close();
        }
    }
}
