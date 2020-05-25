using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CSDL_OnTap
{
    public partial class Form2 : Form
    {
        static string strcon = "Data Source= COMPUTER-PC\\SQLEXPRESS; Initial Catalog = CSDL_C#; Integrated Security = True;";
        SqlConnection con = new SqlConnection();
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Closed)
            {
                con.ConnectionString = strcon;
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from DanhMuc";
            cmd.Connection = con;
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string line = rd.GetInt32(0).ToString() + '-' + rd.GetString(1).ToString();
                listBoxDSDanhMuc.Items.Add(line);
            }
            rd.Close();
            con.Close();
        }

        private void listBoxDSDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxDSDanhMuc.SelectedIndex == -1)
            {
                return;
            }
            string chonsp = listBoxDSDanhMuc.SelectedItem.ToString();
            string[] arr = chonsp.Split('-');
            int chon_madmsp = int.Parse(arr[0]);

            if(con.State == ConnectionState.Closed)
            {
                con.ConnectionString = strcon;
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "select * from SanPham where MaDanhMuc = @madm";
            SqlParameter para = new SqlParameter("@madm", SqlDbType.Int);
            para.Value = chon_madmsp;
            cmd.Parameters.Add(para);
            SqlDataReader rd = cmd.ExecuteReader();

            listViewDSSanPham.Items.Clear();
            while (rd.Read())
            {
                ListViewItem li = new ListViewItem(rd.GetInt32(0).ToString());
                li.SubItems.Add(rd.GetString(1));
                li.SubItems.Add(rd.GetInt32(2).ToString());
                listViewDSSanPham.Items.Add(li);
            }
            rd.Close();
            con.Close();
        }
    }
}
