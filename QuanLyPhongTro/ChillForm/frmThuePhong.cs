using QuanLyPhongTro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro.ChillForm
{
    public partial class frmThuePhong : Form
    {
        List<tblChiTietHopDong> listChiTietHopDong = Program.Context.tblChiTietHopDongs.ToList();
        List<tblHopDong> listHopDong =Program.Context.tblHopDongs.Where(h => h.DaKetThuc != 1).ToList();
        public frmThuePhong()
        {
            InitializeComponent();
        }

        private void LoadDGV(List<tblHopDong> listHopDong)
        {
            dgvShow.Rows.Clear();
            foreach (var item in listHopDong)
            {
                int index = dgvShow.Rows.Add();

                dgvShow.Rows[index].Cells[1].Value = item.tblPhong.TenPhong;
                dgvShow.Rows[index].Cells[2].Value = item.tblPhong.tblLoaiPhong.TenLoaiPhong;
                dgvShow.Rows[index].Cells[3].Value = item.GiaPhong;
                dgvShow.Rows[index].Cells[4].Value = item.DatCoc;
                List<tblChiTietHopDong> listChiTiet = listChiTietHopDong.Where(c => c.MaHopDong == item.MaHopDong).ToList();
                dgvShow.Rows[index].Cells[5].Value = listChiTiet.OrderByDescending(c => c.MaCTHopDong).FirstOrDefault().NgayBatDau.Value;
                dgvShow.Rows[index].Cells[6].Value = listChiTiet.OrderByDescending(c => c.MaCTHopDong).FirstOrDefault().NgayKetThuc.Value;
                dgvShow.Rows[index].Cells[7].Value = listChiTiet.OrderByDescending(c => c.MaCTHopDong).FirstOrDefault().CSD_Cu;
                dgvShow.Rows[index].Cells[8].Value = Program.Context.tblCauHinhs.FirstOrDefault().DonGiaDien;
                dgvShow.Rows[index].Cells[9].Value = listChiTiet.OrderByDescending(c => c.MaCTHopDong).FirstOrDefault().CSN_Cu;
                dgvShow.Rows[index].Cells[10].Value = Program.Context.tblCauHinhs.FirstOrDefault().DonGiaNuoc;
                dgvShow.Rows[index].Cells[11].Value = int.Parse(listChiTiet.OrderByDescending(c => c.MaCTHopDong).FirstOrDefault().CSD_Moi.ToString()) - int.Parse(listChiTiet.OrderByDescending(c => c.MaCTHopDong).FirstOrDefault().CSD_Cu.ToString());
                dgvShow.Rows[index].Cells[12].Value = int.Parse(listChiTiet.OrderByDescending(c => c.MaCTHopDong).FirstOrDefault().CSN_Moi.ToString()) - int.Parse(listChiTiet.OrderByDescending(c => c.MaCTHopDong).FirstOrDefault().CSN_Cu.ToString());
                dgvShow.Rows[index].Cells[13].Value = listChiTiet.OrderByDescending(c => c.MaCTHopDong).FirstOrDefault().TienVeSinh;
                dgvShow.Rows[index].Cells[14].Value = listChiTiet.OrderByDescending(c => c.MaCTHopDong).FirstOrDefault().TienMang;

                var maHopDong = dgvShow.SelectedRows[0].Cells[16].Value;
                int noConThieu = 0;
                foreach (var item1 in listChiTiet)
                {
                    int tienMang = (int)item1.TienMang;
                    int tienVeSinh = (int)item1.TienVeSinh;
                    int tienDien = (int)((item1.CSD_Moi - item1.CSD_Cu) * Program.Context.tblCauHinhs.FirstOrDefault().DonGiaDien);
                    int tienNuoc = (int)((item1.CSN_Moi - item1.CSN_Cu) * Program.Context.tblCauHinhs.FirstOrDefault().DonGiaNuoc);
                    int tienPhong = (int)item1.tblHopDong.tblPhong.tblLoaiPhong.DonGia;
                    int tienDaThanhToan = (int)(item1.DaThanhToan == null ? 0 : item1.DaThanhToan);
                    noConThieu += (tienMang + tienVeSinh + tienPhong + tienDien + tienNuoc) - tienDaThanhToan;
                }

                dgvShow.Rows[index].Cells[15].Value = noConThieu.ToString();
                dgvShow.Rows[index].Cells[16].Value = item.MaHopDong;
            }
        }

        private void btnThueMoi_Click(object sender, EventArgs e)
        {
            frmXuLyThuePhong frmXuLyThuePhong = new frmXuLyThuePhong();
            frmXuLyThuePhong.ShowDialog();
            listChiTietHopDong = Program.Context.tblChiTietHopDongs.ToList();
            LoadDGV(listHopDong);
        }

        private void dgvShow_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var maHopDong = dgvShow.SelectedRows[0].Cells[16].Value;
                frmDienNuoc frmDienNuoc = new frmDienNuoc(maHopDong);
                frmDienNuoc.ShowDialog();
                frmThanhToan frmThanhToan = new frmThanhToan(maHopDong);
                frmThanhToan.ShowDialog();
            }        
        }

        private void frmThuePhong_Load(object sender, EventArgs e)
        {
            LoadDGV(listHopDong);
        }
    }
}
