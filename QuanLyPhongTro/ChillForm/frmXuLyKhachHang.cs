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
    public partial class frmXuLyKhachHang : Form
    {

        public frmXuLyKhachHang(bool them)
        {
           
            InitializeComponent();
            LoadForm();
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            foreach (var c in txtCCCD.Text)
            {
                if (!Char.IsDigit(c))
                {
                    MessageBox.Show("Chỉ bao gồm số!");
                    txtCCCD.Text = "";
                    return;
                }
            }
        }

        private void LoadForm()
        {
            
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
