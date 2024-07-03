using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static проба.avtorization;

namespace проба
{
    public partial class zaiavki : Form
    {
        private User currentUser;
        public zaiavki(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void zaiavki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oZONDataSet2.Заявки". При необходимости она может быть перемещена или удалена.
            this.заявкиTableAdapter2.Fill(this.oZONDataSet2.Заявки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oZONDataSet1.Заявки". При необходимости она может быть перемещена или удалена.


        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=""OZON"";Integrated Security=True;");
        SqlCommand cmd;
        private void button1_Click(object sender, EventArgs e)
        { 
            SqlCommand cmd = new SqlCommand("INSERT INTO Заявки (Тип_заявки, ФИО_заявителя, Описание, Дата_подачи) VALUES (@ТипЗаявки, @ФИО, @Описание, @ДатаПодачи)", Con);
            cmd.Parameters.AddWithValue("@ТипЗаявки", cb.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@ФИО", fio.Text);
            cmd.Parameters.AddWithValue("@Описание", opisanie.Text);
            cmd.Parameters.AddWithValue("@ДатаПодачи", date.Value.Date);
            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();      
            UpdateDataGridView();
            MessageBox.Show("Данные успешно добавлены");
        }
        private void UpdateDataGridView()
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Заявки", Con))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;  
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            avtorization avtorization = new avtorization();
            avtorization.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User user = new User("your_username", "Сотрудник");
            Form2 form = new Form2(user);
            form.Show();
            this.Hide();
        }
    }
}
