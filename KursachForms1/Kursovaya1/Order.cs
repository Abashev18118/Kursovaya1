using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya1
{
    public class Order : Entity_sush
    {
        public int Number_of_Order { get; set; }
        public DateTime Date_of_Order { get; set; }
        public string Order_Status { get; set; } = null!;
        public double Order_amount { get; set; }
        public int Restaurant_hall { get; set; }
        public int TableNumber { get; set; }
        public string RestaurantName { get; set; }
        public void Add(int Number_of_Order, DateTime Date_of_Order, string Order_Status,
            double Order_amount, int Restaurant_hall, int TableNumber, string RestaurantName)
        {
            this.Number_of_Order = Number_of_Order;
            this.Date_of_Order = Date_of_Order;
            this.Order_Status = Order_Status;
            this.Order_amount = Order_amount;
            this.Restaurant_hall = Restaurant_hall;
            this.TableNumber = TableNumber;
            this.RestaurantName = RestaurantName;
        }
    }
}
