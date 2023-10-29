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
        private List<tblLoaiPhong> listLoaiPhong = Program.Context.tblLoaiPhongs.Where(l => l.Hidden != 1).ToList();
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
                if (txtTenLoai.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên loại phòng!");
                    return;
                }
                if (txtDonGia.Text == "" || int.Parse(txtDonGia.Text) <= 0)
                {
                    MessageBox.Show("Vui lòng nhập đơn giá số tiền lớn hơn 0!");
                    return;
                }
                tblLoaiPhong loaiMoi = new tblLoaiPhong();
                loaiMoi.MaLoaiPhong = 1;
                loaiMoi.TenLoaiPhong = txtTenLoai.Text.Trim().Replace("  ", " ").Replace("   ", " ");
                loaiMoi.DonGia = int.Parse(txtDonGia.Text);
                Program.Context.tblLoaiPhongs.Add(loaiMoi);
                Program.Context.SaveChanges();
                listLoaiPhong.Add(loaiMoi);
                LoadDGV(listLoaiPhong);
                txtDonGia.Text = "0";
                txtTenLoai.Text = "";

                xacNhan = 0;
                btnXacNhan.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                txtTenLoai.ReadOnly = true;
                txtDonGia.ReadOnly = true;

                MessageBox.Show("Thêm thành công loại phòng!");
            }

            if (xacNhan == 2)
            {
                if (dgvLoaiPhong.SelectedRows.Count > 0)
                {
                    if (txtTenLoai.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập tên loại phòng!");
                        return;
                    }
                    if (txtDonGia.Text == "" || int.Parse(txtDonGia.Text) <= 0)
                    {
                        MessageBox.Show("Vui lòng nhập đơn giá số tiền lớn hơn 0!");
                        return;
                    }

                    string maLoaiPhong = dgvLoaiPhong.SelectedRows[0].Cells[0].Value.ToString();
                    var phongSua = Program.Context.tblLoaiPhongs.FirstOrDefault(l => l.MaLoaiPhong.ToString() == maLoaiPhong && l.Hidden != 1);
                    phongSua.TenLoaiPhong = txtTenLoai.Text;
                    phongSua.DonGia = int.Parse(txtDonGia.Text);
                    Program.Context.SaveChanges();
                    listLoaiPhong = Program.Context.tblLoaiPhongs.Where(l => l.Hidden != 1).ToList();
                    LoadDGV(listLoaiPhong);
                    txtDonGia.Text = "0";
                    txtTenLoai.Text = "";

                    xacNhan = 0;
                    btnXacNhan.Enabled = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    txtTenLoai.ReadOnly = true;
                    txtDonGia.ReadOnly = true;

                    MessageBox.Show("Cập nhật loại phòng thành công!");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn loại phòng cần sửa!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLoaiPhong.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa loại phòng này?","Cảnh báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Yes để ẩn No để xóa hẳn (tất cả các phòng thuộc loại này sẽ mất)","Cảnh báo!",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        string maLoaiPhong = dgvLoaiPhong.SelectedRows[0].Cells[0].Value.ToString();
                        var phongXoa = Program.Context.tblLoaiPhongs.FirstOrDefault(p => p.MaLoaiPhong.ToString() == maLoaiPhong);
                        phongXoa.Hidden = 1;
                        Program.Context.SaveChanges();
                        listLoaiPhong = Program.Context.tblLoaiPhongs.Where(l => l.Hidden != 1).ToList();
                        LoadDGV(listLoaiPhong);
                        txtDonGia.Text = "0";
                        txtTenLoai.Text = "";
                        MessageBox.Show("Ẩn thành công loại phòng này!");
                    }
                    else
                    {
                        string maLoaiPhong = dgvLoaiPhong.SelectedRows[0].Cells[0].Value.ToString();
                        var phongXoa = Program.Context.tblLoaiPhongs.FirstOrDefault(p => p.MaLoaiPhong.ToString() == maLoaiPhong);
                        Program.Context.tblLoaiPhongs.Remove(phongXoa);
                        Program.Context.SaveChanges();
                        listLoaiPhong = Program.Context.tblLoaiPhongs.Where(l => l.Hidden != 1).ToList();
                        LoadDGV(listLoaiPhong);
                        txtDonGia.Text = "0";
                        txtTenLoai.Text = "";
                        MessageBox.Show("Xóa thành công loại phòng này!");
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần xóa!");
            }
        }
    }
}
