using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangKyVeMayBay
{
    public partial class DangKyMayBay : Form
    {
        public static string firstName;
        public static string lastName;
        public static string To, From;
        public static Boolean passport, idcard;
        public static string documentNo;
        public static DateTime issue, expiry;
        public static DateTime start, end;
        public static string Baggage;
        XacNhanDangKy xn = new XacNhanDangKy();
        public DangKyMayBay()
        {
            InitializeComponent();
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            firstName = textBoxFirstName.Text;
            lastName = textBoxLastName.Text;
            To = textBoxTo.Text;
            From = textBoxFrom.Text;
            if (radioButton1.Checked)
            {
                idcard = false;
                passport = true;
            }
            else if (radioButton2.Checked)
            {
                idcard = true;
                passport = false;
            }
            documentNo = textBoxDocumentNo.Text;
            issue = dateTimePickerIssueDate.Value;
            expiry = dateTimePickerExpiryDate.Value;
            start = monthCalendar1.SelectionRange.Start;
            end = monthCalendar1.SelectionRange.End;
            Baggage = numericUpDownBaggage.Value.ToString();
            xn.Show();
        }
    }
}
