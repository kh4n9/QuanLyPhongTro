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
    public partial class frmKetThucHopDong : Form
    {
        private tblHopDong hopDong;
        public frmKetThucHopDong(tblHopDong hopDong)
        {
            this.hopDong = hopDong;
            InitializeComponent();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Program.Context.tblHopDongs.FirstOrDefault(h => h.MaHopDong.ToString() == hopDong.MaHopDong.ToString()).DaKetThuc = 1;
            Program.Context.tblPhongs.FirstOrDefault(p => p.MaPhong.ToString() == hopDong.MaPhong.ToString()).TrangThai = 0;
            Program.Context.SaveChanges();
            this.Close();
            MessageBox.Show("Hợp đồng đã kết thúc!");
        }

        private void frmKetThucHopDong_Load(object sender, EventArgs e)
        {
            lblCoc.Text = hopDong.DatCoc.ToString();
            List<tblChiTietHopDong> listChiTiet = Program.Context.tblChiTietHopDongs.Where(c => c.MaHopDong == hopDong.MaHopDong).ToList();
            int noConThieu = 0;
            foreach (var item in listChiTiet)
            {
                int tienMang = (int)item.TienMang;
                int tienVeSinh = (int)item.TienVeSinh;
                int tienDien = (int)((item.CSD_Moi - item.CSD_Cu) * Program.Context.tblCauHinhs.FirstOrDefault().DonGiaDien);
                int tienNuoc = (int)((item.CSN_Moi - item.CSN_Cu) * Program.Context.tblCauHinhs.FirstOrDefault().DonGiaNuoc);
                int tienPhong = (int)item.tblHopDong.tblPhong.tblLoaiPhong.DonGia;
                int tienDaThanhToan = (int)(item.DaThanhToan == null ? 0 : item.DaThanhToan);
                noConThieu += (tienMang + tienVeSinh + tienPhong + tienDien + tienNuoc) - tienDaThanhToan;
            }
            lblNo.Text = (noConThieu - hopDong.tblPhong.tblLoaiPhong.DonGia).ToString();
            lblThanhToan.Text = (int.Parse(lblNo.Text) - int.Parse(lblCoc.Text)).ToString();
        }
    }
}
