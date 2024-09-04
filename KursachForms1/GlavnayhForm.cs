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
    public partial class GlavnayhForm : Form
    {
        public GlavnayhForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientForm ClientForm = new ClientForm();
            ClientForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Composition_of_the_orderForm Composition_of_the_orderForm = new Composition_of_the_orderForm();
            Composition_of_the_orderForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DishForm DishForm = new DishForm(this); // Передаем текущий экземпляр GlavnayhForm
            DishForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mark_up_of_the_dishForm Mark_up_of_the_dishForm = new Mark_up_of_the_dishForm();
            Mark_up_of_the_dishForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MenuForm MenuForm = new MenuForm();
            MenuForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OrderForm OrderForm = new OrderForm();
            OrderForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RestaurantForm RestaurantForm = new RestaurantForm();
            RestaurantForm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RestoranuchForm RestoranuchForm = new RestoranuchForm();
            RestoranuchForm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TableForm TableForm = new TableForm();
            TableForm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WaiterFormForm WaiterFormForm = new WaiterFormForm();
            WaiterFormForm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Waiter_s_scheduleForm Waiter_s_scheduleForm = new Waiter_s_scheduleForm();
            Waiter_s_scheduleForm.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            GlavnuyPOCHeck GlavnuyPOCHeck = new GlavnuyPOCHeck();
            GlavnuyPOCHeck.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SummXusl SummXusl = new SummXusl();
            SummXusl.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Poisk1 Poisk1 = new Poisk1();
            Poisk1.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Poisk2 Poisk2 = new Poisk2();
            Poisk2.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ConnectionForm ConnectionForm = new ConnectionForm();
            ConnectionForm.ShowDialog();
        }
    }
}
