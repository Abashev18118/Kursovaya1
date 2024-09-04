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
    public partial class OrderForm : Form
    {
        private Contekst db;
        public OrderForm()
        {
            InitializeComponent();
            db = new Contekst();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//номер заказа
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)//Дата заказа
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//Статус заказа
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//Сумма заказа
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//Зал ресторана
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)//Столик
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)//Ресторан
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Contekst db = new())
            {


                int numberOrder = int.Parse(textBox1.Text); // Номер заказа
                DateTime dateOrder = dateTimePicker1.Value.ToUniversalTime(); // Дата заказа
                string orderStatus = comboBox1.SelectedItem.ToString(); // Статус заказа
                double orderAmount = double.Parse(textBox2.Text); // Сумма заказа
                int restaurantHall = int.Parse(textBox3.Text); // Зал ресторана
                int tablenumber = int.Parse(textBox4.Text); // номер столика
                string restaurantName = textBox5.Text; // Название ресторана



                if (numberOrder != null)
                {
                    Order order = new Order();
                    order.Add(numberOrder, dateOrder, orderStatus, orderAmount, restaurantHall, tablenumber, restaurantName);
                    db.orders.Add(order);
                    db.SaveChanges();

                    MessageBox.Show("Заказ успешно добавлен.");
                }
                else
                {
                    MessageBox.Show("Столик или ресторан не найдены.");
                }


            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
