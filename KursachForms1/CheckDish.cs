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
using System.IO;

namespace KursachForms1
{
    public partial class CheckDish : Form
    {
        private readonly Contekst _dbContext;
        private Dish _selectedDish; // Добавляем поле для хранения выбранного блюда
        public CheckDish()
        {
            InitializeComponent();
            _dbContext = new Contekst();
        }
        private void CheckDish_Load(object sender, EventArgs e)
        {
            var dishes = _dbContext.dishes.ToList();
            var markUps = _dbContext.mark_Up_Of_The_Dishes.ToList();

            // Очистка текстового поля перед добавлением новой информации
            textBox1.Clear();
            textBox1.Text += "Блюда \r\n";

            // Заполнение ComboBox и текстового поля информацией о каждом блюде
            comboBox1.Items.Clear();
            foreach (var dish in dishes)
            {
                comboBox1.Items.Add(new ComboBoxItem(dish.Id, dish.named));
                textBox1.Text += $"\r\nНазвание: {dish.named}, Цена: {dish.price}, Себестоимость: {dish.Cost_price}\r\n";
            }

            // Заполнение DataGridView информацией о наценках
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("DishName", "Название блюда");
            dataGridView1.Columns.Add("ExtraCharge", "Наценка");
            for (int i = 0; i < Math.Min(dishes.Count, markUps.Count); i++)
            {
                var dish = dishes[i];
                var markUp = markUps[i];
                dataGridView1.Rows.Add(dish.named, markUp.extra_charge);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is ComboBoxItem selectedDish)
            {
                var dishToRemove = _dbContext.dishes.Find(selectedDish.Id);
                if (dishToRemove != null)
                {
                    _dbContext.dishes.Remove(dishToRemove);
                    _dbContext.SaveChanges();

                    MessageBox.Show("Блюдо успешно удалено.");

                    // Обновление данных на форме
                    CheckDish_Load(sender, e);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Здесь можно добавить дополнительную логику при выборе элемента в ComboBox
        }

        // Вспомогательный класс для представления элементов ComboBox
        private class ComboBoxItem
        {
            public Guid Id { get; }
            public string Name { get; }

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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Здесь можно добавить код, который будет выполняться при изменении текста.
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Здесь можно добавить код, который будет выполняться при клике на ячейку DataGridView.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is ComboBoxItem selectedDishItem)
            {
                _selectedDish = _dbContext.dishes.Find(selectedDishItem.Id);
                if (_selectedDish != null)
                {
                    textBox1.Text = _selectedDish.named; // Загружаем название блюда в textBox1 для редактирования
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_selectedDish != null)
            {
                _selectedDish.named = textBox1.Text; // Обновляем название блюда
                _dbContext.SaveChanges(); // Сохраняем изменения в базе данных

                MessageBox.Show("Блюдо успешно обновлено.");

                // Обновление данных на форме
                CheckDish_Load(sender, e);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) //Count
        {
            // Подсчет количества блюд в базе данных
            int dishCount = _dbContext.dishes.Count();

            // Вывод результата в textBox2
            textBox2.Text = $"Количество блюд: {dishCount}";
        }

        private void button5_Click(object sender, EventArgs e) //Sum
        {
            // Подсчет суммы цен всех блюд в базе данных
            double totalCost = _dbContext.dishes.Sum(d => d.price);

            // Вывод результата в textBox2
            textBox2.Text = $"Общая стоимость всех блюд: {totalCost}";
        }

        private void button6_Click(object sender, EventArgs e) //Avg
        {
            // Подсчет средней цены блюд в базе данных
            double averageCost = _dbContext.dishes.Average(d => d.price);

            // Вывод результата в textBox2
            textBox2.Text = $"Средняя стоимость блюда: {averageCost}";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Здесь вы можете определить условие для выбора данных
            var dishesToExport = _dbContext.dishes.Where(d => d.price > 100); // Пример условия

            // Запись данных в файл
            using (StreamWriter file = new StreamWriter(@"C:\Users\Roman\Documents\Курсовая Кузьминых\AIS.txt"))
            {
                foreach (var dish in dishesToExport)
                {
                    file.WriteLine($"Название: {dish.named}, Цена: {dish.price}, Себестоимость: {dish.Cost_price}");
                }
            }

            MessageBox.Show("Данные успешно экспортированы.");
        }
    }
}