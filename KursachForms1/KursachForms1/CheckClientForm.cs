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
    public partial class CheckClientForm : Form
    {
        private readonly Contekst _dbContext;

        public CheckClientForm()
        {
            InitializeComponent();
            _dbContext = new Contekst();
        }

        private void CheckClientForm_Load(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void LoadClients()
        {
            var clients = _dbContext.clients.ToList();

            // Очистка текстового поля и ComboBox перед добавлением новой информации
            textBox1.Clear();
            comboBox1.Items.Clear();

            textBox1.Text += "Клиенты \r\n";

            // Вывод информации о каждом клиенте в текстовое поле и ComboBox
            foreach (var client in clients)
            {
                string clientInfo = $"Фамилия: {client.LastName}, Имя: {client.FirstName}, Отчество: {client.MiddleName}, " +
                                    $"Паспортные данные: {client.PassportData}, Телефон: {client.Phone_number}, " +
                                    $"Email: {client.email}";

                textBox1.Text += $"\r\n{clientInfo}\r\n";

                // Добавление клиента в ComboBox
                comboBox1.Items.Add(new ComboBoxItem(client.Id, $"{client.LastName} {client.FirstName} {client.MiddleName}"));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Этот метод будет вызван при выборе элемента из ComboBox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем выбранного клиента из ComboBox
            var selectedItem = comboBox1.SelectedItem as ComboBoxItem;

            if (selectedItem != null)
            {
                var clientId = selectedItem.Id;
                var client = _dbContext.clients.FirstOrDefault(c => c.Id == clientId);

                if (client != null)
                {
                    // Удаляем клиента из базы данных
                    _dbContext.clients.Remove(client);
                    _dbContext.SaveChanges();

                    // Обновляем список клиентов
                    LoadClients();

                    MessageBox.Show("Клиент успешно удален.");
                }
                else
                {
                    MessageBox.Show("Клиент не найден.");
                }
            }
            else
            {
                MessageBox.Show("Выберите клиента для удаления.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Этот метод оставлен пустым, так как он может быть нужен для других обработчиков событий
        }
    }

    public class ComboBoxItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ComboBoxItem(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
