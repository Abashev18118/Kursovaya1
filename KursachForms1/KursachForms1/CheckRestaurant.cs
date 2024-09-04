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
    public partial class CheckRestaurant : Form
    {
        private readonly Contekst _dbContext;
        public CheckRestaurant()
        {
            InitializeComponent();
            _dbContext = new Contekst();
        }
        private void CheckRestaurant_Load(object sender, EventArgs e)
        {
            RefreshRestaurants();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Удаление выбранного ресторана из базы данных
            var selectedRestaurantNumber = int.Parse(comboBox1.SelectedItem.ToString());
            var selectedRestaurant = _dbContext.restaurant.FirstOrDefault(r => r.res_number == selectedRestaurantNumber);

            if (selectedRestaurant != null)
            {
                _dbContext.restaurant.Remove(selectedRestaurant);
                _dbContext.SaveChanges();
                MessageBox.Show("Ресторан успешно удален.");
            }
            else
            {
                MessageBox.Show("Ресторан не найден.");
            }

            // Обновление информации о ресторанах
            RefreshRestaurants();
        }

        private void RefreshRestaurants()
        {
            var restaurants = _dbContext.restaurant.ToList();

            // Очистка comboBox1 и текстового поля перед добавлением новой информации
            comboBox1.Items.Clear();
            textBox1.Clear();
            textBox1.Text += "Рестораны \r\n";

            // Заполнение comboBox1 номерами ресторанов и вывод информации о каждом ресторане в текстовое поле
            foreach (var restaurant in restaurants)
            {
                comboBox1.Items.Add(restaurant.res_number);
                textBox1.Text += $"\r\nНомер ресторана: {restaurant.res_number}, Адрес: {restaurant.address}, Рейтинг: {restaurant.rating}, " +
                                 $"Вместимость: {restaurant.capacity}, Тип зала: {restaurant.type_of_hall}\r\n";
            }
        }
    }
}