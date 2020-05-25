using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTap
{
    public partial class Form_loginfacebook : Form
    {
        public Form_loginfacebook()
        {
            InitializeComponent();
            textBox_password.PasswordChar = '*';
            textBox_password.MaxLength = 4;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if(textBox_username.Text == "ducanh" && textBox_password.Text == "1234")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult thongbao = MessageBox.Show("Sai mat khau hoac ten dang nhap. Dang nhap lai?",
                    "Dang nhap",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if(thongbao == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
