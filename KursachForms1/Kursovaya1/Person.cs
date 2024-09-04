using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya1
{
    public abstract class Person : Entity_sush
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string PassportData { get; set; }
        public string Phone_number { get; set; }

        public abstract void Add(string LastName,string FirstName,string MiddleName,string PassportData, string Phone_number);
    }
}
