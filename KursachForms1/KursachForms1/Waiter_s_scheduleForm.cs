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
    public partial class Waiter_s_scheduleForm : Form
    {
        private Contekst db;
        public Waiter_s_scheduleForm()
        {
            InitializeComponent();
            db = new Contekst();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)//Дата
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)//Время начала работы
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)//Время конца работы
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//Зал ресторана
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Contekst db = new())
            {
                
                
                    DateTime data = dateTimePicker1.Value.ToUniversalTime(); ; // Дата
                    DateTime startTime = dateTimePicker2.Value.ToUniversalTime(); ; // Время начала работы
                    DateTime endTime = dateTimePicker3.Value.ToUniversalTime(); ; // Время конца работы
                    int hallNumber = int.Parse(textBox1.Text); // Зал ресторана
                    string waiterName = textBox2.Text; // Имя официанта

                    if (waiterName != null)
                    {
                        Waiter_s_schedule1 schedule1 = new Waiter_s_schedule1();
                        schedule1.Add(data, startTime, endTime, hallNumber, waiterName);
                        db.shedules1.Add(schedule1);
                        db.SaveChanges();

                        MessageBox.Show("График официанта успешно добавлен.");
                    }
                    else
                    {
                        MessageBox.Show("Зал или официант не найдены.");
                    }
                
             
            }
        }
    }
}
