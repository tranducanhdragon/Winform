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
    public partial class Form1 : Form
    {
        string strcon = "Data Source= COMPUTER-PC\\SQLEXPRESS; Initial Catalog = CSDL_C#; Integrated Security = True;";
        SqlConnection conn = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDemSP(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.ConnectionString = strcon;
                conn.Open();
            }
            
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string cmd = "select count(*) from SanPham";
            command.Connection = conn;
            command.CommandText = cmd;
            int so_sp = (int)command.ExecuteScalar();
            label5.Text = so_sp.ToString() + " sản phẩm";
            conn.Close();
        }

        private void buttonChiTietSP_Click(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.ConnectionString = strcon;
                conn.Open();
            }
            SqlCommand comd = new SqlCommand();
            comd.CommandType = CommandType.Text;
            comd.CommandText = "select * from SanPham where Ma = @ma";
            comd.Connection = conn;
            SqlParameter para = new SqlParameter("@ma", SqlDbType.Int);
            para.Value = textBoxNhapMaSP.Text;
            comd.Parameters.Add(para);
            SqlDataReader reader = comd.ExecuteReader();
            if (reader.Read())
            {
                textBoxMaSP.Text = reader.GetInt32(0).ToString();
                textBoxTenSP.Text = reader.GetSqlString(1).ToString();
                textBoxDonGia.Text = reader.GetInt32(2).ToString();
            }
            reader.Close();
            conn.Close();
        }

        private void buttonDSSanPham_Click(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.ConnectionString = strcon;
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from SanPham where Ma = @ma";
            SqlParameter para = new SqlParameter("@ma", SqlDbType.Int);
            para.Value = textBoxNhapMaSP.Text;
            cmd.Parameters.Add(para);
            SqlDataReader rd = cmd.ExecuteReader();
            listView1.Items.Clear();
            while (rd.Read())
            {
                ListViewItem li = new ListViewItem(rd.GetInt32(0).ToString());
                li.SubItems.Add(rd.GetString(1).ToString());
                li.SubItems.Add(rd.GetInt32(2).ToString());

                listView1.Items.Add(li);
            }  

            rd.Close();
            conn.Close();
        }
    }
}
