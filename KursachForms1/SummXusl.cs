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
    public partial class SummXusl : Form
    {
        private readonly Contekst _dbContext;
        public SummXusl()
        {
            InitializeComponent();
            _dbContext = new Contekst();
            SummXusl_Load(this, EventArgs.Empty);
        }

        private void SummXusl_Load(object sender, EventArgs e)
        {
            // Заполнение comboBox1 операциями
            comboBox1.Items.AddRange(new string[] { "+", "-", "*", "/" });

            // Заполнение comboBox2 и comboBox3 номерами заказов
            var orderNumbers = _dbContext.orders.Select(o => o.Number_of_Order.ToString()).ToArray();
            comboBox2.Items.AddRange(orderNumbers);
            comboBox3.Items.AddRange(orderNumbers); // Добавлено заполнение comboBox3
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is string operation &&
                comboBox2.SelectedItem is string orderNumber1 &&
                comboBox3.SelectedItem is string orderNumber2) // Изменено на comboBox3
            {
                var order1 = _dbContext.orders.FirstOrDefault(o => o.Number_of_Order.ToString() == orderNumber1);
                var order2 = _dbContext.orders.FirstOrDefault(o => o.Number_of_Order.ToString() == orderNumber2);

                if (order1 != null && order2 != null)
                {
                    double result = 0;
                    switch (operation)
                    {
                        case "+":
                            result = order1.Order_amount + order2.Order_amount;
                            break;
                        case "-":
                            result = order1.Order_amount - order2.Order_amount;
                            break;
                        case "*":
                            result = order1.Order_amount * order2.Order_amount;
                            break;
                        case "/":
                            if (order2.Order_amount != 0)
                            {
                                result = order1.Order_amount / order2.Order_amount;
                            }
                            else
                            {
                                MessageBox.Show("Деление на ноль невозможно.");
                                return;
                            }
                            break;
                    }

                    textBox1.Text = $"Номер первого заказа: {orderNumber1} {operation} Номер второго заказа: {orderNumber2} = {result}";
                }
                else
                {
                    MessageBox.Show("Один или оба заказа не найдены.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите операцию и два заказа.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Здесь можно добавить код, который будет выполняться при клике на label1.
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Здесь можно добавить код, который будет выполняться при выборе элемента в comboBox1.
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Здесь можно добавить код, который будет выполняться при выборе элемента в comboBox2.
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}