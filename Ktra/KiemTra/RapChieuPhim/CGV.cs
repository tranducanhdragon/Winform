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
    public partial class CGV : Form
    {
        public static List<string> cho_ngoi = new List<string>();
        XacNhan xn = new XacNhan();
        public CGV()
        {
            InitializeComponent();
        }

        private void buttonDatVe_Click(object sender, EventArgs e)
        {
            foreach(Control c in groupBoxChoNgoi.Controls)
            {
                if(c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (cb.Checked)
                    {
                        cho_ngoi.Add( cb.Name.ToString());
                    }
                    
                }
            }
            xn.Show();

        }

        private void groupBoxChoNgoi_Enter(object sender, EventArgs e)
        {
            int i = 1;//number of row
            int j = 16;//number of column
            int column_at = 1;
            foreach (Control c in groupBoxChoNgoi.Controls)
            {
                if (c is CheckBox)
                {
                    if (i % 5 == 1)
                    {
                        c.Name = "E" + j.ToString();
                    }
                    if (i % 5 == 2)
                    {
                        c.Name = "D" + j.ToString();
                    }
                    if (i % 5 == 3)
                    {
                        c.Name = "C" + j.ToString();
                    }
                    if (i % 5 == 4)
                    {
                        c.Name = "B" + j.ToString();
                    }
                    if (i % 5 == 0)
                    {
                        c.Name = "A" + j.ToString();
                    }
                    i++;
                    if(i > 5*column_at)
                    {
                        j--;
                        column_at++;
                    }
                }
            }
        }
    }
}
