using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLThuVien.Models;
using System.Data.SqlClient;

namespace QLThuVien.Views
{
    public partial class frmDangKi : DevExpress.XtraEditors.XtraForm
    {
        public frmDangKi()
        {
            InitializeComponent();
        }
        Database db = new Database();

        private void btOk_Click(object sender, EventArgs e)
        {
            string username = tbTaiKhoan.Text;
            string password = tbMatKhau.Text;
            string cfpassword = tbNhapLai.Text;
            SqlCommand command = new SqlCommand();
            if (username == "" || password == "" || cfpassword == "")
            {
                XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            command.CommandText = "select * from [User] where username = '" + username + "'";
            string result = (string)db.executeSelectQuery(command);
            if (result == username)
            {
                XtraMessageBox.Show("Đã tồn tại username ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password != cfpassword)
            {
                XtraMessageBox.Show("Mật khẩu xác nhận không đúng ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            command.CommandText = "insert into [User](username,password) values('" + username + "','" + password + "')";
            int rs = db.executeQuery(command);
            if (rs != 0)
            {
                DialogResult log = XtraMessageBox.Show("Đăng ký thông tin tài khoản thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (log == DialogResult.OK)
                {
                    Hide();
                    frmLogin form = new frmLogin();
                    form.Show();
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Bạn có muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Close();
        }
    }
}