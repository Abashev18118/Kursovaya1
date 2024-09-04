

using Kursovaya1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursachForms1
{
    public partial class CheckDish : Form
    {
        private readonly Contekst _dbContext;
        private Dish _selectedDish;

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
            mainTextBox.Clear();
            mainTextBox.Text += "Блюда \r\n";

            // Заполнение ComboBox и текстового поля информацией о каждом блюде
            dishComboBox.Items.Clear();
            foreach (var dish in dishes)
            {
                dishComboBox.Items.Add(new ComboBoxItem(dish.Id, dish.named));
                mainTextBox.Text += $"\r\nНазвание: {dish.named}, Цена: {dish.price}, Себестоимость: {dish.Cost_price}\r\n";
            }

            // Заполнение DataGridView информацией о наценках
            dishDataGridView.Rows.Clear();
            dishDataGridView.Columns.Clear();
            dishDataGridView.Columns.Add("DishName", "Название блюда");
            dishDataGridView.Columns.Add("ExtraCharge", "Наценка");
            for (int i = 0; i < Math.Min(dishes.Count, markUps.Count); i++)
            {
                var dish = dishes[i];
                var markUp = markUps[i];
                dishDataGridView.Rows.Add(dish.named, markUp.extra_charge);
            }
        }

        private void deleteDataButton_Click(object sender, EventArgs e)
        {
            if (dishComboBox.SelectedItem is ComboBoxItem selectedDish)
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

        private void dishComboBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {
            // Здесь можно добавить код, который будет выполняться при изменении текста.
        }

        private void dishDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Здесь можно добавить код, который будет выполняться при клике на ячейку DataGridView.
        }

        private void editDataButton_Click(object sender, EventArgs e)
        {
            if (dishComboBox.SelectedItem is ComboBoxItem selectedDishItem)
            {
                _selectedDish = _dbContext.dishes.Find(selectedDishItem.Id);
                if (_selectedDish != null)
                {
                    mainTextBox.Text = _selectedDish.named; // Загружаем название блюда в mainTextBox для редактирования
                }
            }
        }
        private void resaveDataButton_Click(object sender, EventArgs e)
        {
            if (_selectedDish != null)
            {
                _selectedDish.named = mainTextBox.Text; // Обновляем название блюда
                _dbContext.SaveChanges(); // Сохраняем изменения в базе данных

                MessageBox.Show("Блюдо успешно обновлено.");

                // Обновление данных на форме
                CheckDish_Load(sender, e);
            }
        }

        private void notesTextBox_TextChanged(object sender, EventArgs e)
        {
            // Здесь можно добавить код, который будет выполняться при изменении текста в notesTextBox.
        }

        private void countButton_Click(object sender, EventArgs e) //Count
        {
            // Подсчет количества блюд в базе данных
            int dishCount = _dbContext.dishes.Count();

            // Вывод результата в notesTextBox
            notesTextBox.Text = $"Количество блюд: {dishCount}";
        }

        private void sumButton_Click(object sender, EventArgs e) //Sum
        {
            // Подсчет суммы цен всех блюд в базе данных
            double totalCost = _dbContext.dishes.Sum(d => d.price);

            // Вывод результата в notesTextBox
            notesTextBox.Text = $"Общая стоимость всех блюд: {totalCost}";
        }

        private void avgButton_Click(object sender, EventArgs e) //Avg
        {
            // Подсчет средней цены блюд в базе данных
            double averageCost = _dbContext.dishes.Average(d => d.price);

            // Вывод результата в notesTextBox
            notesTextBox.Text = $"Средняя стоимость блюда: {averageCost}";
        }

        private void saveToFileButton_Click(object sender, EventArgs e)
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