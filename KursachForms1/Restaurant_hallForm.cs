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
    public partial class Restaurant_hallForm : Form
    {
        private Contekst db;

        public Restaurant_hallForm()
        {
            InitializeComponent();
            db = new Contekst();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // Номер зала
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e) // Площадь
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e) // Количество столов
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e) // Официант, который обслуживает зал
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e) // График официанта
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Contekst db = new())
            {
                int numberOfHall = int.Parse(textBox1.Text); // Номер зала
                double square = double.Parse(textBox2.Text); // Площадь
                int numberOfTables = int.Parse(textBox3.Text); // Количество столов
                string FirstName_LastName = textBox4.Text; // Имя официанта
                string grafikwaiter = textBox5.Text; // Дата графика официанта

                // Ищем существующий график или создаем новый (примерно)
                var waiterSchedule = db.shedules.FirstOrDefault(ws => ws.Data.ToString() == grafikwaiter);

                

                if (square != 0)
                {
                    Restaurant_hall hall = new Restaurant_hall();
                    hall.Add(numberOfHall, square, numberOfTables, FirstName_LastName, grafikwaiter, waiterSchedule);
                    db.halls.Add(hall);
                    db.SaveChanges();

                    MessageBox.Show("Зал ресторана успешно добавлен.");
                }
                else
                {
                    MessageBox.Show("Площадь зала не может быть нулевой.");
                }
            }
        }
    }
}
