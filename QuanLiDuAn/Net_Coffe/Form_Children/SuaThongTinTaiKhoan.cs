using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Net_Coffe.Form_Children
{
    public partial class SuaThongTinTaiKhoan : Form
    {
        public string TenDangNhap;
        public string MatKhau;
        public int SoTien;
        public bool XacNhanThanhCong = false;
        public SuaThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            TaiKhoanBLL tkb = new TaiKhoanBLL();
            MayTinhBLL mtbll = new MayTinhBLL();
            int sotien;
            if(Int32.TryParse(txbSoTien.Text,out sotien))
            {
                if (tkb.SuaThongTinTaiKhoan(TenDangNhap, txbMatKhau.Text, sotien))
                {
                    mtbll.UpDateGioChoi(TenDangNhap, Convert.ToString((sotien) / 5000));
                    MessageBox.Show("Sửa thành công");
                    XacNhanThanhCong = true;
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại số tiền");
            }
            
        }

        private void SuaThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            lbTenDangNhap.Text = TenDangNhap;
            txbMatKhau.Text = MatKhau;
            txbSoTien.Text = SoTien + "";
        }
    }
}
