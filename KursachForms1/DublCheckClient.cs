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
    public partial class DublCheckClient : Form
    {
        private readonly Contekst _dbContext;
        private Client _selectedClient;

        public DublCheckClient()
        {
            InitializeComponent();
            _dbContext = new Contekst();
            LoadClients();
        }

        private void LoadClients()
        {
            var clients = _dbContext.clients.ToList();
            textBox1.Clear();

            foreach (var client in clients)
            {
                string clientInfo = $"Фамилия: {client.LastName}, Имя: {client.FirstName}, Отчество: {client.MiddleName}, " +
                                    $"Паспортные данные: {client.PassportData}, Телефон: {client.Phone_number}, " +
                                    $"Email: {client.email}";

                textBox1.Text += $"{clientInfo}\r\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // При нажатии на первую кнопку, мы можем редактировать и переписывать данные в текстбоксе
            var passportData = textBox1.Text.Split('\n')[0].Split(':')[1].Trim();
            _selectedClient = _dbContext.clients.FirstOrDefault(c => c.PassportData == passportData);

            if (_selectedClient != null)
            {
                textBox1.Text = $"Фамилия: {_selectedClient.LastName}\r\nИмя: {_selectedClient.FirstName}\r\nОтчество: {_selectedClient.MiddleName}\r\n" +
                                $"Паспортные данные: {_selectedClient.PassportData}\r\nТелефон: {_selectedClient.Phone_number}\r\nEmail: {_selectedClient.email}";
            }
            else
            {
                MessageBox.Show("Клиент не найден.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // При нажатии на вторую кнопку, мы сохраняем изменения
            if (_selectedClient != null)
            {
                var lines = textBox1.Text.Split('\n');
                _selectedClient.LastName = lines[0].Split(':')[1].Trim();
                _selectedClient.FirstName = lines[1].Split(':')[1].Trim();
                _selectedClient.MiddleName = lines[2].Split(':')[1].Trim();
                _selectedClient.PassportData = lines[3].Split(':')[1].Trim();
                _selectedClient.Phone_number = lines[4].Split(':')[1].Trim();
                _selectedClient.email = lines[5].Split(':')[1].Trim();

                _dbContext.SaveChanges();

                MessageBox.Show("Изменения успешно сохранены.");
                LoadClients();
            }
            else
            {
                MessageBox.Show("Выберите клиента для редактирования.");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Ваш код здесь
        }
    }
}
