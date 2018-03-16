using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public string EMail { get; set; }
        public int Balance { get; set; }
        public DateTime LastChange { get; set; }
        public int ID { get; set; }

        public Customer()
        {
            this.FirstName = "-";
            this.LastName = "-";
            this.EMail = "-";
            this.Balance = 0;
            this.LastChange = DateTime.Now; ;
            this.ID = -1;
        }

        public Customer(string firstName, string lastName, string email, int balance, int ID )
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EMail = email;
            this.Balance = balance;
            this.LastChange = DateTime.Now;;
            this.ID = ID;
        }

        public void DoATransition(int amount)
        {
            this.Balance += amount;
        }

        public override string ToString()
        {
            string s =this.ID+" "+ this.FirstName + " " + this.LastName + " " + this.EMail + " " + this.Balance;
            return s;
        }
    }
}
