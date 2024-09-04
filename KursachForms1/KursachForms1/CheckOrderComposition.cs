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
    public partial class CheckOrderComposition : Form
    {
        private readonly Contekst _dbContext;
        public CheckOrderComposition()
        {
            InitializeComponent();
            _dbContext = new Contekst();
        }
        private void CheckOrderComposition_Load(object sender, EventArgs e)
        {
            RefreshOrderCompositions();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Удаление выбранного заказа из базы данных
            var selectedOrderNumber = int.Parse(comboBox1.SelectedItem.ToString());
            var selectedOrderComposition = _dbContext.compositions.FirstOrDefault(oc => oc.Number == selectedOrderNumber);

            if (selectedOrderComposition != null)
            {
                _dbContext.compositions.Remove(selectedOrderComposition);
                _dbContext.SaveChanges();
                MessageBox.Show("Композиция заказа успешно удалена.");
            }
            else
            {
                MessageBox.Show("Заказ не найден.");
            }

            // Обновление информации о заказах
            RefreshOrderCompositions();
        }

        private void RefreshOrderCompositions()
        {
            var orderCompositions = _dbContext.compositions.ToList();

            // Очистка comboBox1 и текстового поля перед добавлением новой информации
            comboBox1.Items.Clear();
            textBox1.Clear();
            textBox1.Text += "Состав заказов \r\n";

            // Заполнение comboBox1 номерами заказов и вывод информации о каждом составе заказа в текстовое поле
            foreach (var orderComposition in orderCompositions)
            {
                comboBox1.Items.Add(orderComposition.Number);
                textBox1.Text += $"\r\nНомер: {orderComposition.Number},Сумма: {orderComposition.Summ}, Пожелания: {orderComposition.Wishes}, Количество: {orderComposition.Quantity}\r\n";
            }
        }
    }
}