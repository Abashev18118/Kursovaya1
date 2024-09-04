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
    public partial class Mark_up_of_the_dishForm : Form
    {
        private Contekst db;
        public Mark_up_of_the_dishForm()
        {
            InitializeComponent();
            db = new Contekst();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//Наценка
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Contekst db = new())
            {
                double extraCharge = double.Parse(textBox1.Text); // Наценка

                Mark_up_of_the_dish markUp = new Mark_up_of_the_dish();
                markUp.Add(extraCharge);
                db.mark_Up_Of_The_Dishes.Add(markUp);
                db.SaveChanges();

                MessageBox.Show("Наценка успешно добавлена.");
            }
        }
    }
}
