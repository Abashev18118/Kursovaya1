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
    public partial class CheckOrder : Form
    {
        private readonly Contekst _dbContext;
        public CheckOrder()
        {
            InitializeComponent();
            _dbContext = new Contekst();
            LoadOrderNumbers();
        }

        private void LoadOrderNumbers()
        {
            var orderNumbers = _dbContext.orders.Select(o => o.Number_of_Order).ToList();
            comboBox1.DataSource = orderNumbers;
        }

        private void CheckOrder_Load(object sender, EventArgs e)
        {
            UpdateOrderList();
        }

        private void UpdateOrderList()
        {
            var orders = _dbContext.orders.ToList();

            // Очистка текстового поля перед добавлением новой информации
            textBox1.Clear();
            textBox1.Text += "Заказы \r\n";

            // Вывод информации о каждом заказе в текстовое поле
            foreach (var order in orders)
            {
                textBox1.Text += $"\r\nНомер заказа: {order.Number_of_Order}, Дата заказа: {order.Date_of_Order}, Статус заказа: {order.Order_Status}, " +
                                 $"Сумма заказа: {order.Order_amount}, Название ресторана: {order.RestaurantName}, Зал ресторана: {order.Restaurant_hall}, Номер столика: {order.TableNumber} \r\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedOrderNumber = (int)comboBox1.SelectedItem;
            var orderToRemove = _dbContext.orders.FirstOrDefault(o => o.Number_of_Order == selectedOrderNumber);
            if (orderToRemove != null)
            {
                _dbContext.orders.Remove(orderToRemove);
                _dbContext.SaveChanges();
                MessageBox.Show($"Заказ номер {selectedOrderNumber} успешно удален.");
                LoadOrderNumbers(); // Обновляем список номеров заказов в комбобоксе
                UpdateOrderList(); // Обновляем список заказов в текстовом поле
            }
            else
            {
                MessageBox.Show($"Заказ номер {selectedOrderNumber} не найден.");
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Пока здесь ничего не делаем
        }
    }
}