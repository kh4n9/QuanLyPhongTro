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
            LoadDGV(listPhong);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmXuLyPhong frmXuLyPhong = new frmXuLyPhong(true);
            frmXuLyPhong.ShowDialog();
            listPhong = Program.Context.tblPhongs.ToList();
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
                dgvPhong.Rows[index].Cells[2].Value = item.tblLoaiPhong.TenLoaiPhong;
                dgvPhong.Rows[index].Cells[3].Value = item.TinhTrang==1?"Đang thuê":"Chưa thuê";
            }

            dgvPhong.Columns[0].Width = 100;
            dgvPhong.Columns[0].HeaderText = "Mã phòng";
            dgvPhong.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvPhong.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPhong.Columns[1].HeaderText = "Tên phòng";

            dgvPhong.Columns[2].Width = 200;
            dgvPhong.Columns[2].HeaderText = "Loại Phòng";
            
            dgvPhong.Columns[3].Width = 200;
            dgvPhong.Columns[3].HeaderText = "Tình trạng";

            dgvPhong.Columns[4].Visible = false;

            dgvPhong.Columns[5].Visible = false;
        }
    }
}
