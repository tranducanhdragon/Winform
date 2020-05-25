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
    public partial class NapTien : Form
    {
        public string TenDangNhap;
        public int SoTienCu;
        public bool XacNhanThanhCong = false;
        public NapTien()
        {
            InitializeComponent();
        }

        private void NapTien_Load(object sender, EventArgs e)
        {
            lbTenDangNhap.Text = TenDangNhap;
        }

        private void nbSoGio_ValueChanged(object sender, EventArgs e)
        {
            lbSoTien.Text = (nbSoGio.Value * 5000).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            TaiKhoanBLL tkb = new TaiKhoanBLL();
            MayTinhBLL mtbll = new MayTinhBLL();
            if (tkb.NapThemTien(TenDangNhap, SoTienCu + Int32.Parse(lbSoTien.Text)))
            {
                mtbll.UpDateGioChoi(TenDangNhap, Convert.ToString((SoTienCu/5000) + nbSoGio.Value));
                MessageBox.Show("Nạp thêm thành công");
                XacNhanThanhCong = true;
            }
            else
            {
                MessageBox.Show("Nạp thêm thất bại");
            }
            this.Dispose();
        }
    }
}
