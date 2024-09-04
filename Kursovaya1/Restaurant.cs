using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya1
{
    public class Restaurant : Entity_sush
    {
        public int res_number { get; set; }
        public string address { get; set; }

        public double rating { get; set; }

        public int capacity { get; set; }
        public string type_of_hall { get; set; }


        public void Add(int res_number, string address, double rating, int capacity, string type_of_hall)
        {
            this.res_number = res_number;
            this.address = address;
            this.rating = rating;
            this.capacity = capacity;
            this.type_of_hall = type_of_hall;        }
    }
}
