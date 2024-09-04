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
    public partial class RestoranuchForm : Form
    {
        private Contekst db;

        public RestoranuchForm()
        {
            InitializeComponent();
            db = new Contekst();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RestoranuchForm_Load(object sender, EventArgs e)
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

                if (square != 0)
                {
                    Newhall hall = new Newhall();
                    hall.Add(numberOfHall, square, numberOfTables, FirstName_LastName, grafikwaiter);
                    db.newhalls.Add(hall);
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
