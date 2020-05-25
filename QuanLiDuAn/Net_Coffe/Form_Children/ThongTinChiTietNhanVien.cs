using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DTO;
using BLL;
namespace Net_Coffe.Form_Children
{
    public partial class ThongTinChiTietNhanVien : Form
    {
        public string MaNV;
        public string TenNV;
        public string QueQuan;
        public DateTime NgaySinh;
        public string ChucVu;
        public DateTime NgayVaoLam;
        public int HeSoLuong;
        public string HinhAnh="";
        public bool XacNhanThanhCong = false;
        public ThongTinChiTietNhanVien()
        {
            InitializeComponent();
            pnAnh.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
                openFile.FilterIndex = 1;
                openFile.RestoreDirectory = true;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    txbLink.Text = openFile.FileName;
                }
                HinhAnh = Convert.ToBase64String(converImgToByte());
                pictureBox1.Image = new Bitmap(ByteToImg(HinhAnh));
            }
            catch
            {

            }
            
        }
        private byte[] converImgToByte()
        {
            FileStream fs;
            fs = new FileStream(txbLink.Text, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
        private Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString); // chuyển string thành mảng byte
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NhanVienBLL nvb = new NhanVienBLL();
            int heso;
            if(Int32.TryParse(txbHeSoLuong.Text,out heso)){
                if (nvb.SuaNhanVien(MaNV, txbTenNV.Text, txbQueQuan.Text, txbChucVu.Text, heso, HinhAnh))
                {
                    MessageBox.Show("Sửa thông tin thành công");
                    XacNhanThanhCong = true;
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin thất bại");
                }
            }
            else
            {
                MessageBox.Show("Hệ số lương phải là số");
            }

            
        }

        private void ThongTinChiTietNhanVien_Load(object sender, EventArgs e)
        {
            txbTenNV.Text = TenNV;
            txbQueQuan.Text = QueQuan;
            lbNgaySinh.Text = NgaySinh.ToString("dd/MM/yyyy");
            txbChucVu.Text = ChucVu;
            lbNgayVaoLam.Text = NgayVaoLam.ToString("dd/MM/yyyy");
            txbHeSoLuong.Text = HeSoLuong+"";
            if(HinhAnh != "")
            {
                pictureBox1.Image = new Bitmap(ByteToImg(HinhAnh));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(pnAnh.Visible == true)
            {
                pnAnh.Visible = false;
            }
            else
            {
                pnAnh.Visible = true;
            }
            
        }
    }
}
