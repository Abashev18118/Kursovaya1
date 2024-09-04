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
    public partial class Composition_of_the_orderForm : Form
    {
        private Contekst db;
        public Composition_of_the_orderForm()
        {
            InitializeComponent();
            db = new Contekst();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//Сумма
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//Количество
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//Пожелания
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)//Номер Заказа
        {

        }

        private void button1_Click(object sender, EventArgs e)//Добавить в бд
        {
            using (Contekst db = new())
            {
                double summ = double.Parse(textBox1.Text); // Сумма
                string wishes = textBox2.Text; // Пожелания
                int quantity = int.Parse(textBox3.Text); // Количество
                int number = int.Parse(textBox4.Text);//номер заказа



                if (number != null)
                {
                    Composition_of_the_order composition = new Composition_of_the_order();
                    composition.Add(summ, wishes, quantity, number);
                    db.compositions.Add(composition);
                    db.SaveChanges();

                    MessageBox.Show("Композиция заказа успешно добавлена.");
                }
                else
                {
                    MessageBox.Show("Заказ или блюдо не найдены.");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
