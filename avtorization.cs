using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static проба.avtorization;

namespace проба
{
    public partial class avtorization : Form
    {
        public avtorization()
        {
            InitializeComponent();
        }
        private static class Authorization
        {
            public static bool HasAccess(User user, Form form)
            {       
                return true; // Всем разрешен доступ ко второй форме
            }
        }
        public class User
        {
            public string Username { get; set; }
            public string Role { get; set; }

            public User(string username, string role)
            {
                Username = username;
                Role = role;
            }
        }
        private bool ValidatePassword(string username, string password)
        {
            string connectionString = @"Data Source=.;Initial Catalog=""OZON"";Integrated Security=True;";
            string query = "SELECT COUNT(*) FROM Пользователи WHERE Логин = @username AND Пароль = @password";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
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
        private string GetUserRole(string username)
        {
            string connectionString = @"Data Source=.;Initial Catalog=""OZON"";Integrated Security=True;";
            string query = "SELECT Роль FROM Пользователи WHERE Логин = @username";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {                     
                            return reader["Роль"].ToString();
                        }
                    }
                }
            }
            return null; 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (ValidatePassword(username, password))
            {
                string userRole = GetUserRole(username);
                User user = new User(username, userRole);
                Form2 form2 = new Form2(user);
                form2.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
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
