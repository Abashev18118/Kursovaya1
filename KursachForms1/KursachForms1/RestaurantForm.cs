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
    public partial class RestaurantForm : Form
    {
        private Contekst db;
        public RestaurantForm()
        {
            InitializeComponent();
            db = new Contekst();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//Телефон ресторана
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//Адрес
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//Рэйтинг
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//Вместимость
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)//Типы залов
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Contekst db = new())
            {
                
                
                    int resNumber = int.Parse(textBox1.Text); // Номер ресторана
                    string address = textBox2.Text; // Адрес
                    double rating = double.Parse(comboBox1.SelectedItem.ToString()); // Рейтинг
                    int capacity = int.Parse(textBox3.Text); // Вместимость
                    string hallnumber = comboBox2.SelectedItem.ToString(); // Тип зала

                    if (capacity != null)
                    {
                        Restaurant restaurant = new Restaurant();
                        restaurant.Add(resNumber, address, rating, capacity, hallnumber);
                        db.restaurant.Add(restaurant);
                        db.SaveChanges();

                        MessageBox.Show("Ресторан успешно добавлен.");
                    }

                
              
            }
        }
    }
}
