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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KursachForms1
{
    public partial class ClientForm : Form
    {
        private Contekst db;
        public ClientForm()
        {
            InitializeComponent();
            db = new Contekst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Contekst db = new())
            {
                string f = textBox1.Text;
                string i = textBox2.Text;
                string o = textBox3.Text;
                string passport = textBox4.Text;
                string phone = textBox5.Text;
                string email = textBox6.Text;
                Client Client = new Client();
                Client.Add(f,i,o,passport,phone,email);
                db.clients.Add(Client);
                db.SaveChanges();

                MessageBox.Show("Клиент успешно добавлен.");
            }
        }
    }
}
