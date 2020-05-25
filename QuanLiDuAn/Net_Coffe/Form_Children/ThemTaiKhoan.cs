using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Net_Coffe.Form_Children
{
    public partial class ThemTaiKhoan : Form
    {
        public string TenDangNhap;
        public string MatKhau;
        public int SoTien;
        public bool XacNhan;
        public ThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            XacNhan = true;
            TenDangNhap = txbTenDangNhap.Text;
            MatKhau = txbMatKhau.Text;
            int Sotien;
            if (Int32.TryParse(txbSoTien.Text, out Sotien))
            {
                SoTien = Sotien;
            }
            this.Dispose();
        }
    }
}
