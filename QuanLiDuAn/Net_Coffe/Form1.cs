using Net_Coffe.Form_Children;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Net_Coffe
{
    public partial class Form1 : Form
    {
        int PanelWith;
        bool ThuNhoMenu;
        public Form1()
        {
            InitializeComponent();
            PanelWith = panelLeft.Width;
            ThuNhoMenu = false;
            Form_PhongMay temp = new Form_PhongMay();
            AddControlsToPanel(temp);
            timer2.Start();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ThuNhoMenu)
            {
                panelLeft.Width += 15;
                if(panelLeft.Width >= PanelWith)
                {
                    timer1.Stop();
                    ThuNhoMenu = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width -= 15;
                if(panelLeft.Width <= 78)
                {
                    timer1.Stop();
                    ThuNhoMenu = true;
                    this.Refresh();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnTaiKhoan);
            Form_TaiKhoan temp = new Form_TaiKhoan();
            AddControlsToPanel(temp);
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnDichVu);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnNhanVien);
            Form_NhanVien temp = new Form_NhanVien();
            AddControlsToPanel(temp);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnDoanhThu);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbDongHo.Text = dt.ToString("HH:MM:ss");
        }

        private void btnPhongMay_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnPhongMay);
            Form_PhongMay temp = new Form_PhongMay();
            AddControlsToPanel(temp);
        }
    }
}
