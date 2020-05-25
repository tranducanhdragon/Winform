using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViDuWizard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban da chon Yes");   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Application.ExecutablePath;
            MessageBox.Show(path);
            Application.Exit();
        }
    }
}
