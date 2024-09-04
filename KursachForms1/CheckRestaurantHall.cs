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
    public partial class CheckRestaurantHall : Form
    {
        private readonly Contekst _dbContext;
        public CheckRestaurantHall()
        {
            InitializeComponent();
            _dbContext = new Contekst();
        }
        private void CheckRestaurantHall_Load(object sender, EventArgs e)
        {
            RefreshHalls();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Удаление выбранного зала из базы данных
            var selectedHallNumber = int.Parse(comboBox1.SelectedItem.ToString());
            var selectedHall = _dbContext.newhalls.FirstOrDefault(h => h.number_of_hall == selectedHallNumber);

            if (selectedHall != null)
            {
                _dbContext.newhalls.Remove(selectedHall);
                _dbContext.SaveChanges();
                MessageBox.Show("Зал ресторана успешно удален.");
            }
            else
            {
                MessageBox.Show("Зал не найден.");
            }

            // Обновление информации о залах
            RefreshHalls();
        }

        private void RefreshHalls()
        {
            var halls = _dbContext.newhalls.ToList();

            // Очистка comboBox1 и текстового поля перед добавлением новой информации
            comboBox1.Items.Clear();
            textBox1.Clear();
            textBox1.Text += "Залы ресторана \r\n";

            // Заполнение comboBox1 номерами залов и вывод информации о каждом зале в текстовое поле
            foreach (var hall in halls)
            {
                comboBox1.Items.Add(hall.number_of_hall);
                textBox1.Text += $"\r\nНомер зала: {hall.number_of_hall}, Площадь: {hall.square}, Количество столов: {hall.number_of_tables}," +
                    $" Имя и фамилия официанта: {hall.FirstName_LastName}, График официанта: {hall.grafikwaiter}\r\n";
            }
        }
    }
}