using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Swap(ListBox l1, ListBox l2)
        {
            int select;
            if (l1.Items.Count == 0)
            {
                MessageBox.Show("List box is empty!");
            }
            else
            {
                if (l1.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select item first!");
                }
                else
                {
                    select = l1.SelectedIndex;
                    l2.Items.Add(listBox1.Items[select]);
                    l1.Items.RemoveAt(select);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Swap(listBox1, listBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Swap(listBox2, listBox1);
        }
        private void Add(ListBox listBox)
        {
            int select;
            listBox.Items.Add(textBox1.Text);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Add(listBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add(listBox2);
        }
    }
}
