using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapChieuPhim
{
    public partial class XacNhan : Form
    {
        public XacNhan()
        {
            InitializeComponent();
        }

        private void XacNhan_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < CGV.cho_ngoi.Count; i++)
            {
                labelSoGhe.Text += CGV.cho_ngoi[i]+" ";
            }
        }
    }
}
