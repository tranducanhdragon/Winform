using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTap
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void buttonDangKy_Click(object sender, EventArgs e)
        {
            string gioitinh = "";
            if(radioButtonNam.Checked == true)
            {
                gioitinh = "nam";
            }
            if(radioButtonNu.Checked == true)
            {
                gioitinh = "nu";
            }
            listBoxMaSV.Items.Add(textBoxMaSV.Text);
            
            File.AppendAllText("DuLieu.txt", textBoxMaSV.Text +"; "+ textBoxHoTen.Text + "; " + textBoxMaLop.Text + "; " +
                gioitinh + "; " + textBoxDiaChi.Text + "; " + dateTimePickerNgaySinh.Text + Environment.NewLine);
            MessageBox.Show("Dang ky thanh cong!");
        }
        private void CapNhap()
        {
            textBoxHoTen.Text = "";
            textBoxMaLop.Text = "";
            textBoxDiaChi.Text = "";
            textBoxMaSV.Text = "";
            radioButtonNam.Checked = false;
            radioButtonNu.Checked = false;
            dateTimePickerNgaySinh.ResetText();
        }
        private void buttonThemmoi_Click(object sender, EventArgs e)
        {
            CapNhap();
        }
    }
}
