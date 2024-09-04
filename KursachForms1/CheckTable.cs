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
    public partial class CheckTable : Form
    {
        private readonly Contekst _dbContext;
        public CheckTable()
        {
            InitializeComponent();
            _dbContext = new Contekst();
        }
        private void CheckTable_Load(object sender, EventArgs e)
        {
            RefreshTables();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Удаление выбранного столика из базы данных
            var selectedTableNumber = int.Parse(comboBox1.SelectedItem.ToString());
            var selectedTable = _dbContext.tables.FirstOrDefault(t => t.number_of_table == selectedTableNumber);

            if (selectedTable != null)
            {
                _dbContext.tables.Remove(selectedTable);
                _dbContext.SaveChanges();
                MessageBox.Show("Столик успешно удален.");
            }
            else
            {
                MessageBox.Show("Столик не найден.");
            }

            // Обновление информации о столиках
            RefreshTables();
        }

        private void RefreshTables()
        {
            var tables = _dbContext.tables.ToList();

            // Очистка comboBox1 и текстового поля перед добавлением новой информации
            comboBox1.Items.Clear();
            textBox1.Clear();
            textBox1.Text += "Столики \r\n";

            // Заполнение comboBox1 номерами столиков и вывод информации о каждом столике в текстовое поле
            foreach (var table in tables)
            {
                comboBox1.Items.Add(table.number_of_table);
                textBox1.Text += $"\r\nНомер столика: {table.number_of_table}, Количество возможных мест: {table.number_of_possible_places}, Статус: {table.status}\r\n";
            }
        }
    }
}