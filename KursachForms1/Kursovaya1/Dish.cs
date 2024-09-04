using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya1
{
    public class Dish : Entity_sush
    {
        public string named { get; set; } = null!;

        public double price { get; set; }

        public double Cost_price { get; set; }

        public void Add(string named, double price, double Cost_price)
        {
            this.named = named;
            this.price = price;
            this.Cost_price = Cost_price;
        }
    }
}
