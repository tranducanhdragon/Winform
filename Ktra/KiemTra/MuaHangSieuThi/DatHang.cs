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
    public partial class DatHang : Form
    {
        public static string tenkhachhang;
        public static string sodt;
        public static string giatiencam = "0";
        public static string giatiennho = "0";
        public static string giatienle = "0";
        public static string giatienbuoi = "0";
        public static string giatienhong = "0";
        public static string giatienchuoi = "0";
        public static string soluongcam = "0";
        public static string soluongnho = "0";
        public static string soluongle = "0";
        public static string soluongbuoi = "0";
        public static string soluonghong = "0";
        public static string soluongchuoi = "0";
        public static XacNhan xn = new XacNhan();
        public DatHang()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tenkhachhang = textBoxTenKH.Text;
            sodt = textBoxSDT.Text;
            xn.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxChonTraiCay.Text == "Cam")
            {
                if (comboBoxXuatXu.SelectedItem.ToString() == "Hà Giang")
                {
                    giatiencam = "5000";
                    labelGiaTien.Text = giatiencam;
                    soluongcam = numericUpDownSoLuong.Value.ToString();
                }

                else if (comboBoxXuatXu.SelectedItem.ToString() == "Hàn Quốc")
                {
                    giatiencam = "9000";
                    labelGiaTien.Text = giatiencam;
                    soluongcam = numericUpDownSoLuong.Value.ToString();
                }

                else
                {
                    giatiencam = "0";
                    labelGiaTien.Text = giatiencam;
                }
                    
            }
            if (comboBoxChonTraiCay.Text == "Nho")
            {
                if (comboBoxXuatXu.Text == "Mỹ")
                {
                    giatiennho = "100000";
                    labelGiaTien.Text = giatiennho;
                    soluongnho = numericUpDownSoLuong.Value.ToString();
                }
                    
                else if (comboBoxXuatXu.Text == "Miền Nam")
                {
                    giatiennho = "70000";
                    labelGiaTien.Text = giatiennho;
                    soluongnho = numericUpDownSoLuong.Value.ToString();
                }
                    
                else if (comboBoxXuatXu.Text == "Hàn Quốc")
                {
                    giatiennho = "120000";
                    labelGiaTien.Text = giatiennho;
                    soluongnho = numericUpDownSoLuong.Value.ToString();
                }

                else
                {
                    giatiennho = "0";
                    labelGiaTien.Text = giatiennho;
                }
                    
            }
            if (comboBoxChonTraiCay.Text == "Lê")
            {
                if (comboBoxXuatXu.Text == "Đà Lạt")
                {
                    giatienle = "20000";
                    labelGiaTien.Text = giatienle;
                    soluongle = numericUpDownSoLuong.Value.ToString();
                }

                else
                {
                    giatienle = "0";
                    labelGiaTien.Text = giatienle;
                }
                    
            }
            if (comboBoxChonTraiCay.Text == "Bưởi")
            {
                if (comboBoxXuatXu.Text == "Năm Roi")
                {
                    giatienbuoi = "60000";
                    labelGiaTien.Text = giatienbuoi;
                    soluongbuoi = numericUpDownSoLuong.Value.ToString();
                }
                    
                else if (comboBoxXuatXu.Text == "Diễn")
                {
                    giatienbuoi = "50000";
                    labelGiaTien.Text = giatienbuoi;
                    soluongbuoi = numericUpDownSoLuong.Value.ToString();
                }

                else
                {
                    giatienbuoi = "0";
                    labelGiaTien.Text = giatienbuoi;
                }
                    
            }
            if (comboBoxChonTraiCay.Text == "Hồng")
            {
                if (comboBoxXuatXu.Text == "Đà Lạt")
                {
                    giatienhong = "10000";
                    labelGiaTien.Text = giatienhong;
                    soluonghong = numericUpDownSoLuong.Value.ToString();
                }

                else
                {
                    giatienhong = "0";
                    labelGiaTien.Text = giatienhong;
                }
                    
            }
            if (comboBoxChonTraiCay.Text == "Chuối")
            {
                if (comboBoxXuatXu.Text == "Mỹ")
                {
                    giatienchuoi = "7000";
                    labelGiaTien.Text = giatienchuoi;
                    soluongchuoi = numericUpDownSoLuong.Value.ToString();
                }
                    
                else if (comboBoxXuatXu.Text == "Philippine")
                {
                    giatienchuoi = "5000";
                    labelGiaTien.Text = giatienchuoi;
                    soluongchuoi = numericUpDownSoLuong.Value.ToString();
                }

                else
                {
                    giatienchuoi = "0";
                    labelGiaTien.Text = giatienchuoi;
                }
                    
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBoxCam.Checked = false;
            checkBoxNho.Checked = false;
            checkBoxLe.Checked = false;
            checkBoxBuoi.Checked = false;
            checkBoxHong.Checked = false;
            checkBoxChuoi.Checked = false;
        }

        private void comboBoxChonTraiCay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxChonTraiCay.Text == "Cam")
            {
                comboBoxXuatXu.Items.Clear();
                comboBoxXuatXu.Items.Add("Hà Giang");
                comboBoxXuatXu.Items.Add("Hàn Quốc");
            }
            if (comboBoxChonTraiCay.Text == "Nho")
            {
                comboBoxXuatXu.Items.Clear();
                comboBoxXuatXu.Items.Add("Mỹ");
                comboBoxXuatXu.Items.Add("Miền Nam");
                comboBoxXuatXu.Items.Add("Hàn Quốc");
            }
            if (comboBoxChonTraiCay.Text == "Lê")
            {
                comboBoxXuatXu.Items.Clear();
                comboBoxXuatXu.Items.Add("Đà Lạt");
            }
            if (comboBoxChonTraiCay.Text == "Bưởi")
            {
                comboBoxXuatXu.Items.Clear();
                comboBoxXuatXu.Items.Add("Năm Roi");
                comboBoxXuatXu.Items.Add("Diễn");
            }
            if (comboBoxChonTraiCay.Text == "Hồng")
            {
                comboBoxXuatXu.Items.Clear();
                comboBoxXuatXu.Items.Add("Đà Lạt");
            }
            if (comboBoxChonTraiCay.Text == "Chuối")
            {
                comboBoxXuatXu.Items.Clear();
                comboBoxXuatXu.Items.Add("Mỹ");
                comboBoxXuatXu.Items.Add("Philippine");
            }
        }
    }
}
