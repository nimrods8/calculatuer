using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jenkinsTestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                if (radioButtonAdd.Checked)
                {
                    textBoxResult.Text = (a + b).ToString();
                }
                else if (radioButtonSub.Checked)
                {
                    textBoxResult.Text = (a - b).ToString();
                }
                else if (radioButtonMul.Checked)
                {
                    textBoxResult.Text = (a * b).ToString();
                }
                else if (radioButtonDiv.Checked)
                {
                    textBoxResult.Text = (a / b).ToString();
                }
                else
                    return;

            }
            catch
            {
                MessageBox.Show("Well, that didn't work out!");
            }
        }
    }
}
