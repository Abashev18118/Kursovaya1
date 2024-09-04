using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya1
{
    public class Waiter_s_schedule1 : Entity_sush
    {
        public DateTime Data { get; set; }
        public DateTime Start_time { get; set; }
        public DateTime End_time { get; set; }
        public int Restaurant_jal { get; set; }
        public string Waiter { get; set; }

        public void Add(DateTime Data, DateTime Start_time, DateTime End_time, int Restaurant_jal, string Waiter)
        {
            this.Data = Data;
            this.Start_time = Start_time;
            this.End_time = End_time;
            this.Restaurant_jal = Restaurant_jal;
            this.Waiter = Waiter;
        }
    }
}