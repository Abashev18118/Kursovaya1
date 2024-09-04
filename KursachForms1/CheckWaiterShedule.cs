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
    public partial class CheckWaiterShedule : Form
    {
        private readonly Contekst _dbContext;
        public CheckWaiterShedule()
        {
            InitializeComponent();
            _dbContext = new Contekst();
        }
        private void CheckWaiterShedule_Load(object sender, EventArgs e)
        {
            RefreshSchedules();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Удаление выбранного графика из базы данных
            var selectedWaiterName = comboBox1.SelectedItem.ToString();
            var selectedSchedule = _dbContext.shedules1.FirstOrDefault(s => s.Waiter == selectedWaiterName);

            if (selectedSchedule != null)
            {
                _dbContext.shedules1.Remove(selectedSchedule);
                _dbContext.SaveChanges();
                MessageBox.Show("График официанта успешно удален.");
            }
            else
            {
                MessageBox.Show("График не найден.");
            }

            // Обновление информации о графиках
            RefreshSchedules();
        }

        private void RefreshSchedules()
        {
            var schedules = _dbContext.shedules1.ToList();

            // Очистка comboBox1 и текстового поля перед добавлением новой информации
            comboBox1.Items.Clear();
            textBox1.Clear();
            textBox1.Text += "Графики работы официантов \r\n";

            // Заполнение comboBox1 именами официантов и вывод информации о каждом графике в текстовое поле
            foreach (var schedule in schedules)
            {
                comboBox1.Items.Add(schedule.Waiter);
                textBox1.Text += $"\r\nДата: {schedule.Data}, Время начала: {schedule.Start_time}, Время окончания: {schedule.End_time}," +
                    $"Зал работы: {schedule.Restaurant_jal}, Инициалы официанта: {schedule.Waiter}\r\n";
            }
        }
    }
}