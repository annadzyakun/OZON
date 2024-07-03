using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static проба.avtorization;

namespace проба
{
    public partial class Form2 : Form
    {
        private User currentUser;
        public Form2(User user)
        {
            InitializeComponent();
            currentUser = user;
            // Настройка доступа к кнопкам
            SetButtonAccess();
        }
        private void SetButtonAccess()
        {    
            buttonCreateRequest.Enabled = currentUser.Role == "Сотрудник"  || currentUser.Role == "Генеральный директор";
            buttonViewRequest.Enabled = currentUser.Role == "Сотрудник" || currentUser.Role == "Менеджер" || currentUser.Role == "Генеральный директор";
            buttonReport.Enabled = currentUser.Role == "Менеджер" || currentUser.Role == "Генеральный директор";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zaiavki createRequestForm = new zaiavki(currentUser);
            createRequestForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            prosmotr viewRequestForm = new prosmotr(currentUser);
            viewRequestForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            otchet reportForm = new otchet(currentUser);
            reportForm.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            avtorization avtorization = new avtorization();
            avtorization.Show();
            this.Hide();
        }
    }
}
