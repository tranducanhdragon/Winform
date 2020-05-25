using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

        public float num = 0;
        public string oper = "" ;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if(textBox.Text == "0")
            {
                textBox.Clear();
            }
            Button button = (Button)sender;
            textBox.Text = textBox.Text + button.Text;

        }

        private void ButtonOperator(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            oper = button.Text;
            num = float.Parse(textBox.Text);
            textBox.Clear();
        }
        private void ButtonResult(object sender, EventArgs e)
        {
            if(num != 0)
            {
                switch (oper)
                {
                    case "+":
                        {                           
                            num = num + float.Parse(textBox.Text);
                            break;
                        }
                    case "-":
                        {
                            num = num - float.Parse(textBox.Text);
                            break;
                        }
                    case "*":
                        {
                            num = num * float.Parse(textBox.Text);
                            break;
                        }
                    case "/":
                        {
                            num = num / float.Parse(textBox.Text);
                            break;
                        }
                }
            }
            else
            {
                labelKetQua.Text = "Math error!";
            }
            labelKetQua.Text = num.ToString();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            labelKetQua.Text = "";
            num = 0;
        }

        private void buttonDelete1_Click(object sender, EventArgs e)
        {
            if(textBox.Text != "")
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            }
            else
            {
                labelKetQua.Text = "Khong xoa duoc nua!";
            }
        }
    }
}
