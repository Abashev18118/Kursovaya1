using Kursovaya1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursachForms1
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void connectButton1_Click(object sender, EventArgs e)
        {
            string server = textBox1.Text;
            string database = textBox2.Text;
            string username = textBox3.Text;
            string password = textBox4.Text;

            string connectionString = $"Host={server}; Database={database}; Username={username}; Password={password}";

            try
            {
                using (var db = new Contekst(connectionString))
                {
                    // Проверяем подключение к базе данных
                    db.Database.CanConnect();
                    MessageBox.Show("Успешное подключение к базе данных.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось подключиться к базе данных. Пожалуйста, проверьте введенные данные.");
            }
        }

    }
}
