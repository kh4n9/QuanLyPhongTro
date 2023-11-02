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
    public partial class frmDienNuoc : Form
    {
        private object maHopDong;
        public frmDienNuoc(object maHopDong)
        {
            InitializeComponent();
            this.maHopDong = maHopDong;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            Program.Context.tblChiTietHopDongs.Where(c => c.MaHopDong.ToString() == maHopDong.ToString()).OrderByDescending(c => c.MaCTHopDong).FirstOrDefault().CSD_Moi = int.Parse(txtSoDienMoi.Text);
            Program.Context.SaveChanges();
            Program.Context.tblChiTietHopDongs.Where(c => c.MaHopDong.ToString() == maHopDong.ToString()).OrderByDescending(c => c.MaCTHopDong).FirstOrDefault().CSN_Moi = int.Parse(txtSoNuocMoi.Text);

            Program.Context.SaveChanges();

            this.Close();
        }
    }
}
