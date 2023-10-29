using QuanLyPhongTro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro.ChillForm
{
    public partial class frmDichVu : Form
    {
        List<tblDichVu> listDichVu = Program.Context.tblDichVus.Where(d => d.Hidden != 1).ToList();
        private bool Them;

        public frmDichVu()
        {
            InitializeComponent();
            LoadDGV(listDichVu);
        }

        private void LoadDGV(List<tblDichVu> listDichVu)
        {
            dgvShow.Rows.Clear();
            foreach (var item in listDichVu)
            {
                int index = dgvShow.Rows.Add();
                dgvShow.Rows[index].Cells[0].Value = item.MaDichVu;
                dgvShow.Rows[index].Cells[1].Value = item.TenDichVu;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTen.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            this.Them = true;
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            if (txtTen.Text.Length > 0)
            {
                btnXacNhan.Enabled = true;
            }
            else
            {
                btnXacNhan.Enabled = false;
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTen.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            this.Them = false;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (this.Them)
            {
                if (listDichVu.Where(d => d.TenDichVu.ToString() == txtTen.Text).ToList().Count > 0)
                {
                    MessageBox.Show("Tên dịch vụ này đã tồn tại!");
                    return;
                }
                tblDichVu dichVuMoi = new tblDichVu();
                dichVuMoi.MaDichVu = 1;
                dichVuMoi.TenDichVu = txtTen.Text;
                Program.Context.tblDichVus.Add(dichVuMoi);
                Program.Context.SaveChanges();
                listDichVu.Add(dichVuMoi);
                LoadDGV(listDichVu);
                txtTen.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtTen.Text = "";
                MessageBox.Show("Thêm dịch vụ thành công!");
            }
            else
            {
                if (dgvShow.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần sửa!");
                    return;
                }
                var dichVuCanSua = listDichVu.FirstOrDefault(d => d.MaDichVu.ToString() == (dgvShow.SelectedRows[0].Cells[0].Value.ToString()));
                dichVuCanSua.TenDichVu = txtTen.Text;
                Program.Context.SaveChanges();
                LoadDGV(listDichVu);
                txtTen.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtTen.Text = "";
                MessageBox.Show("Sửa dịch vụ thành công!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvShow.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa!");
                return;
            }

            var dichVuCanXoa = listDichVu.FirstOrDefault(d => d.MaDichVu.ToString() == (dgvShow.SelectedRows[0].Cells[0].Value.ToString()));

            if (MessageBox.Show("Yes để ẩn dịch vụ, No để xóa hoàn toàn dịch vụ này và những thứ có liên quan cũng sẽ biến mất!!","Cảnh báo!",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dichVuCanXoa.Hidden = 1;
                Program.Context.SaveChanges();
                listDichVu = listDichVu.Where(d => d.Hidden != 1).ToList();
                LoadDGV(listDichVu);
                MessageBox.Show("Ản dịch vụ khỏi hệ thống thành công!");
            }
            else
            {
                Program.Context.tblDichVus.Remove(dichVuCanXoa);
                Program.Context.SaveChanges();
                listDichVu = Program.Context.tblDichVus.Where(d => d.Hidden != 1).ToList();
                LoadDGV(listDichVu);
                MessageBox.Show("Xóa dịch vụ khỏi hệ thống thành công!");
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            List<tblDichVu> listDichVu = this.listDichVu.ToList();
            if (txtTim.Text.Length == 0)
            {
                LoadDGV(this.listDichVu);
            }
            else
            {
                listDichVu = listDichVu.Where(d => d.TenDichVu.ToString().Contains(txtTim.Text)).ToList();
                LoadDGV(listDichVu);
            }
        }
    }
}
