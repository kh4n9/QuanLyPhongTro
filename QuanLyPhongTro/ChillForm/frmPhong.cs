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
    public partial class frmPhong : Form
    {
        List<tblPhong> listPhong = Program.Context.tblPhongs.Where(p => p.Hidden != 1).ToList();
        public frmPhong()
        {
            InitializeComponent();
            LoadDGV(listPhong);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmXuLyPhong frmXuLyPhong = new frmXuLyPhong(true, null);
            frmXuLyPhong.ShowDialog();
            listPhong = Program.Context.tblPhongs.Where(p => p.Hidden != 1).ToList();
            LoadDGV(listPhong);
        }

        private void LoadDGV(List<tblPhong> listPhong)
        {
            dgvPhong.Rows.Clear();
            foreach (tblPhong item in listPhong)
            {
                int index = dgvPhong.Rows.Add();
                dgvPhong.Rows[index].Cells[0].Value = item.MaPhong;
                dgvPhong.Rows[index].Cells[1].Value = item.TenPhong;
                dgvPhong.Rows[index].Cells[2].Value = item.tblLoaiPhong.TenLoaiPhong + (item.tblLoaiPhong.Hidden!=1?"":" (Đã xóa)");
                dgvPhong.Rows[index].Cells[3].Value = item.TinhTrang==1?"Đang thuê":"Chưa thuê";
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            if (txtTim.Text.Length == 0)
            {
                LoadDGV(listPhong);
            }
            else
            {
                var listTim = Program.Context.tblPhongs.Where(p => p.TenPhong.Contains(txtTim.Text) && p.Hidden != 1).ToList();
                LoadDGV(listTim);
            }
        }

        private void dgvPhong_DoubleClick(object sender, EventArgs e)
        {
            frmXuLyPhong frmXuLyPhong = new frmXuLyPhong(false, dgvPhong.SelectedRows[0].Cells[0].Value.ToString());
            frmXuLyPhong.ShowDialog();
            listPhong = Program.Context.tblPhongs.Where(p => p.Hidden != 1).ToList();
            LoadDGV(listPhong);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa!");
                return;
            }
            if(MessageBox.Show("Yes để ẩn No để xóa luôn phòng (sẽ ảnh hưởng tới các dữ liệu khác)","Cảnh báo!",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var item = Program.Context.tblPhongs.FirstOrDefault(p => p.MaLoaiPhong.ToString() == dgvPhong.SelectedRows[0].Cells[0].Value.ToString());
                item.Hidden = 1;
            }
            else
            {
                string xoa = dgvPhong.SelectedRows[0].Cells[0].Value.ToString();
                var item = Program.Context.tblPhongs.FirstOrDefault(p => p.MaLoaiPhong.ToString() == xoa);
                Program.Context.tblPhongs.Remove(item);
                Program.Context.SaveChanges();
                listPhong = Program.Context.tblPhongs.Where(p => p.Hidden != 1).ToList();
                LoadDGV(listPhong);
            }
        }
    }
}
