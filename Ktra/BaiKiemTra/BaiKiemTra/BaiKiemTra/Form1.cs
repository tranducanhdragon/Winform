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
    public partial class Form1 : Form
    {
        private string[] temp = { "A", "B", "C", "D", "E", "F" };
        private CheckBox[,] arr = new CheckBox[6, 16];

        public static string soGhe;
        public static string tenPhim;
        public static string thoiGian;
        public static string phong;
        public static string khachHang;
        public static string sdt;
        public static string thanhTien;


        public xacnhan xc = new xacnhan();




        public Form1()
        {
            InitializeComponent();
            VeGheNgoi();
        }

        private void VeGheNgoi()
        {
            
            Label lbMoc = new Label() { Width = 0, Height = 0, Location = new Point(30, 220) };
            for(int i = 0; i < 16; i++)
            {
                Label lb = new Label()
                {
                    Width = 25, Height = 25,
                    Location = new Point(lbMoc.Location.X + 30, lbMoc.Location.Y)

                };
                lb.Text =(i + 1).ToString();
                Controls.Add(lb);
                lbMoc.Location = new Point(lbMoc.Location.X + 25, lbMoc.Location.Y);
            }
            
            Label lbMoc2 = new Label() { Width = 0, Height = 0, Location = new Point(10, 225) };
            
            for (int i = 0; i < 6; i++)
            {
                Label lb = new Label()
                {
                    Width = 25,
                    Height = 25,
                    Location = new Point(lbMoc2.Location.X, lbMoc2.Location.Y + 25)

                };
                lb.Text = temp[i];
                Controls.Add(lb);
                lbMoc2.Location = new Point(lbMoc2.Location.X, lbMoc2.Location.Y + 25);
            }
            
           
            CheckBox cbMoc = new CheckBox() { Width = 0, Height = 0, Location = new Point(30, 250) };
            for (int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 16; j++)
                {
                    arr[i,j] = new CheckBox() {
                        Width = 25, Height = 25,
                        Location = new Point(cbMoc.Location.X + 30, cbMoc.Location.Y)
                    };
                    arr[i,j].CheckedChanged += cb_CheckedChanged;
                    Controls.Add(arr[i,j]);
                    cbMoc.Location = new Point(cbMoc.Location.X + 25, cbMoc.Location.Y);
                }
                cbMoc.Width = 0;
                cbMoc.Height = 0;
                cbMoc.Location = new Point(30, cbMoc.Location.Y + 25);
            }
        }

        void cb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comBoxChonPhim.SelectedIndex != -1)
            {
                if(comBoxChonPhim.Items[comBoxChonPhim.SelectedIndex] as string == "Iron man")
                {
                    comBoxThoiGian.Items.Clear();

                    comBoxThoiGian.Items.Add("15h30");
                    comBoxThoiGian.Items.Add("17h30");
                    comBoxThoiGian.Items.Add("19h30");

                    comBoxPhong.Items.Clear();

                    comBoxPhong.Items.Add("1");
                    comBoxPhong.Items.Add("2");
                    comBoxPhong.Items.Add("6");
                }
                if (comBoxChonPhim.Items[comBoxChonPhim.SelectedIndex] as string == "Anh thay ngoi sao")
                {
                    comBoxThoiGian.Items.Clear();
                    comBoxThoiGian.Items.Add("16h00");
                    comBoxThoiGian.Items.Add("18h00");
                    comBoxPhong.Items.Clear();
                    comBoxPhong.Items.Add("3");
                    comBoxPhong.Items.Add("4");
                }
                if (comBoxChonPhim.Items[comBoxChonPhim.SelectedIndex] as string == "Gone with the wind")
                {
                    comBoxThoiGian.Items.Clear();
                    comBoxThoiGian.Items.Add("17h00");
                    comBoxThoiGian.Items.Add("19h00");
                    comBoxPhong.Items.Clear();
                    comBoxPhong.Items.Add("5");
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for(int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 16; j++)
                {
                    if(arr[i,j].Checked == true)
                    {
                        dem++;
                        soGhe +=", "+ temp[i] + j.ToString(); 
                    }
                }
            }
            tenPhim = comBoxChonPhim.Items[comBoxChonPhim.SelectedIndex] as string;
            thoiGian = comBoxThoiGian.Items[comBoxThoiGian.SelectedIndex] as string;
            phong= comBoxPhong.Items[comBoxPhong.SelectedIndex] as string;
            khachHang = txbTenKhach.Text;
            sdt = txbSDT.Text;
            thanhTien = (70000 * dem).ToString() + "vnd";
            xc.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
