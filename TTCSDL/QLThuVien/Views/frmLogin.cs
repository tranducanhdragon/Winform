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

namespace QLThuVien.Views
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public static string  gPassword, gUserName;

        Database db = new Database();

        DataTable dtUsers = new DataTable();

        public static bool isLogin = false;

        // Button cancel
        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Bạn có muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Close();
        }

        // Click dang ki
        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            Hide();
            frmDangKi form = new frmDangKi();
            form.Show();
        }

        // Button ok login
        private void btOk_Click(object sender, EventArgs e)
        {
            string username = tbTaiKhoan.Text;
            string password = tbMatKhau.Text;
            string query = "Select * from [User] where username = '"
                + username + "' and password = '" + password + "'";
            db.readDatathroughAdapter(query, dtUsers);
            if(dtUsers.Rows.Count != 0)
            {
                gPassword = password;
                gUserName = username;
                DialogResult log = XtraMessageBox.Show("Đăng nhập thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (log == DialogResult.OK)
                {
                    Hide();
                    frmMain form = new frmMain();
                    form.Show();
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng nhập lại thông tin tài khoản !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}