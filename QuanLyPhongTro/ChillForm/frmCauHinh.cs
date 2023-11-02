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
    public partial class frmCauHinh : Form
    {
        public frmCauHinh()
        {
            InitializeComponent();
        }

        private void frmCauHinh_Load(object sender, EventArgs e)
        {
            txtDienCu.Text = Program.Context.tblCauHinhs.FirstOrDefault().DonGiaDien.ToString();
            txtNuocCu.Text = Program.Context.tblCauHinhs.FirstOrDefault().DonGiaNuoc.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Program.Context.tblCauHinhs.FirstOrDefault().DonGiaDien = int.Parse(txtDienMoi.Text);
            Program.Context.SaveChanges();
            Program.Context.tblCauHinhs.FirstOrDefault().DonGiaNuoc = int.Parse(txtNuocMoi.Text);
            Program.Context.SaveChanges();

            MessageBox.Show("Sửa thành công!");
        }
    }
}
