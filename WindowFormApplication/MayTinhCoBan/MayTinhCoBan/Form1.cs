using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinhCoBan
{
    public partial class Form1 : Form
    {
        double a, b, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            GetNumbers();
            c = a - b;
            textBoxResult.Text = c.ToString();
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            GetNumbers();
            c = a * b;
            textBoxResult.Text = c.ToString();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            GetNumbers();
            c = a / b;
            textBoxResult.Text = c.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            GetNumbers();
            c = a + b;
            textBoxResult.Text = c.ToString();
        }
        private void GetNumbers()
        {
            a = double.Parse(textBoxFirstNum.Text);
            b = double.Parse(textBoxSecondNum.Text);
        }
    }
}
