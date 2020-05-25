using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViDuWindowForm
{
    class Program
    {
        static void Main(string[] args)
        {
            //             Form form = new Form();
            // 
            //             Button buttonYes = new Button();
            //             buttonYes.Text = "Yes";
            //             buttonYes.BackColor = Color.White;
            //             buttonYes.Location = new Point(50, 100);
            // 
            //             buttonYes.Click += buttonYes_Click;
            //             form.Click += form_Click;
            // 
            //             Button buttonNo = new Button();
            //             buttonNo.Text = "No";
            //             buttonNo.BackColor = Color.White;
            //             buttonNo.Location = new Point(150, 100);
            // 
            //             buttonNo.Click += buttonNo_Click;
            // 
            //             form.Controls.Add(buttonYes);
            //             form.Controls.Add(buttonNo);
            // 
            //             Application.Run(form);

            MainForm form = new MainForm();
            Application.Run(form);

        }
    }
}
