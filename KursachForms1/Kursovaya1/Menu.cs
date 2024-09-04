using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya1
{
    public class Menu : Entity_sush
    {
        public int number_menu { get; set; }
        public string name_menu { get; set; } = null!;
        public string description { get; set; } = null!;

        public void Add(int number_menu, string name_menu, string description)
        {
            this.number_menu = number_menu;
            this.name_menu = name_menu;
            this.description = description;
        }

    }
}
