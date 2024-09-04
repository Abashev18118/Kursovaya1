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
    public partial class Poisk1 : Form
    {
        private readonly Contekst _dbContext;
        private Dish _selectedDish; // Добавляем поле для хранения выбранного блюда

        public Poisk1()
        {
            InitializeComponent();
            _dbContext = new Contekst();
            Poisk1_Load(null, null); // Добавьте эту строку
        }

        private void Poisk1_Load(object sender, EventArgs e)
        {
            var dishes = _dbContext.dishes.ToList();

            // Заполнение ComboBox ценами каждого блюда
            comboBox1.Items.Clear();
            foreach (var dish in dishes)
            {
                comboBox1.Items.Add(dish.price);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Здесь можно добавить дополнительную логику при выборе элемента в ComboBox
            double selectedPrice = (double)comboBox1.SelectedItem;
            _selectedDish = _dbContext.dishes.FirstOrDefault(d => d.price == selectedPrice);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_selectedDish != null)
            {
                // Отображаем полную информацию о выбранном блюде в textBox1
                textBox1.Text = $"Название: {_selectedDish.named}, Цена: {_selectedDish.price}, Себестоимость: {_selectedDish.Cost_price}";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Здесь можно добавить код, который будет выполняться при изменении текста.
        }
    }
}
