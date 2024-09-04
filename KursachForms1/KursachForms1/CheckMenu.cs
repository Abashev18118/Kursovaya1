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
    public partial class CheckMenu : Form
    {
        private readonly Contekst _dbContext;
        public CheckMenu()
        {
            InitializeComponent();
            _dbContext = new Contekst();

            // Заполнение comboBox1 номерами меню при загрузке формы
            var menus = _dbContext.menues.ToList();
            foreach (var menu in menus)
            {
                comboBox1.Items.Add(menu.number_menu);
            }
        }

        private void CheckMenu_Load(object sender, EventArgs e)
        {
            UpdateMenuText();
        }

        private void UpdateMenuText()
        {
            var menus = _dbContext.menues.ToList();

            // Очистка текстового поля перед добавлением новой информации
            textBox1.Clear();
            textBox1.Text += "Меню \r\n";

            // Вывод информации о каждом меню в текстовое поле
            foreach (var menu in menus)
            {
                textBox1.Text += $"\r\nНомер меню: {menu.number_menu}, Название меню: {menu.name_menu}, Описание: {menu.description}\r\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                int selectedMenuNumber = (int)comboBox1.SelectedItem;

                // Найти меню с выбранным номером и удалить его
                var menuToRemove = _dbContext.menues.FirstOrDefault(m => m.number_menu == selectedMenuNumber);
                if (menuToRemove != null)
                {
                    _dbContext.menues.Remove(menuToRemove);
                    _dbContext.SaveChanges();

                    // Обновить текстовое поле
                    UpdateMenuText();

                    // Удалить выбранный номер меню из comboBox1
                    comboBox1.Items.Remove(selectedMenuNumber);
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Ваш код здесь
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ваш код здесь
        }
    }
}
