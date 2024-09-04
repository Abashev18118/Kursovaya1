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
    public partial class TableForm : Form
    {
        private Contekst db;
        public TableForm()
        {
            InitializeComponent();
            db = new Contekst();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Contekst db = new())
            {
                try
                {
                    int numberOfTable = int.Parse(textBox1.Text); // Номер стола
                    int numberOfPossiblePlaces = int.Parse(textBox2.Text); // Количество возможных мест
                    string status = comboBox1.SelectedItem.ToString(); // Статус

                    Table table = new Table();
                    table.Add(numberOfTable, numberOfPossiblePlaces, status);
                    db.tables.Add(table);
                    db.SaveChanges();

                    MessageBox.Show("Стол успешно добавлен.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Введены некорректные данные. Пожалуйста, проверьте их и попробуйте снова.");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
