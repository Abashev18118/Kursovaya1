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
    public partial class Aftorisacia : Form
    {
        private readonly Contekst _dbContext;
        private string _selectedRole;
        private string _selectedName;

        public Aftorisacia()
        {
            InitializeComponent();
            _dbContext = new Contekst();
            LoadNames(); // Добавьте эту строку

            // Добавляем два значения в comboBox1
            comboBox1.Items.Add("Официант");
            comboBox1.Items.Add("Клиент");
        }

        private void LoadNames()
        {
            var clients = _dbContext.clients.ToList();
            var waiters = _dbContext.waiters.ToList();

            // Заполнение ComboBox именами клиентов и официантов
            comboBox2.Items.Clear();
            foreach (var client in clients)
            {
                comboBox2.Items.Add(client.FirstName + " " + client.LastName + " " + client.MiddleName);
            }
            foreach (var waiter in waiters)
            {
                comboBox2.Items.Add(waiter.FirstName + " " + waiter.LastName + " " + waiter.MiddleName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedRole = comboBox1.SelectedItem.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedName = comboBox2.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text;

            if (_selectedRole == "Официант" && password == "0000")
            {
                GlavnayhForm GlavnayhForm = new GlavnayhForm();
                this.Hide(); // Скрываем текущую форму
                GlavnayhForm.Show(); // Показываем главную форму
            }
            else if (_selectedRole == "Клиент" && password == "1111")
            {
                GlavnuyPOCHeck GlavnuyPOCHeck = new GlavnuyPOCHeck();
                this.Hide(); // Скрываем текущую форму
                GlavnuyPOCHeck.Show(); // Показываем форму GlavnuyPOCHeck
            }
            else
            {
                MessageBox.Show("Неверный пароль или не выбраны все критерии.");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Здесь можно добавить код, который будет выполняться при изменении текста.
        }
    }
}
