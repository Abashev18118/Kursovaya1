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
    public partial class MenuForm : Form
    {
        private Contekst db;
        public MenuForm()
        {
            InitializeComponent();
            db = new Contekst();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Contekst db = new())
            {
                try
                {
                    int numberMenu = int.Parse(textBox1.Text); // Номер меню
                    string nameMenu = comboBox1.SelectedItem.ToString(); // Название меню
                    string description = comboBox2.SelectedItem.ToString(); // Описание

                    Menu menu = new Menu();
                    menu.Add(numberMenu, nameMenu, description);
                    db.menues.Add(menu);
                    db.SaveChanges();

                    MessageBox.Show("Меню успешно добавлено.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Введены некорректные данные. Пожалуйста, проверьте их и попробуйте снова.");
                }
            }
        }
    }
}
