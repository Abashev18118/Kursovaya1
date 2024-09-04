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
    public partial class GlavnuyPOCHeck : Form
    {
        public GlavnuyPOCHeck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//О клиентах
        {
            CheckClientForm CheckClientForm = new CheckClientForm();
            CheckClientForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)//О блюде
        {
            CheckDish CheckDish = new CheckDish();
            CheckDish.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)//О меню
        {
            CheckMenu CheckMenu = new CheckMenu();
            CheckMenu.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)//О заказе
        {
            CheckOrder CheckOrder = new CheckOrder();
            CheckOrder.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)//О составе заказа
        {
            CheckOrderComposition CheckOrderComposition = new CheckOrderComposition();
            CheckOrderComposition.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)//О ресторане
        {
            CheckRestaurant CheckRestaurant = new CheckRestaurant();
            CheckRestaurant.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)//О столике
        {
            CheckTable CheckTable = new CheckTable();
            CheckTable.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)//Об официанте
        {
            CheckWaiter CheckWaiter = new CheckWaiter();
            CheckWaiter.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)//О графике официанта
        {
            CheckWaiterShedule CheckWaiterShedule = new CheckWaiterShedule();
            CheckWaiterShedule.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)//О зале ресторана
        {
            CheckRestaurantHall CheckRestaurantHall = new CheckRestaurantHall();
            CheckRestaurantHall.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)//Вернуться на главную форму
        {
            GlavnayhForm GlavnayhForm = new GlavnayhForm();
            GlavnayhForm.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DublCheckClient DublCheckClient = new DublCheckClient();
            DublCheckClient.ShowDialog();
        }
    }
}
