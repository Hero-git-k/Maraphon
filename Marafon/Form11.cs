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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form Form11 = new Form3();

            Form11.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form Form11 = new Form3();

            Form11.Show();
        }
    }
}
