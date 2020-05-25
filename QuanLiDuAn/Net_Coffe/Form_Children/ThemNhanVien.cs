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
    public partial class ThemNhanVien : Form
    {
        string HinhAnh="";
        public bool XacNhanThanhCong = false;
        public ThemNhanVien()
        {
            InitializeComponent();
            pnAnh.Visible = true;
        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void button2_Click(object sender, EventArgs e)
        {
            NhanVienBLL nvb = new NhanVienBLL();
            int heso;
            DateTime NgaySinh;
            if (Int32.TryParse(txbHeSoLuong.Text, out heso) && DateTime.TryParse(txbNgaySinh.Text,out NgaySinh))
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = txbMaNV.Text;
                nv.TenNV = txbTenNV.Text;
                nv.QueQuan = txbQueQuan.Text;
                nv.NgaySinh = NgaySinh;
                nv.ChucVu = txbChucVu.Text;
                nv.HeSoLuong = heso;
                nv.HinhAnh = HinhAnh;
                if (nvb.ThemNhanVien(nv))
                {
                    MessageBox.Show("Thêm nhân viên thành công");
                    XacNhanThanhCong = true;
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại");
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại hệ số lương hoặc ngày sinh");
            }
        }
    }
}
