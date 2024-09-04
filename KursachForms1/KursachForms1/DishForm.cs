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
    public partial class DishForm : Form
    {
        private Contekst db;
        private GlavnayhForm _GlavnayhForm;


        public DishForm(GlavnayhForm GlavnayhForm)
        {
            InitializeComponent();
            db = new Contekst();
            _GlavnayhForm = GlavnayhForm;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Contekst db = new())
            {
                string named = textBox1.Text; // Название блюда
                double price;
                double costPrice;

                try
                {
                    price = double.Parse(textBox2.Text); // Цена
                }
                catch (FormatException)
                {
                    MessageBox.Show("Введен неверный тип данных для цены.");
                    return;
                }

                try
                {
                    costPrice = double.Parse(textBox3.Text); // Себестоимость
                }
                catch (FormatException)
                {
                    MessageBox.Show("Введен неверный тип данных для себестоимости.");
                    return;
                }

                Dish dish = new Dish();
                dish.Add(named, price, costPrice);
                db.dishes.Add(dish);
                db.SaveChanges();

                MessageBox.Show("Блюдо успешно добавлено.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Скрываем текущую форму
            _GlavnayhForm.Show(); // Показываем главную форму
        }
    }
}
