using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya1
{
    public class Customer_Order : Entity_sush
    {
        public Guid Client_Id { get; set; }
        public Client Client { get; set; }

        public Guid Order_Id { get; set; }

        public Order Order { get; set; }

        public void Add(Client Client, Order Order)
        {
            this.Client = Client;
            this.Order = Order;
        }
    }
}
