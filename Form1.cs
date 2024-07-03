using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace проба
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            avtorization avtorization = new avtorization();
            avtorization.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registration registration = new registration();
            registration.Show();
            this.Hide();
        }
    }
}
