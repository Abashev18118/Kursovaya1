using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya1
{
    public class Table : Entity_sush
    {
        public int number_of_table { get; set; }

        public int number_of_possible_places { get; set; }
        public string status { get; set; } = null!;

        public void Add(int number_of_table, int number_of_possible_places, string status)
        {
            this.number_of_table = number_of_table;
            this.number_of_possible_places = number_of_possible_places;
            this.status = status;
        }
    }
}
