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
using Net_Coffe.Form_Children;

namespace Net_Coffe.Form_Children
{
    public partial class Form_TaiKhoan : UserControl
    {
        public Form_TaiKhoan()
        {
            InitializeComponent();
           
        }
        void HienThiDanhSachTaiKhoan()
        {
            int stt = 1;
            TaiKhoanBLL tkbll = new TaiKhoanBLL();
            List<TaiKhoan> dstk = tkbll.LayToanBoTaiKhoan();
            lvTaiKhoan.Items.Clear();
            foreach (TaiKhoan tk in dstk)
            {
                ListViewItem lvi = new ListViewItem(stt + "");
                lvi.SubItems.Add(tk.TenDangNhap);
                lvi.SubItems.Add(tk.MatKhau);
                lvi.SubItems.Add(tk.NgayTao.ToString("dd/MM/yyyy"));
                lvi.SubItems.Add(tk.SoTien + "");
                lvTaiKhoan.Items.Add(lvi);
                lvi.Tag = tk;
                stt++;
            }
        }
        private void Form_TaiKhoan_Load(object sender, EventArgs e)
        {
            HienThiDanhSachTaiKhoan();
        }

        

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            using(ThemTaiKhoan ttk = new ThemTaiKhoan())
            {
                ttk.ShowDialog();
                if (ttk.XacNhan == true)
                {
                    TaiKhoan tk = new TaiKhoan();
                    tk.TenDangNhap = ttk.TenDangNhap;
                    tk.MatKhau = ttk.MatKhau;
                    tk.SoTien = ttk.SoTien;
                    TaiKhoanBLL tkbll = new TaiKhoanBLL();
                    if (tkbll.ThemTaiKhoan(tk) && tkbll.ThemMayChoTK(tk))
                    {
                        HienThiDanhSachTaiKhoan();
                        MessageBox.Show("Đã thêm tài khoản và máy cho tài khoản này");
                    }
                    else
                    {
                        MessageBox.Show("Thêm tài khoản thất bại");
                    }
                }
            }


        }

        private void sửaThôngTinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvTaiKhoan.SelectedItems[0];
                TaiKhoan tk = lvi.Tag as TaiKhoan;
                using(SuaThongTinTaiKhoan stt = new SuaThongTinTaiKhoan())
                {
                    stt.TenDangNhap = tk.TenDangNhap;
                    stt.MatKhau = tk.MatKhau;
                    stt.SoTien = tk.SoTien;
                    stt.ShowDialog();
                    if(stt.XacNhanThanhCong == true)
                    {
                        HienThiDanhSachTaiKhoan();
                    }
                }

            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 tài khoản");
            }
        }

        private void txbTimKiem_TextChanged(object sender, EventArgs e)
        {
            int stt = 1;
            TaiKhoanBLL tkbll = new TaiKhoanBLL();
            List<TaiKhoan> dstk = tkbll.LayToanBoTaiKhoan();
            lvTaiKhoan.Items.Clear();
            foreach (TaiKhoan tk in dstk)
            {
                if (tk.TenDangNhap.Contains(txbTimKiem.Text))
                {
                    ListViewItem lvi = new ListViewItem(stt + "");
                    lvi.SubItems.Add(tk.TenDangNhap);
                    lvi.SubItems.Add(tk.MatKhau);
                    lvi.SubItems.Add(tk.NgayTao.ToString("dd/MM/yyyy"));
                    lvi.SubItems.Add(tk.SoTien + "");
                    lvTaiKhoan.Items.Add(lvi);
                    lvi.Tag = tk;
                    stt++;
                }
            }
        }

        private void xóaTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvTaiKhoan.SelectedItems[0];
                TaiKhoan tk = lvi.Tag as TaiKhoan;
                TaiKhoanBLL tkbll = new TaiKhoanBLL();
                MayTinhBLL mtbll = new MayTinhBLL();
                bool kq = tkbll.XoaTaiKhoan(tk.TenDangNhap);
                mtbll.TatMayTuUser(tk.TenDangNhap);
                if (kq)
                {
                    MessageBox.Show("Xoa thanh cong");
                    
                    HienThiDanhSachTaiKhoan();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn tài khoản cần xóa");
            }
        }

        private void nạpTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvTaiKhoan.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvTaiKhoan.SelectedItems[0];
                TaiKhoan tk = lvi.Tag as TaiKhoan;
                TaiKhoanBLL tkbll = new TaiKhoanBLL();
                using(NapTien nt = new NapTien())
                {
                    tkbll.ThemMayChoTK(tk);
                    nt.TenDangNhap = tk.TenDangNhap;
                    nt.SoTienCu += tk.SoTien;
                    nt.ShowDialog();
                    if (nt.XacNhanThanhCong)
                    {
                        HienThiDanhSachTaiKhoan();
                    }
                }
            }
        }
    }
}
