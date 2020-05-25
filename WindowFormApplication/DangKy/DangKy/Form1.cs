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

namespace DangKy
{
    public partial class Form1 : Form
    {
//         static FileStream fs;
//         static StreamWriter sw;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHoantat_Click(object sender, EventArgs e)
        {

            //             fs = new FileStream("Dangky.txt", FileMode.Append, FileAccess.Write);
            //             sw = new StreamWriter(fs);
            //             sw.WriteLine(textBoxHoten.Text + "; " + textBoxLop.Text + "; " + textBoxDiachi.Text);
            //             sw.Flush();
            //             sw.Close();
            //             fs.Close();

            File.AppendAllText("DangKy.txt", textBoxHoten.Text + "; " + textBoxLop.Text + "; " + textBoxDiachi.Text + Environment.NewLine);
            MessageBox.Show("Dang ky thanh cong!", "Dang ky", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
