using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace Net_Coffe.Form_Children
{
    public partial class Form_NhanVien : UserControl
    {
        public Form_NhanVien()
        {
            InitializeComponent();
        }

        void HienThiToanBoNhanVien()
        {
            int stt = 1;
            NhanVienBLL nvb = new NhanVienBLL();
            List<NhanVien> dsNV = new List<NhanVien>();
            dsNV = nvb.LayToanBoNhanVien();
            lvNhanVien.Items.Clear();
            foreach (NhanVien nv in dsNV)
            {
                ListViewItem lvi = new ListViewItem(stt + "");
                lvi.SubItems.Add(nv.MaNV);
                lvi.SubItems.Add(nv.TenNV);
                lvi.SubItems.Add(nv.ChucVu);
                lvi.SubItems.Add(nv.HeSoLuong + "");
                lvNhanVien.Items.Add(lvi);
                lvi.Tag = nv;
                stt++;
            }
        }

        private void Form_NhanVien_Load(object sender, EventArgs e)
        {
            HienThiToanBoNhanVien();
        }

       

        private void thôngTinChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (lvNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvNhanVien.SelectedItems[0];
                NhanVien nv = lvi.Tag as NhanVien;
                using (ThongTinChiTietNhanVien temp = new ThongTinChiTietNhanVien())
                {
                    temp.MaNV = nv.MaNV;
                    temp.TenNV = nv.TenNV;
                    temp.QueQuan = nv.QueQuan;
                    temp.NgaySinh = nv.NgaySinh;
                    temp.ChucVu = nv.ChucVu;
                    temp.NgayVaoLam = nv.NgayVaoLam;
                    temp.HeSoLuong = nv.HeSoLuong;
                    temp.HinhAnh = nv.HinhAnh;
                    temp.ShowDialog();
                    if (temp.XacNhanThanhCong)
                    {
                        HienThiToanBoNhanVien();
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 nhân viên");
            }
        }

        private void xóaNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvNhanVien.SelectedItems[0];
                NhanVien nv = lvi.Tag as NhanVien;
                NhanVienBLL nvb = new NhanVienBLL();
                if(nvb.XoaNhanVien(nv.MaNV) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    HienThiToanBoNhanVien();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }

            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 nhân viên");
            }
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            using(ThemNhanVien temp = new ThemNhanVien())
            {
                temp.ShowDialog();
                if (temp.XacNhanThanhCong)
                {
                    HienThiToanBoNhanVien();
                }
            }
        }
    }
}
