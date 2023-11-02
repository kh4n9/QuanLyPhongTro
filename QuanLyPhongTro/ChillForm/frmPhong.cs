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
        List<tblPhong> listPhong = Program.Context.tblPhongs.ToList();
        public frmPhong()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmXuLyPhong frmXuLyPhong = new frmXuLyPhong(true, null);
            frmXuLyPhong.ShowDialog();
            listPhong = Program.Context.tblPhongs.ToList();
            LoadDGV(listPhong);
        }

        private void LoadDGV(List<tblPhong> listPhong)
        {
            dgvPhong.Rows.Clear();
            foreach (var item in listPhong)
            {
                int index = dgvPhong.Rows.Add();
                dgvPhong.Rows[index].Cells[0].Value = item.MaPhong;
                dgvPhong.Rows[index].Cells[1].Value = item.TenPhong;
                dgvPhong.Rows[index].Cells[2].Value = item.tblLoaiPhong.TenLoaiPhong;
                dgvPhong.Rows[index].Cells[3].Value = item.TrangThai == 1?"Đang thuê":"Trống";
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            if (txtTim.Text.Length > 0)
            {
                LoadDGV(listPhong.Where(p => p.TenPhong.ToString().Contains(txtTim.Text.ToString())).ToList());
            }
            else
            {
                LoadDGV(listPhong);
            }
        }

        private void dgvPhong_DoubleClick(object sender, EventArgs e)
        {
            frmXuLyPhong frmXuLyPhong = new frmXuLyPhong(false, dgvPhong.SelectedRows[0].Cells[0].Value.ToString());
            frmXuLyPhong.ShowDialog();
            listPhong = Program.Context.tblPhongs.ToList();
            LoadDGV(listPhong);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Program.Context.tblPhongs.Remove(listPhong.FirstOrDefault(p =>p.MaPhong.ToString() == dgvPhong.SelectedRows[0].Cells[0].Value.ToString()));
            Program.Context.SaveChanges();
            listPhong = Program.Context.tblPhongs.ToList();
            LoadDGV(listPhong);
            MessageBox.Show("Xóa thành công!");
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            LoadDGV(listPhong);
        }
    }
}
