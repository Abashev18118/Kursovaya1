using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya1
{
    public class Mark_up_of_the_dish : Entity_sush
    {
        public double extra_charge { get; set; }

        public void Add(double extra_charge)
        {
            this.extra_charge = extra_charge;
        }
    }
}
