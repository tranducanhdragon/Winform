using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromConnecting
{
    public partial class FormSignUp : Form
    {
        public static string firstName;
        public static string lastName;
        public static string emailAddress;
        public static Boolean sms;
        public static Boolean report;
        public static Boolean transaction;
        public Confrimation formConfirm = new Confrimation();
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            firstName = textBoxFirstName.Text;
            lastName = textBoxLastName.Text;
            emailAddress = textBoxEmailAddress.Text;

            formConfirm.Show();
        }

        private void checkBoxSMS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSMS.Checked)
            {
                sms = true;
                labelSMS.Text = "Services charges may apply";
            }
            else
            {
                sms = false;
                labelSMS.Text = "....";
            }
        }

        private void checkBoxReport_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxReport.Checked)
            {
                report = true;
                labelReport.Text = "Free services";
            }
            else
            {
                report = false;
                labelReport.Text = "....";
            }
        }

        private void checkBoxTransaction_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTransaction.Checked)
            {
                transaction = true;
                labelTransaction.Text = "Additional charges may apply";
            }
            else
            {
                transaction = false;
                labelTransaction.Text = "....";
            }
        }
    }
}
