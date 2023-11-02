using QuanLyPhongTro.Models;
using QuanLyPhongTro.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro.ChillForm
{
    public partial class frmXuLyThuePhong : Form
    {
        private List<tblKhachHang> listKhachHang = Program.Context.tblKhachHangs.ToList();
        private List<KhachHang> listKH = new List<KhachHang>();
        private List<tblPhong> listPhong = Program.Context.tblPhongs.ToList();
        private tblCauHinh cauHinh = Program.Context.tblCauHinhs.First();
        public frmXuLyThuePhong()
        {
            InitializeComponent();
        }

        private void LoadCBX(List<tblPhong> listPhong)
        {

            cbxPhong.DataSource = listPhong;
            cbxPhong.DisplayMember = "TenPhong";
            cbxPhong.ValueMember = "MaPhong";
        }

        private void txtTienCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTienCoc_TextChanged(object sender, EventArgs e)
        {
            foreach (var c in txtTienCoc.Text)
            {
                if (!Char.IsDigit(c))
                {
                    MessageBox.Show("Chỉ được nhập số!");
                    txtTienCoc.Text = "";
                    break;
                }
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cbxPhong.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn phòng thuê!");
                return;
            }

            if (dtpNgayBatDau.Value >= dtpNgayKetThuc.Value)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu!");
                return;
            }

            if (txtChiSoDien.Text == "" || txtChiSoNuoc.Text == "" || txtTienVeSinh.Text == "" || txtTienMang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            if (dgvKhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin khách hàng!");
                return;
            }

            // Khởi tạo hợp đồng
            string ma = cbxPhong.SelectedValue.ToString();
            Program.Context.tblHopDongs.Add(new tblHopDong()
            {
                MaHopDong = 1,
                MaPhong = int.Parse(cbxPhong.SelectedValue.ToString()),
                GiaPhong = Program.Context.tblPhongs.FirstOrDefault(p => p.MaPhong.ToString() == cbxPhong.SelectedValue.ToString()).tblLoaiPhong.DonGia,
                DatCoc = int.Parse(txtTienCoc.Text),
                DonGiaDien = cauHinh.DonGiaDien,
                DonGiaNuoc = cauHinh.DonGiaNuoc
            });
            Program.Context.SaveChanges();
            Program.Context.tblPhongs.FirstOrDefault(p => p.MaPhong.ToString() == cbxPhong.SelectedValue.ToString()).TrangThai = 1;

            // khởi tạo chi tiết hợp đồng
            Program.Context.tblChiTietHopDongs.Add(new tblChiTietHopDong()
            {
                MaCTHopDong = 1,
                MaHopDong = Program.Context.tblHopDongs.OrderByDescending(h => h.MaHopDong).FirstOrDefault().MaHopDong,
                NgayBatDau = dtpNgayBatDau.Value,
                NgayKetThuc = dtpNgayKetThuc.Value,

                CSD_Cu = int.Parse(txtChiSoDien.Text),
                CSD_Moi = int.Parse(txtChiSoDien.Text),
                CSN_Cu = int.Parse(txtChiSoNuoc.Text),
                CSN_Moi = int.Parse(txtChiSoNuoc.Text),

                TienVeSinh = int.Parse(txtTienVeSinh.Text),
                TienMang = int.Parse(txtTienMang.Text)
            });
            //Program.Context.tblChiTietHopDongs.OrderByDescending(c => c.MaHopDong).FirstOrDefault().CSD_Cu = int.Parse(txtChiSoDien.Text);
            //Program.Context.tblChiTietHopDongs.OrderByDescending(c => c.MaHopDong).FirstOrDefault().CSN_Cu = int.Parse(txtChiSoNuoc.Text);
            Program.Context.SaveChanges();


            // lưu thông tin khách hàng
            foreach (var kh in listKH)
            {
                Program.Context.tblKhachHangs.Add(new tblKhachHang()
                {
                    TenKhach = kh.HoTen,
                    CCCD = kh.CCCD,
                    DienThoai = kh.DienThoai,
                    QueQuan = kh.QueQuan,
                    HKTT = kh.HKTT
                });
                Program.Context.SaveChanges();

                Program.Context.tblHopDong_KhachHang.Add(new tblHopDong_KhachHang()
                {
                    MaHopDong = Program.Context.tblHopDongs.OrderByDescending(h => h.MaHopDong).FirstOrDefault().MaHopDong,
                    MaKhachHang = Program.Context.tblKhachHangs.OrderByDescending(k => k.MaKhachHang).FirstOrDefault().MaKhachHang
                });
                Program.Context.SaveChanges();

            }

            MessageBox.Show("Tạo hợp đồng thành công!");


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            //tblKhachHang khachHang = new tblKhachHang();
            //khachHang.TenKhach = txtHoTen.Text;
            //khachHang.CCCD = txtCCCD.Text;
            //khachHang.DienThoai = txtDienThoai.Text;
            //khachHang.QueQuan = txtQueQuan.Text;
            //khachHang.HKTT = txtHKTT.Text;

            //if (khachHang.TenKhach == "" || khachHang.CCCD == "" || khachHang.DienThoai == "" || khachHang.QueQuan == "" || khachHang.HKTT == "")
            //{
            //    MessageBox.Show("Vui lòng nhập đủ thông tin!");
            //    return;
            //}

            //Program.Context.tblKhachHangs.Add(khachHang);
            //Program.Context.SaveChanges();
            //listKhachHang = Program.Context.tblKhachHangs.ToList();
            //LoadDGVKhachHang(listKhachHang);
            //txtHoTen.Text = "";
            //txtCCCD.Text = "";
            //txtDienThoai.Text = "";
            //txtHKTT.Text = "";
            //txtQueQuan.Text = "";

            //MessageBox.Show("Thêm thành công!");


            listKH.Add(new KhachHang()
            {
                HoTen = txtHoTen.Text,
                CCCD = txtCCCD.Text,
                DienThoai = txtDienThoai.Text,
                QueQuan = txtQueQuan.Text,
                HKTT = txtHKTT.Text
            });

            LoadDGVKhachHang(listKH);

            txtHoTen.Text = txtCCCD.Text = txtQueQuan.Text = txtHKTT.Text = txtDienThoai.Text = "";
        }

        private void LoadDGVKhachHang(List<KhachHang> listKhachHang)
        {
            dgvKhachHang.Rows.Clear();
            //foreach (var item in listKhachHang)
            //{
            //    int index = dgvKhachHang.Rows.Add();
            //    dgvKhachHang.Rows[index].Cells[0].Value = item.TenKhach;
            //    dgvKhachHang.Rows[index].Cells[1].Value = item.CCCD;
            //    dgvKhachHang.Rows[index].Cells[2].Value = item.DienThoai;
            //    dgvKhachHang.Rows[index].Cells[3].Value = item.QueQuan;
            //    dgvKhachHang.Rows[index].Cells[4].Value = item.HKTT;
            //}
            foreach (var item in listKH)
            {
                int index = dgvKhachHang.Rows.Add();
                dgvKhachHang.Rows[index].Cells[0].Value = item.HoTen;
                dgvKhachHang.Rows[index].Cells[1].Value = item.CCCD;
                dgvKhachHang.Rows[index].Cells[2].Value = item.DienThoai;
                dgvKhachHang.Rows[index].Cells[3].Value = item.QueQuan;
                dgvKhachHang.Rows[index].Cells[4].Value = item.HKTT;
            }
        }

        private void frmXuLyThuePhong_Load(object sender, EventArgs e)
        {
            //LoadDGVKhachHang(listKhachHang);
            LoadCBX(listPhong);
        }

        private void txtChiSoDien_TextChanged(object sender, EventArgs e)
        {
            foreach (var c in txtChiSoDien.Text)
            {
                if (!Char.IsDigit(c))
                {
                    MessageBox.Show("Chỉ được nhập số!");
                    txtTienCoc.Text = "";
                    break;
                }
            }
        }

        private void txtChiSoNuoc_TextChanged(object sender, EventArgs e)
        {
            foreach (var c in txtChiSoNuoc.Text)
            {
                if (!Char.IsDigit(c))
                {
                    MessageBox.Show("Chỉ được nhập số!");
                    txtTienCoc.Text = "";
                    break;
                }
            }
        }

        private void txtTienVeSinh_TextChanged(object sender, EventArgs e)
        {
            foreach (var c in txtTienVeSinh.Text)
            {
                if (!Char.IsDigit(c))
                {
                    MessageBox.Show("Chỉ được nhập số!");
                    txtTienCoc.Text = "";
                    break;
                }
            }
        }

        private void txtTienMang_TextChanged(object sender, EventArgs e)
        {
            foreach (var c in txtTienMang.Text)
            {
                if (!Char.IsDigit(c))
                {
                    MessageBox.Show("Chỉ được nhập số!");
                    txtTienCoc.Text = "";
                    break;
                }
            }
        }
    }
}
