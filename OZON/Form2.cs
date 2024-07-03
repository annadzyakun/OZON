using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OZON
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zaiavki zaiavki = new zaiavki();
            zaiavki.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            string username = "сотрудник"; 
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;

            if (username == "менеджер")
            {
                button1.Visible = true;
                button2.Visible = true;
              
            }
            else if (username == "сотрудник")
            {
                button3.Visible = true;
                button1.Visible = true;
            }
        }
    }
}
  