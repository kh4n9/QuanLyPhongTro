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
    public partial class frmLoaiPhong : Form
    {
        private List<tblLoaiPhong> listLoaiPhong = Program.Context.tblLoaiPhongs.ToList();
        private int xacNhan = 0; // 1 thì đang ở chế độ thêm
        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xacNhan = 1;
            btnXacNhan.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            txtTenLoai.ReadOnly = false;
            txtDonGia.ReadOnly = false;
        }

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            LoadDGV(listLoaiPhong);
        }

        private void LoadDGV(List<tblLoaiPhong> listLoaiPhong)
        {
            dgvLoaiPhong.Rows.Clear();
            foreach (tblLoaiPhong item in listLoaiPhong)
            {
                int index = dgvLoaiPhong.Rows.Add();
                dgvLoaiPhong.Rows[index].Cells[0].Value = item.MaLoaiPhong;
                dgvLoaiPhong.Rows[index].Cells[1].Value = item.TenLoaiPhong;
                dgvLoaiPhong.Rows[index].Cells[2].Value = item.DonGia;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            foreach (var c in txtDonGia.Text)
            {
                if (!Char.IsDigit(c))
                {
                    MessageBox.Show("Chỉ được nhập số!");
                    txtDonGia.Text = "";
                    break;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xacNhan = 2;
            btnXacNhan.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            txtTenLoai.ReadOnly = false;
            txtDonGia.ReadOnly = false;
        }

        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenLoai.Text = dgvLoaiPhong.SelectedRows[0].Cells[1].Value.ToString();
            txtDonGia.Text = dgvLoaiPhong.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (xacNhan == 1)
            {
                tblLoaiPhong loai = new tblLoaiPhong();
                loai.MaLoaiPhong = 1;
                loai.TenLoaiPhong = txtTenLoai.Text;
                loai.DonGia = int.Parse(txtDonGia.Text);
                listLoaiPhong.Add(loai);
                Program.Context.tblLoaiPhongs.Add(loai);
                Program.Context.SaveChanges();
                LoadDGV(listLoaiPhong);
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                string maLoai = dgvLoaiPhong.SelectedRows[0].Cells[0].Value.ToString();
                tblLoaiPhong loai = Program.Context.tblLoaiPhongs.FirstOrDefault(l => l.MaLoaiPhong.ToString() == maLoai);
                loai.TenLoaiPhong = txtTenLoai.Text;
                loai.DonGia = int.Parse(txtDonGia.Text);
                Program.Context.SaveChanges();
                listLoaiPhong = Program.Context.tblLoaiPhongs.ToList();
                LoadDGV(listLoaiPhong);
                MessageBox.Show("Sửa thành công!");
            }
            btnXacNhan.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            txtTenLoai.ReadOnly = true;
            txtDonGia.ReadOnly = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maLoai = dgvLoaiPhong.SelectedRows[0].Cells[0].Value.ToString();
            tblLoaiPhong loai = Program.Context.tblLoaiPhongs.FirstOrDefault(l => l.MaLoaiPhong.ToString() == maLoai);
            Program.Context.tblLoaiPhongs.Remove(loai);
            Program.Context.SaveChanges();
            listLoaiPhong = Program.Context.tblLoaiPhongs.ToList();
            LoadDGV(listLoaiPhong);
            MessageBox.Show("Xóa thành công!");
        }
    }
}
