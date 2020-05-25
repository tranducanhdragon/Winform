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

namespace DangNhapCSDL
{
    public partial class FormHomePage : Form
    {
        DbAccess dbAccess = new DbAccess();
        public FormHomePage()
        {
            InitializeComponent();
        }

        private void FormHomePage_Load(object sender, EventArgs e)
        {
            Text = SignIn.name + "'s profile";
            textBoxName.Text = SignIn.name;
            textBoxEmail.Text = SignIn.email;
            textBoxPassword.Text = SignIn.password;
            comboBoxCountry.Text = SignIn.country;

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            string country = comboBoxCountry.Text;

            string query = " update [User] set Name = '" +
                @name + "', Email = '" + @email + "', " +
                "Password = '" + @password + "' , Country = '" +
                @country + "' where ID = '" + SignIn.id + "'";

            SqlCommand update = new SqlCommand(query);

            int row = dbAccess.executeQuery(update);
            if(row != 0)
            {
                MessageBox.Show("Successful Updated");
                Hide();
                SignIn form = new SignIn();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure to delete?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if(dialog == DialogResult.Yes)
            {
                string query = "delete from [User] where ID = '" +
                    SignIn.id + "'";
                SqlCommand delete = new SqlCommand(query);
                int row = dbAccess.executeQuery(delete);
                if(row != 0)
                {
                    MessageBox.Show("Successfully Deleted");
                    Hide();
                    SignIn form = new SignIn();
                    form.Show();
                }
            }
        }
    }
}
