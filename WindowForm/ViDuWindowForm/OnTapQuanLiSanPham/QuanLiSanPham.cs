using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapQuanLiSanPham
{
    public partial class QuanLiSanPham : Form
    {
        public QuanLiSanPham()
        {
            InitializeComponent();
        }

        private void buttonDanhMuc_Click(object sender, EventArgs e)
        {
            DanhMuc frmDanhMuc = new DanhMuc;
            if(frmDanhMuc.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
