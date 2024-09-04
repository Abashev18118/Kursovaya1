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
    public partial class CheckWaiter : Form
    {
        private readonly Contekst _dbContext;
        public CheckWaiter()
        {
            InitializeComponent();
            _dbContext = new Contekst();
        }
        private void CheckWaiter_Load(object sender, EventArgs e)
        {
            RefreshWaiters();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Удаление выбранного официанта из базы данных
            var selectedWaiterName = comboBox1.SelectedItem.ToString();
            var selectedWaiter = _dbContext.waiters.FirstOrDefault(w => w.FirstName + " " + w.LastName + " " + w.MiddleName == selectedWaiterName);

            if (selectedWaiter != null)
            {
                _dbContext.waiters.Remove(selectedWaiter);
                _dbContext.SaveChanges();
                MessageBox.Show("Официант успешно удален.");
            }
            else
            {
                MessageBox.Show("Официант не найден.");
            }

            // Обновление информации об официантах
            RefreshWaiters();
        }

        private void RefreshWaiters()
        {
            var waiters = _dbContext.waiters.ToList();

            // Очистка comboBox1 и текстового поля перед добавлением новой информации
            comboBox1.Items.Clear();
            textBox1.Clear();
            textBox1.Text += "Официанты \r\n";

            // Заполнение comboBox1 именами официантов и вывод информации о каждом официанте в текстовое поле
            foreach (var waiter in waiters)
            {
                comboBox1.Items.Add(waiter.FirstName + " " + waiter.LastName + " " + waiter.MiddleName);
                textBox1.Text += $"\r\nФамилия: {waiter.LastName}, Имя: {waiter.FirstName}, Отчество: {waiter.MiddleName}, " +
                                 $"Паспортные данные: {waiter.PassportData}, Телефон: {waiter.Phone_number}, Зарплата: {waiter.Salary}, " +
                                 $"Обслуживаемые столы: {waiter.Service_tables}, Обслуживаемый зал: {waiter.Service_Hall}\r\n";
            }
        }
    }
}