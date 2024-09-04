using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya1
{
    public class Waiter_Table : Entity_sush
    {
        public Guid Waiters_Id { get; set; }
        public Waiter Waiter { get; set; }

        public Guid Table_Id { get; set; }

        public Table Table { get; set; }

        public void Add(Waiter Waiter, Table Table)
        {
            this.Waiter = Waiter;
            this.Table = Table;
        }


    }//+
}
