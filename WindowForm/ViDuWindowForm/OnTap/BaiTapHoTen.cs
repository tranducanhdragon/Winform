using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTap
{
    public partial class BaiTapHoTen : Form
    {
        public BaiTapHoTen()
        {
            InitializeComponent();
        }

        private void button_ho_Click(object sender, EventArgs e)
        {
            label_full.Text = textBox_ho.Text;
        }

        private void button_ten_Click(object sender, EventArgs e)
        {
            label_full.Text = textBox_ten.Text;
        }

        private void button_hovaten_Click(object sender, EventArgs e)
        {
            label_full.Text = textBox_ho.Text + " " + textBox_ten.Text;
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Ban co chac chan muon thoat",
                "Thoat chuong trinh",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if( ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BaiTapHoTen_Load(object sender, EventArgs e)
        {
            rbtn_black.Checked = true;
            textBox_ho.Focus();
        }

        private void rbtn_red_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_red.Checked == true)
            {
                label_full.ForeColor = rbtn_red.ForeColor;
            }
        }

        private void rbtn_green_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_green.Checked == true)
            {
                label_full.ForeColor = rbtn_green.ForeColor;
            }
        }

        private void rbtn_blue_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_blue.Checked == true)
            {
                label_full.ForeColor = rbtn_blue.ForeColor;
            }
        }

        private void rbtn_black_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_black.Checked == true)
            {
                label_full.ForeColor = rbtn_black.ForeColor;
            }
        }

        private void ckb_bold_CheckedChanged(object sender, EventArgs e)
        {


            label_full.Font = new Font(label_full.Font.Name, label_full.Font.Size,
              label_full.Font.Style ^ FontStyle.Bold);

        }

        private void ckb_italic_CheckedChanged(object sender, EventArgs e)
        {

            label_full.Font = new Font(label_full.Font.Name, label_full.Font.Size,
              label_full.Font.Style^FontStyle.Italic);

        }

        private void ckb_underline_CheckedChanged(object sender, EventArgs e)
        {

            label_full.Font = new Font(label_full.Font.Name, label_full.Font.Size,
                label_full.Font.Style^FontStyle.Underline);
        }
    }
}
