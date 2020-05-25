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
    public partial class Form_PhongMay : UserControl
    {
        public Form_PhongMay()
        {
            InitializeComponent();

        }
        void HienThiDanhSachMayTinh()
        {
            int stt = 1;
            MayTinhBLL mtbll = new MayTinhBLL();
            List<MayTinh> dsmt = mtbll.LayToanBoMayTinh();
            lvPhongMay.Items.Clear();
            foreach (MayTinh mt in dsmt)
            {
                ListViewItem lvi = new ListViewItem(stt + "");
                lvi.SubItems.Add(mt.MaMay);
                lvi.SubItems.Add(mt.TinhTrang);
                lvi.SubItems.Add(mt.TenDangNhap);
                if(mt.SoGioOnline[0] == '-' || Char.IsNumber(mt.SoGioOnline[0]))
                {
                    lvi.SubItems.Add((Convert.ToInt32(mt.SoGioOnline)*3600).ToString());
                }
                else
                {
                    lvi.SubItems.Add(mt.SoGioOnline);
                }
                lvPhongMay.Items.Add(lvi);
                lvi.Tag = mt;
                stt++;
            }
        }

        private void Form_PhongMay_Load(object sender, EventArgs e)
        {
            HienThiDanhSachMayTinh();
            timer3.Start();
        }

        private void tắtMáyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvPhongMay.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvPhongMay.SelectedItems[0];
                MayTinh mt = lvi.Tag as MayTinh;
                MayTinhBLL mtb = new MayTinhBLL();
                TaiKhoanBLL tkbll = new TaiKhoanBLL();
                if (mtb.TatMay(mt.MaMay))
                {
                    tkbll.UpdateTienSauKhiTatMay(mt.TenDangNhap, Convert.ToInt32(mt.SoGioOnline)*5000);
                    MessageBox.Show("Tắt máy thành công");
                    HienThiDanhSachMayTinh();
                }
                else
                {
                    MessageBox.Show("Tắt máy thất bại");
                }
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < lvPhongMay.Items.Count; i++)
            {
                string s_giay = lvPhongMay.Items[i].SubItems[4].Text;
                if (s_giay[0] == '-' || Char.IsNumber(s_giay[0])) {
                    int giay = Convert.ToInt32(s_giay);
                    giay--;
                    lvPhongMay.Items[i].SubItems[4].Text = giay.ToString();
                }
            }
        }
    }
}
