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
    public partial class Poisk2 : Form
    {
        private readonly Contekst _dbContext;
        private double _selectedPrice;
        private string _selectedName;

        public Poisk2()
        {
            InitializeComponent();
            _dbContext = new Contekst();
            LoadData();
        }

        private void LoadData()
        {
            var dishes = _dbContext.dishes.ToList();

            // Заполнение ComboBox ценами и названиями каждого блюда
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            foreach (var dish in dishes)
            {
                comboBox1.Items.Add(dish.price);
                comboBox2.Items.Add(dish.named);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedPrice = (double)comboBox1.SelectedItem;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedName = (string)comboBox2.SelectedItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_selectedPrice != 0 && !string.IsNullOrEmpty(_selectedName))
            {
                var dish = _dbContext.dishes.FirstOrDefault(d => d.price == _selectedPrice && d.named == _selectedName);
                if (dish != null)
                {
                    // Отображаем полную информацию о выбранном блюде в textBox1
                    textBox1.Text = $"Название: {dish.named}, Цена: {dish.price}, Себестоимость: {dish.Cost_price}";
                }
                else
                {
                    MessageBox.Show("Критерии не верны.");
                }
            }
            else
            {
                MessageBox.Show("Поиск можно начать только после выбора нескольких критериев.");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Здесь можно добавить код, который будет выполняться при изменении текста.
        }
    }
}
