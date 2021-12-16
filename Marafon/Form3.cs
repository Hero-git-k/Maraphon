using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marafon
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form Form3 = new Form1();

            Form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {

                int a = Convert.ToInt32(textBox12.Text) + 50;

                textBox12.Text = Convert.ToString(a);
                label16.Text = Convert.ToString(a);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox12.Text);

            if (b > 50)

            {
                int a = Convert.ToInt32(textBox12.Text) - 50;

                textBox12.Text = Convert.ToString(a);

                label16.Text  = Convert.ToString(a);
            }

            else
            {

                b = 50;

                textBox12.Text = Convert.ToString(b);
                label16.Text = Convert.ToString(b);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form Form3 = new Form11();

            Form3.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        

        }
    }
}
   
