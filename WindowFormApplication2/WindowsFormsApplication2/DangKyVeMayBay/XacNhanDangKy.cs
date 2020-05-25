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
    public partial class XacNhanDangKy : Form
    {
        public XacNhanDangKy()
        {
            InitializeComponent();
        }

        private void XacNhanDangKy_Load(object sender, EventArgs e)
        {
            labelFullName.Text = DangKyMayBay.firstName+" "+DangKyMayBay.lastName;
            labelDeparture.Text = DangKyMayBay.From;
            labelDestination.Text = DangKyMayBay.To;
            labelDocumentNo.Text = DangKyMayBay.documentNo;
            labelBaggage.Text = DangKyMayBay.Baggage;
            if (DangKyMayBay.passport)
                labelTraveldocument.Text = "Passport";
            else if (DangKyMayBay.idcard)
                labelTraveldocument.Text = "ID Card";
            
            labelExpiryDate.Text = DangKyMayBay.issue.ToString("dd-MM-yyyy")+" to "+DangKyMayBay.expiry.ToString("dd-MM-yyyy");
            labelTripDates.Text = DangKyMayBay.start.ToString("dd-MM-yyyy") + " to " + DangKyMayBay.end.ToString("dd-MM-yyyy");
        }
    }
}
