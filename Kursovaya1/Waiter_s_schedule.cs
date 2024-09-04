using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya1
{
    public class Waiter_s_schedule : Entity_sush
    {
        public DateTime Data { get; set; }
        public DateTime Start_time { get; set; }
        public DateTime End_time { get; set; }
        public Guid Restaurant_hallid { get; set; }
        public Restaurant_hall Restaurant_hall { get; set; }
        public Guid Waiterid { get; set; }
        public Waiter Waiter { get; set; }

        public void Add(DateTime Data, DateTime Start_time, DateTime End_time, Restaurant_hall Restaurant_hall, Waiter Waiter)
        {
            this.Data = Data;
            this.Start_time = Start_time;
            this.End_time = End_time;
            this.Restaurant_hallid = Restaurant_hall.Id; // Убедитесь, что Restaurant_hall имеет Id
            this.Restaurant_hall = Restaurant_hall;
            this.Waiter = Waiter;
        }
    }
}