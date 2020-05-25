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
namespace DangNhapCSDL
{
    public partial class SignUp : Form
    {
        DbAccess dbAccess = new DbAccess();
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBoxName.Text;
            string userEmail = textBoxEmail.Text;
            string userPassword = textBoxPassword.Text;
            string userCountry = comboBoxCountry.Text;

            SqlCommand insertCommand = new SqlCommand("insert into " +
                "[User](Name, Email, Password, Country)" +
                " values(@userName, @userEmail, @userPassword, @userCountry)"
                );
            insertCommand.Parameters.AddWithValue("@userName", userName);
            insertCommand.Parameters.AddWithValue("@userEmail", userEmail);
            insertCommand.Parameters.AddWithValue("@userPassword", userPassword);
            insertCommand.Parameters.AddWithValue("@userCountry", userCountry);

            int row = dbAccess.executeQuery(insertCommand);
            if(row == 1)
            {
                MessageBox.Show("Successfully Signed Up");
                Hide();
                FormHomePage homePage = new FormHomePage();
                homePage.Show();
            }
            else
            {

            }
        }
    }
}
