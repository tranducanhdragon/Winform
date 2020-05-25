using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuaHangSieuThi
{
    public partial class XacNhan : Form
    {
        public XacNhan()
        {
            InitializeComponent();
        }

        private void XacNhan_Load(object sender, EventArgs e)
        {
            labelTenKH.Text = DatHang.tenkhachhang;
            labelSDT.Text = DatHang.sodt;
            labelCam.Text = DatHang.soluongcam;
            labelNho.Text = DatHang.soluongnho;
            labelLe.Text = DatHang.soluongle;
            labelBuoi.Text = DatHang.soluongbuoi;
            labelHong.Text = DatHang.soluonghong;
            labelChuoi.Text = DatHang.soluongchuoi;
            int tien =
                (int.Parse(DatHang.soluongcam) * int.Parse(DatHang.giatiencam)
                + int.Parse(DatHang.soluongnho) * int.Parse(DatHang.giatiennho)
                + int.Parse(DatHang.soluongle) * int.Parse(DatHang.giatienle)
                + int.Parse(DatHang.soluongbuoi) * int.Parse(DatHang.giatienbuoi)
                + int.Parse(DatHang.soluonghong) * int.Parse(DatHang.giatienhong)
                + int.Parse(DatHang.soluongchuoi) * int.Parse(DatHang.giatienchuoi)
                );
            labelThanhTien.Text = tien.ToString();

        }
    }
}
