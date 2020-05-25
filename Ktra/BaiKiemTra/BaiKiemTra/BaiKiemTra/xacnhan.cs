using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiKiemTra
{
    public partial class xacnhan : Form
    {
        public xacnhan()
        {
            InitializeComponent();
        }

        private void xacnhan_Load(object sender, EventArgs e)
        {
            lbTenPhim.Text = Form1.tenPhim;
            lbThoiGian.Text = Form1.thoiGian;
            lbPhong.Text = Form1.phong;
            lbKhacHang.Text = Form1.khachHang;
            lbSDT.Text = Form1.sdt;
            lbSoGhe.Text = Form1.soGhe;
            lbThanhTien.Text = Form1.thanhTien;
        }
    }
}
