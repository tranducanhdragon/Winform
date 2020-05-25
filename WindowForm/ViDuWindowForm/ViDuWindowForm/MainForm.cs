using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ViDuWindowForm
{
    class MainForm : Form
    {
        private Button buttonYes;
        private Button buttonNo;
        private Button buttonNew;

        public MainForm()
        {
            //Khoi tao form
            this.Text = "My windows form application";
            this.BackColor = Color.Wheat;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = 300;
            this.Height = 300;

            buttonYes = new Button();
            buttonYes.Text = "Yes";
            buttonYes.BackColor = Color.White;
            buttonYes.Location = new Point(50, 100);

            buttonNo = new Button();
            buttonNo.Text = "No";
            buttonNo.BackColor = Color.White;
            buttonNo.Location = new Point(150, 100);

            buttonNew = new Button();
            buttonNew.Text = "New";
            buttonNew.BackColor = Color.White;
            buttonNew.Location = new Point(100, 130);

            buttonNo.Click += buttonNo_Click;
            buttonNew.Click += buttonNew_Click;
            buttonYes.Click += buttonYes_Click;

            this.Click += form_Click;

/*            buttonNo.Click += buttonNo_Click;*/

            this.Controls.Add(buttonYes);
            this.Controls.Add(buttonNo);
        }
        public void form_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban da click vao toi");
        }
        public void buttonYes_Click(object sender, EventArgs e)
        {
            buttonNew.Visible = true;
            this.Controls.Add(buttonNew);
            /*MessageBox.Show("Ban da click vao Yes");*/
        }
        public void buttonNo_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show("Ban da click vao No");*/
            buttonNew.Visible = false;
        }
        public void buttonNew_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban da click vao New");
        }
    }
}
