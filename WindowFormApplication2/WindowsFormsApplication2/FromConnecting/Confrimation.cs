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
    public partial class Confrimation : Form
    {
        public Confrimation()
        {
            InitializeComponent();
        }

        private void Confrimation_Load(object sender, EventArgs e)
        {
            labelFirstName.Text = FormSignUp.firstName;
            labelLastName.Text = FormSignUp.lastName;
            labelEmailAddress.Text = FormSignUp.emailAddress;

            labelSMS.Text = FormSignUp.sms == true ? ((char)0x221A).ToString() : "X";
            labelReport.Text = FormSignUp.report == true ? ((char)0x221A).ToString() : "X";
            labelTransaction.Text = FormSignUp.transaction == true? ((char)0x221A).ToString() : "X";
        }
    }
}
