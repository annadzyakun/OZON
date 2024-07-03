using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static проба.avtorization;

namespace проба
{
    public partial class prosmotr : Form
    {
        private User currentUser;
        public prosmotr(User user)
        {
            InitializeComponent();
            currentUser = user;
            // Запретить редактирование для Сотрудников
            if (currentUser.Role == "Сотрудник")
            {
                button1.Enabled = false;
            }
            // Разрешить редактирование для Менеджеров
            else if (currentUser.Role == "Менеджер")
            {
                button1.Enabled = true;
            }
        }
        private void prosmotr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oZONDataSet3.Заявки". При необходимости она может быть перемещена или удалена.
            this.заявкиTableAdapter.Fill(this.oZONDataSet3.Заявки);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            avtorization avtorization = new avtorization();
            avtorization.Show();
            this.Hide();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=""OZON"";Integrated Security=True;");
        SqlCommand cmd;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }
        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }
        private void UpdateDataGridView()
        {
            string filter = "";
            if (!string.IsNullOrEmpty(fio.Text))
            {
                filter += "ФИО_заявителя LIKE '%" + fio.Text + "%'";
            }
            if (cb.SelectedItem != null)
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    filter += " AND ";
                }
                filter += "Тип_заявки = '" + cb.SelectedItem.ToString() + "'";
            }
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Заявки WHERE " + (string.IsNullOrEmpty(filter) ? "1=1" : filter), Con))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User user = new User("your_username", "Менеджер");
            Form2 form = new Form2(user);
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string answer = textBox1.Text;
            string status = comboBox1.SelectedItem.ToString();
            if (string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Выберите статус!");
                return;
            }
            int id = 1; 
            try
            {
                Con.Open();
                cmd = new SqlCommand("UPDATE Заявки SET Статус = @status, Ответ = @answer WHERE Номер_заявки = @id", Con);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@answer", answer);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                Con.Close();
                UpdateDataGridView();
                textBox1.Clear();
                comboBox1.SelectedIndex = 0;
                MessageBox.Show("Заявка успешно обновлена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
  