using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya1
{
    public class Composition_of_the_order : Entity_sush
    {
        public double Summ { get; set; }

        public string Wishes { get; set; } = null!;

        public int Quantity { get; set; }

        public int Number {  get; set; }


        public void Add(double Summ, string Wishes, int Quantity, int Number)
        {
            this.Summ = Summ;
            this.Wishes = Wishes;
            this.Quantity = Quantity;
            this.Number = Number;
        }

    }
}
