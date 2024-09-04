using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya1
{
    public class Client : Person
    {
        public string email { get; set; } = null!;

        // Исправленная строка
        public ICollection<Customer_Order> Customer_Orders { get; set; } = new List<Customer_Order>();
        public override void Add(string LastName, string FirstName, string MiddleName, string PassportData,
         string Phone_number)
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.PassportData = PassportData;
            this.Phone_number = Phone_number;
        }
        public void Add(string LastName, string FirstName, string MiddleName, string PassportData,
         string Phone_number, string email)
        {
           Add(LastName,FirstName, MiddleName,PassportData, Phone_number);
            this.email = email;

        }
    }
}
