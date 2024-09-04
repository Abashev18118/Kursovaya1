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
    public partial class WaiterFormForm : Form
    {
        private Contekst db;
        public WaiterFormForm()
        {
            InitializeComponent();
            db = new Contekst();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//Зарплата
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//Столики обслуживания
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//Зал обслуживания
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Contekst db = new())
            {
                try
                {
                    double salary = double.Parse(textBox1.Text); // Зарплата
                    string serviceTables = textBox2.Text; // Столики обслуживания
                    int serviceHall = int.Parse(textBox3.Text); // Зал обслуживания
                    string phoneNumber = textBox4.Text; // Номер телефона
                    string lastName = textBox5.Text; // Фамилия
                    string firstName = textBox6.Text; // Имя 
                    string middleName = textBox7.Text; // Отчество
                    string passportData = textBox8.Text; // Паспортные данные

                    Waiter waiter = new Waiter();
                    waiter.Add(salary, serviceTables, serviceHall, phoneNumber, firstName, lastName, middleName, passportData);
                    db.waiters.Add(waiter);
                    db.SaveChanges();

                    MessageBox.Show("Официант успешно добавлен.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Введены некорректные данные. Пожалуйста, проверьте их и попробуйте снова.");
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)//Номер телефона
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)//Фамилия
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)//Имя 
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)//Отчество
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)//Паспортные данные
        {

        }
    }
}
