using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya1
{
    public class Menu_Mark_up_of_dish : Entity_sush
    {
        public Guid Menu_Id { get; set; }
        public Menu Menu { get; set; }

        public Guid Mark_up_of_the_dish_Id { get; set; }

        public Mark_up_of_the_dish Mark_up_of_the_dish { get; set; }

        public void Add(Menu Menu, Mark_up_of_the_dish Mark_up_of_the_dish)
        {
            this.Menu = Menu;
            this.Mark_up_of_the_dish = Mark_up_of_the_dish;
        }
    }
}
