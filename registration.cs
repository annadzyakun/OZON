using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace проба
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string role = comboBox1.SelectedItem.ToString();
            if (ValidatePassword(password))
            {
                if (UserExists(username))
                {
                    MessageBox.Show("Пользователь с таким именем уже существует!");
                }
                else
                {                  
                    RegisterUser(username, password, role);
                    MessageBox.Show("Регистрация прошла успешно!");
                    avtorization avtorization= new avtorization();
                    avtorization.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Пароль не соответствует требованиям!");
            }
        }
        // Проверка пароля на соответствие требованиям
        private bool ValidatePassword(string password)
        {
            // Проверка минимальной длины
            if (password.Length < 6) return false;

            // Проверка наличия прописной буквы
            if (!Regex.IsMatch(password, @"[А-Я]")) return false;

            // Проверка наличия цифры
            if (!Regex.IsMatch(password, @"[0-9]")) return false;

            // Проверка наличия специального символа
            if (!Regex.IsMatch(password, @"[!@#$%^.]")) return false;

            return true;
        }
        // Проверка существования пользователя
        private bool UserExists(string username)
        {
            string connectionString = @"Data Source=.;Initial Catalog=""OZON"";Integrated Security=True;";
            string query = "SELECT COUNT(*) FROM Пользователи WHERE Логин = @username";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    // Проверка, существует ли пользователь с таким именем
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        private void RegisterUser(string username, string password, string role)
        {
            string connectionString = @"Data Source=.;Initial Catalog=""OZON"";Integrated Security=True;";
            string query = "INSERT INTO Пользователи (Логин, Пароль, Роль) VALUES (@username, @password, @role)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@role", role);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}