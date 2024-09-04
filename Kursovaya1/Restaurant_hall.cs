using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya1
{
    public class Restaurant_hall : Entity_sush
    {
        public int number_of_hall { get; set; }
        public double square { get; set; }
        public int number_of_tables { get; set; }
        public string FirstName_LastName { get; set; }
        public string grafikwaiter { get; set; }
        public Waiter_s_schedule Waiter_s_schedule { get; set; }

        public void Add(int number_of_hall, double square, int number_of_tables, string FirstName_LastName, string grafikwaiter, Waiter_s_schedule waiter_s_schedule)
        {
            this.number_of_hall = number_of_hall;
            this.square = square;
            this.number_of_tables = number_of_tables;
            this.FirstName_LastName = FirstName_LastName;
            this.grafikwaiter = grafikwaiter;
            this.Waiter_s_schedule = waiter_s_schedule;
        }
    }
}

