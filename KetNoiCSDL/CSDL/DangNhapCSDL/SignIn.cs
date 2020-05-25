using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhapCSDL
{
    public partial class SignIn : Form
    {
        DbAccess dbAccess = new DbAccess();
        DataTable dtUsers = new DataTable();
        public static string id, name, email, password, country;

        private void SignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public SignIn()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            SignUp form = new SignUp();
            form.Show();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            string userEmail = textBoxEmailSignIn.Text;
            string userPassword = textBoxPasswordSignIn.Text;

            string query = "select * from User where Email = '" +
                userEmail + "' and Password = '" +
                userPassword + "'";

            dbAccess.readDatathroughAdapter(query, dtUsers);
            if(dtUsers.Rows.Count != 0)
            {
                id = dtUsers.Rows[0]["ID"].ToString();
                name = dtUsers.Rows[0]["Name"].ToString();
                email = dtUsers.Rows[0]["Email"].ToString();
                password = dtUsers.Rows[0]["Password"].ToString();
                country = dtUsers.Rows[0]["Country"].ToString();

                MessageBox.Show("Successfully logged in");
                Hide();
                FormHomePage homePage = new FormHomePage();
                homePage.Show();
            }
            else
            {
                MessageBox.Show("User is not valid. Please sign up first");
            }
         }
    }
}
