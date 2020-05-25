using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetNoiCSDL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cs = "Data Source = COMPUTER-PC\\SQLEXPRESS ;Database = SinhVien; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select * from " + "SinhVien", conn);

            try
            {
                conn.Open();
                MessageBox.Show("Ket noi thanh cong");
                SqlDataReader sdr = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = sdr;

                dataGridView1.DataSource = source;
            }
            catch
            {
                MessageBox.Show("Khong thanh cong");
            }
        }
    }
}
