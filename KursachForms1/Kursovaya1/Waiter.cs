using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya1
{
    public class Waiter : Person
    {
        public double Salary { get; set; }

        public string Service_tables { get; set; } = null!;

        public int Service_Hall { get; set; }


        public ICollection<Waiter_s_schedule> shedules { get; set; } = new List<Waiter_s_schedule>();

        public ICollection<Waiter_Table> Waiter_Tables { get; set; } = new List<Waiter_Table>();

        public override void Add(string LastName, string FirstName, string MiddleName, string PassportData,
         string Phone_number)
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.PassportData = PassportData;
            this.Phone_number = Phone_number;
        }
        public void Add(double Salary, string Service_tables, int Service_Hall, string Phone_number,
           string FirstName, string LastName, string MiddleName, string PassportData)
        {
            Add(LastName, FirstName, MiddleName, PassportData, Phone_number);
            this.Salary = Salary;
            this.Service_tables = Service_tables;
            this.Service_Hall = Service_Hall;
          
        }

    }
}
