using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya1
{
    public class Dish_margin_of_dish : Entity_sush
    {
        public Guid Dish_Id { get; set; }
        public Dish Dish { get; set; }

        public Guid Mark_up_of_the_dish_Id { get; set; }

        public Mark_up_of_the_dish Mark_up_of_the_dish { get; set; }

        public void Add(Dish Dish, Mark_up_of_the_dish Mark_up_of_the_dish)
        {
            this.Dish = Dish;
            this.Mark_up_of_the_dish = Mark_up_of_the_dish;
        }
    }
}
